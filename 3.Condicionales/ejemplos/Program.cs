using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //BLOQUE IF: Condicionales.
            //Operadores Relacionales: > < >= <= == !=
            //Valor OR Valor

            //int edad = 21;

            //IF anidado
            // if(edad > 20)
            //     if(edad > 30)
            //         Console.WriteLine("30 OFF");
            //     else
            //          Console.WriteLine("21 OFF");
            //     
            // else
            //     Console.WriteLine("10 OFF");
            
            //else if
            // if(edad > 30)
            //     Console.WriteLine("30 OFF");
            // else if(edad > 20)
            //     Console.WriteLine("21 OFF");
            // else if(edad == 18)
            //     Console.WriteLine("10 OFF");
            // else
            //     Console.WriteLine("5 OFF");
            
            //Acumuladores y Contadores:
            int contador = 0, e1 = 20, e2 = 30, e3 = 15;
            int acumulador = 0;
            int promedio;
            //contador = contador +1;
            //operador de incremento:
            //++
            //--
            //operador de acumulacion:
            //+=
            //-=
            
            if(e1 > 18)
                contador ++;
                acumulador += e1;
            
            if(e2 > 18)
                contador = contador + 1;
                acumulador = acumulador + e2;
            
            if(e3 > 18)
                contador = contador + 1;
                acumulador += e3;

            promedio = acumulador / contador;
            Console.WriteLine("El promedio es: " + promedio);

        }
    }
}
