using Calculadora2.Model;
using System;

namespace Calculadora2
{
    internal class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Operacao op = new(Calculadora.Somar);
            Operacao op1 = Calculadora.Subritair;
            // Ambas manueira de invocar delegates
            op.Invoke(1, 2); 
            op1(1, 2);
            Console.WriteLine(op);
            Console.WriteLine(op1);
        }
    }
}
