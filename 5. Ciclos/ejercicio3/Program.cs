using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, promedio, con = 0, acu = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese edad:");
                n = int.Parse(Console.ReadLine());
                if(n > 18)
                    acu += n;
                    con++;
            }
            promedio = acu / con;
            Console.WriteLine("El promedio de edad de mayores de 18 años es: " + promedio);
            
        }
    }
}
