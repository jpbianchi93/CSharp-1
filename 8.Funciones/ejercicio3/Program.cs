using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, promedio;
            int conPrimo = 0, acuPrimo = 0;

            Console.WriteLine("Ingrese un nro:");
            n = int.Parse(Console.ReadLine());
            if (primo(n))
                {
                    conPrimo++;
                    acuPrimo+= n;
                }
            while (n != 0)
            {
                Console.WriteLine("Ingrese otro nro:");
                n = int.Parse(Console.ReadLine());
                if (primo(n))
                {
                    conPrimo++;
                    acuPrimo+= n;
                }
                
            }
            promedio = acuPrimo / conPrimo;

            Console.WriteLine("El promedio de números primos es: " + promedio);
        }
        static bool primo(int a){
            int con = 0;
            for (int i = 1; i <= a; i++)
            {
                if(a % i == 0)
                    con++;
            }
            if(con == 2)
                return true;
            else
                return false;
        }
    }
}
