using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Ingresar 4 números enteros de forma aleatoria:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            if (a > b && b > c && c > d)
                Console.WriteLine("Están ordenados de forma decreciente");
            else
                Console.WriteLine("No están ordenador de forma decreciente");
        }
    }
}
