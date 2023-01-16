using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un nro:");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int max = numeros[0];
            int pos = 1;
            for (int i = 0; i < 10; i++)
            {
                if(numeros[i] > max)
                {
                    max = numeros[i];
                    pos = i + 1;
                }
            }
            Console.WriteLine("El valor máximo es: " + max + ", se encuentra en la posición: " + pos);
        }
    }
}
