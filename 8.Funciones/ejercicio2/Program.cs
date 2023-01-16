using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un nro:");
                n = int.Parse(Console.ReadLine());
                if(par(n))
                    con++;
            }
            Console.WriteLine("La cantidad pares es : " + con);
        }
        static bool par(int a){
            if(a % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
