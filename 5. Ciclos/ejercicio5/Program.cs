using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0, min = 0;
            int conImpar = 0;
            bool banPar = false;

            for (int i = 0; i < 20 ; i++)
            {
                Console.WriteLine("Ingrese un nro:");
                n = int.Parse(Console.ReadLine());
                if(n % 2 == 0)
                {
                    // concepto de bandera
                    if(banPar == false)
                    {
                        max = n;
                        banPar = true;
                    }
                    else if(n > max)
                        max = n;
                    // 
                }
                else
                {
                    // contador
                    conImpar++;
                    if(conImpar == 0)
                        min = n;
                    else if(n < max)
                        min = n;  
                    }
                    // 
            }
            Console.WriteLine("El máximo par es: " + max + ", y el mínimo impar es: " + min);
        }
    }
}
