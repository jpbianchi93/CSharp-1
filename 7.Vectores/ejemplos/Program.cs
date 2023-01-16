using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vectores. Array. Arreglo.
            // int n;
            // int[] numeros = new int [10];
            //  0 1 2 3 4 5 6 7 8 9
            // |7| | | | | |1| | |32450| 
            
            // numeros[6] = 1;
            // numeros[0] = 7;
            // numeros[9] = 32450;
            // n = numeros[6] + numeros[0] + numeros[9];
            // Console.WriteLine(numeros[0]);

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("Ingrese la nota:");
            //     n = int.Parse(Console.ReadLine());
            //     numeros[i] = n;
            // }
            // int acu = 0;
            // for (int i = 0; i < 10; i++)
            // {
            //     acu += numeros[i];
            // }
            // int prom = acu / 10;

            // int(long, short) - float - double - decimal
            // double[] muestraMatutina = new double[31];
            // double[] muestraVespertina = new double[31];
            // double[] muestranocturna = new double[31];
            // // cruce
            // // muestra matutina
            // int dia;
            // double temperatura;
            // Console.WriteLine("Cargue el registro matutino");
            // for (int i = 0; i < 31; i++)
            // {
            //     Console.WriteLine("Ingrese el día:");
            //     dia = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Ingrese temperatura registrada:");
            //     temperatura = double.Parse(Console.ReadLine());
            //     muestraMatutina[dia-1] = temperatura;
            // }
            // // muestra vespertina
            // Console.WriteLine("Cargue el registro vespertino");
            // for (int i = 0; i < 31; i++)
            // {
            //     Console.WriteLine("Ingrese el día:");
            //     dia = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Ingrese temperatura registrada:");
            //     temperatura = double.Parse(Console.ReadLine());
            //     muestraVespertina[dia-1] = temperatura;
            // }
            // // muestra nocturna
            // Console.WriteLine("Cargue el registro nocturno");
            // for (int i = 0; i < 31; i++)
            // {
            //     Console.WriteLine("Ingrese el día:");
            //     dia = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Ingrese temperatura registrada:");
            //     temperatura = double.Parse(Console.ReadLine());
            //     muestranocturna[dia-1] = temperatura;
            // }
            // //leer vectores
            // double acu = 0;
            // for (int i = 0; i < 31; i++)
            // {
            //     acu += muestraMatutina[i];
            // }

            // // vectores bool
            // int[] legajos = new int[100];
            // bool [] asistencia = new bool[100]; 
            // for (int i = 0; i < 16; i++)
            // {
            //     for (int x = 0; x < 100; x++)
            //     {
            //     legajos[x] = 12;
            //     asistencia[x] = true;
            //     }
            // }

            // Cadena de caracteres
            // char[] cadena = new char[10];
            //BARRA CERO
            //\0 - fin de cadena de caracteres

            //VECTOR DE CHAR
            //|P|A|A|P|A| | | |P|
            //CADENA DE CARACTERES
            //|H|O|L|A| |Q|U|E| |T|A|L|?|\0| | | | |

            //Cadena de caracteres a bajo nivel
            // char[] nombre = new char[11];
            // char letra;
            // int indice = 0;
            // Console.WriteLine("Ingrese su nombre letra por letra, termina con punto: ");
            // letra = char.Parse(Console.ReadLine());   
            // while(letra != '.' && indice < 10)
            // {
            //     nombre[indice] = letra;
            //     letra = char.Parse(Console.ReadLine());
            //     indice++;
            // }
            // Validacion de caracteres
            // if(indice == 10)
            //     indice--;
            // nombre[indice] = '\0';
            //|j|u|a|n| |p|\0| | | | | 
            // Console.Write("Hola ");
            // indice= 0;
            // while (nombre[indice] != '\0')
            // {
            //     Console.Write(nombre[indice]);
            //     indice++;
            // }

            //STRING (cadena de caracteres) a alto nivel
            string nombre;
            Console.WriteLine("Ingrese su nombre...");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + "!");
        }
    }
}
