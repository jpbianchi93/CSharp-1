using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ciclos combinados:
         
            // For con For
            // int prom, acu, con, n;
            // 
            // for (int x = 0; x < 10; x++)
            // {
            //     acu = 0;
            //     for (int y = 0; y < 20; y++)
            //     {
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;
            //     }
            //     prom = acu / 20;
            //     Console.WriteLine("El promedio es: " + prom);
            // }
            
            // For con While
            // for (int i = 0; i < 10; i++)
            // {
            //    Console.WriteLine("Ingrese la edad: ");
            //     n = int.Parse(Console.ReadLine());
            //     acu = 0;
            //     con = 0;
            //     while (n != 0)
            //     {
            //         acu += n;
            //         con++;
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     prom = acu / con;
            //     Console.WriteLine("El promedio es: " + prom);
            // }

            // While con For
            // Console.WriteLine("Ingrese 1 para comenzar a procesar o 0 para terminar:");
            // n = int.Parse(Console.ReadLine());
            // while(n != 0)
            // {
            //     acu = 0;
            //     for (int y = 0; y < 20; y++)
            //     {
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;
            //     }
            //     prom = acu / 20;
            //     Console.WriteLine("El promedio es: " + prom);
            //
            //     Console.WriteLine("Ingrese 1 para continuar a procesar o 0 para terminar:");
            //     n = int.Parse(Console.ReadLine());
            // }

            // While con While
            // Console.WriteLine("Ingrese la edad: ");
            // n = int.Parse(Console.ReadLine());
            // while(n > 0)
            // {
            //     Console.WriteLine("Ingrese la edad: ");
            //     n = int.Parse(Console.ReadLine());
            //     acu = 0;
            //     con = 0;
            //     while (n != 0)
            //     {
            //         acu += n;
            //         con++;
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     prom = acu / con;
            //     Console.WriteLine("El promedio es: " + prom);
            // 
            //     Console.WriteLine("Ingrese la edad para continuar o un negativo para cortar: ");
            //     n = int.Parse(Console.ReadLine());
            // }

            // Corte de control
            // legajo, edad, sueldo, código de equipo
            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;
            
            //1 river
            //2 boca
            //3 racing

            Console.WriteLine("Ingrese el legajo:");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo:");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el código de equipo:");
            codigoEquipo = int.Parse(Console.ReadLine());
            while (sueldo > 0)
            {
                // CLAVE
                equipoActual = codigoEquipo;
                //
                while (codigoEquipo == equipoActual)
                {
                    //aca procesamos

                    Console.WriteLine("Ingrese el legajo:");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad:");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo:");
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el código de equipo:");
                    codigoEquipo = int.Parse(Console.ReadLine());
                    //aca se puede mostrar resultados   
                }
                //mostrar lo que necesito mostrar
            }
            //aca tambien se puede mostrar resultados
        }
    }
}
