using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, conNumeros, conImpares, grupoImparesMax = 0, min, conOrdenados = 0;
            double porcentajeImpares = 0, porcentajeMax = -1;
            bool banderaOrdenado;

            for (int i = 0; i < 5; i++)
            {
                conNumeros = 0;
                conImpares = 0;
                banderaOrdenado = true;
                Console.WriteLine("Grupo: " + (i+1));
                n = int.Parse(Console.ReadLine());
                min = n;
                while (n != 0)
                {
                    //punto a
                    conNumeros++;
                    if (n % 2 != 0)
                        conImpares++;
                    //punto b
                    if (n <= min)
                    min = n;
                    else
                        banderaOrdenado = false;

                    n = int.Parse(Console.ReadLine());
                }
                //punto a
                porcentajeImpares = conImpares * 100 / conNumeros;
                if (porcentajeImpares > porcentajeMax)
                {
                    porcentajeMax = porcentajeImpares;
                    grupoImparesMax = i + 1;
                }
                //punto b
                if (banderaOrdenado)
                    conOrdenados++;
            }
            Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMax);
            Console.WriteLine("La cantidad de grupos con los números ordenados: " + conOrdenados);
        }
    }
}
