using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, max = 0;
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un nro:");
                n = int.Parse(Console.ReadLine()); 
                
                if(i == 0)
                    max = n;
                else if(n > max)
                    max = n;
            }
            Console.WriteLine("El máximo es: " + max);
        }
    }
}
