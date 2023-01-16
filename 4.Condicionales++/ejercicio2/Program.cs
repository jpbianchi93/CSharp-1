using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float litros, importeTotal;
            
            Console.WriteLine("Ingrese importeTota total de la venta:");
            importeTotal   = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros vendidos:");
            litros = float.Parse(Console.ReadLine());

            if(litros > 500)
                importeTotal   = importeTotal - (importeTotal * 0.25f);             
            else if(litros > 300)
                importeTotal   = importeTotal - (importeTotal * 0.15f);
            else if(litros > 100)
                importeTotal   = importeTotal - (importeTotal * 0.1f);
            
            Console.WriteLine("El importe total final es: $" + importeTotal);
            }
    }
}
