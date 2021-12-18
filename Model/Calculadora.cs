using System;

namespace Calculadora2.Model
{
    public class Calculadora
    {
        public static void Somar(int x, int y)
        {
            Console.WriteLine($"A soma de {x} e {y} é = {x+y}");
        }
        public static void Subritair(int x, int y)
        {
            Console.WriteLine($"A subritação de {x} e {y} =  {x - y}");

        }
        public static void Divisao(int x, int y)
        {
            Console.WriteLine($"A divisão de {x} e { y} = { x / y}");
        }
        public static void Multiplicar(int x, int y)
        {
            Console.WriteLine($"A multiplicação de  {x} e { y} = {x * y}");
        }
    }
}
