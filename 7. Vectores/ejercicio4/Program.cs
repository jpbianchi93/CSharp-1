using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cantVentas = new int [15];
            int articulo, n, posicion = 0;
            bool bandera;

            Console.WriteLine("Introduzca el número del artículo:");
            articulo = int.Parse(Console.ReadLine());
            articulo--;
            Console.WriteLine("Introduzca cantidad vendida: ");
            n = int.Parse(Console.ReadLine());
            cantVentas[articulo] = n;
            while (n != 0)
            {
                n = int.Parse(Console.ReadLine());
                cantVentas[articulo] += n;
            }
            Console.WriteLine("Desea seguir? ");
            bandera = bool.Parse(Console.ReadLine());
            while (bandera == true)
            {
                Console.WriteLine("Introduzca el número del artículo:");
                articulo = int.Parse(Console.ReadLine());
                articulo--;
                Console.WriteLine("Introduzca cantidad de ventas: ");
                n = int.Parse(Console.ReadLine());
                cantVentas[articulo] = n;
                while (n != 0)
                {
                    n = int.Parse(Console.ReadLine());
                    cantVentas[articulo] += n;
                }
                Console.WriteLine("¿Desea seguir?");
                bandera = bool.Parse(Console.ReadLine());
            }
            // a
            int max = cantVentas[0];
            for (int i = 0; i < 15; i++)
            {
                if(cantVentas[i] > max)
                    max = i + 1;
            }
            Console.WriteLine("El artículo " + max + " fue el de mayor ventas total.");
            // b
            Console.Write("Los artículos ");
            for (int i = 0; i < 15; i++)
            {
                if(cantVentas[i] == 0)
                {
                posicion = i + 1;
                Console.Write(posicion + ", ");
                }
            }
            Console.WriteLine("no registraron ventas.");
            // c
            Console.WriteLine("Se vendieron " + cantVentas[9] + " unidades del artículo nro 10.");

            // // correccion maxi
            // int nroArticulo;
            // int cantidad;
            // int[] totalCantidadVendida = new int[15];

            // for (int i = 0; i < 15; i++)
            // {
            //     totalCantidadVendida[i] = 0;
            // }

            // Console.WriteLine("Ingrese el nro del artículo");
            // nroArticulo = int.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese la cantidad vendida");
            // cantidad = int.Parse(Console.ReadLine());

            // while (nroArticulo != 0)
            // {
            //     totalCantidadVendida[nroArticulo - 1] += cantidad;
            
            //     Console.WriteLine("Ingrese el nro del artículo");
            //     nroArticulo = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Ingrese la cantidad vendida");
            //     cantidad = int.Parse(Console.ReadLine());
            // }

            // // punto a
            // int maxCantidad = totalCantidadVendida[0];
            // for (int i = 0; i < 15; i++)
            // {
            //     if (totalCantidadVendida[i] > maxCantidad)
            //     {
            //         maxCantidad = totalCantidadVendida[i];
            //         nroArticulo = i + 1;
            //     }
            // }
            // Console.WriteLine("El producto mas vendido es el. " + nroArticulo + "con la cantidad de: " + maxCantidad);
            
            // // punto b
            // for (int i = 0; i < 15; i++)
            // {
            //     if (totalCantidadVendida[i] == 0)
            //     {
            //         Console.WriteLine("El producto " + (i+1) + " no tuvo ventas.");
            //     }
            // }

            // // punto c
            // Console.WriteLine("La cantidad vendida del artículo 10 es: " + totalCantidadVendida[9]);
        }
    }
}
