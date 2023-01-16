using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double importeCompra, descuento10, descuento18, importeFinal;
            
            Console.WriteLine("Importe de compra:");
            
            importeCompra = double.Parse(Console.ReadLine());
            
            descuento10 = importeCompra * 0.1d;
            descuento18 = importeCompra * 0.18d;

            if(importeCompra >= 1000)
                if (importeCompra >= 5000)
                importeFinal = importeCompra - descuento18;
                else
                importeFinal = importeCompra - descuento10;
            else
                importeFinal = importeCompra;

            Console.WriteLine("El importe final es: " + importeFinal);
            
        }
    }
}
