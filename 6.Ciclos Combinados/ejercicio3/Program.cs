using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n, con, numLista = 0;
            do
            {
                numLista++;
                con = 0;
                Console.WriteLine("Lista " + numLista);
                n = int.Parse(Console.ReadLine());               
                while (n > 0)
                {
                    con++;
                    n = int.Parse(Console.ReadLine());              
                }
                Console.WriteLine("La cantidad de nros del grupo " + numLista + " es: " + con);
            }while (n >= 0);
        }
    }
}
