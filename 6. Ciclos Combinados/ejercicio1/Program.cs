using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con;
            for (int x = 0; x < 10; x++)
            {
                con = 0;
                Console.WriteLine("Ingrese un nro:");
                n = int.Parse(Console.ReadLine());
                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0)
                    con++;
                }
                if (con == 2)
                    Console.WriteLine("El nro " + n + " es primo.");
                else
                    Console.WriteLine("El nro " + n + " no es primo.");
            }
        }
    }
}
