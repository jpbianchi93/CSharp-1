using System;

namespace Ej2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            float kilometros, velocidad, tiempo;
            
            Console.WriteLine("Indique los kms entre las dos ciudades:");
            kilometros = float.Parse( Console.ReadLine());
            Console.WriteLine("Indique el km/h promedio del vehículo:");
            velocidad = float.Parse( Console.ReadLine());
            
            tiempo = kilometros / velocidad;
            
            Console.WriteLine("El tiempo será de: " + tiempo.ToString("0.00") + " horas");
        }
    }
}
