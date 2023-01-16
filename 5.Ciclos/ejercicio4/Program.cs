using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            Console.WriteLine("Ingrese un nro:");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                    con++;
            }
            if(con == 2)
                Console.WriteLine("El nro ingresado es primo.");
            else
                Console.WriteLine("El nro ingresado no es primo.");
        }
    }
}
