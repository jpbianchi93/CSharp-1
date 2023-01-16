using System;

namespace ejercicio3
{
    class Progmemoria
    {
        static void Main(string[] args)
        {
            int procesador, memoria, disco;
            float precio;
            precio = 0;

            Console.WriteLine("Elija el número dependiendo de la opción de procesador que desea en su equipo:");
            Console.WriteLine("1 - i5");
            Console.WriteLine("2 - i7");
            Console.WriteLine("3 - i9");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Elija el número dependiendo de la opción de la memoria memoria que desea en su equipo:");
            Console.WriteLine("1 - 8 memoria");
            Console.WriteLine("2 - 16 memoria");
            Console.WriteLine("3 - 32 memoria");
            memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Desea ampliar el almacenamiento a 1 TB en su equipo?:");
            Console.WriteLine("1 - si");
            Console.WriteLine("2 - no");
            disco = int.Parse(Console.ReadLine());

            switch(procesador){
                case 1:
                    switch(memoria){
                        case 1:
                    precio = 800;
                            break;
                        case 2:
                    precio = 900;
                            break;
                        case 3:
                    precio = 1000;
                            break;
                        }
                    break;
                case 2:
                    switch(memoria){
                        case 1:
                    precio = 900;
                            break;
                        case 2:
                    precio = 1000;
                            break;
                        case 3:
                    precio = 1400;
                            break;
                    }
                    break;
                default:
                    switch(memoria){
                        case 1:
                    precio = 1200;
                            break;
                        case 2:
                    precio = 1400;
                            break;
                        case 3:
                    precio = 2000;
                            break;
                    }
                break;
            }
            
            if(disco == 1)
                precio = precio + 300;
            
            Console.WriteLine("El precio final del equipo es: $" + precio);
        }
    }
}
