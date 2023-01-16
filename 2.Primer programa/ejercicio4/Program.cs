using System;

namespace Ej2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalFacturado, porcentajeComision, comision, sueldoFinal;
            const float sueldo = 15000;
            porcentajeComision = 0.05f;
            
            Console.WriteLine("Ingrese el total facturado:");
            totalFacturado = float.Parse(Console.ReadLine());
            
            comision = totalFacturado * porcentajeComision;
            
            sueldoFinal = comision + sueldo;
            
            Console.WriteLine("El sueldo total a pagar es: " + sueldoFinal);
        }
    }
}
