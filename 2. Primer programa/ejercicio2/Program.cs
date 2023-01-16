using System;

namespace Ej2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cubo;
            
            Console.WriteLine("Introduzca un número:");
            n = int.Parse(Console.ReadLine());
            
            cubo = n * n * n;
            
            Console.WriteLine("El resultado de " + n + " elevado al cubo es: " + cubo);
        }
    }
}
