using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int acu = 0, con = 0, promedio;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese nro:");
                numeros[i] = int.Parse(Console.ReadLine());
                con++;
                acu += numeros[i];
            }
            promedio = acu / con;
            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine("Los valores mayores al promedio son:");
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] > promedio)
                {
                    Console.WriteLine("- " + numeros[i]);
                }
            }
        }
    }
}
