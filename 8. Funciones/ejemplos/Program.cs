using System;

namespace ejemplos
{
    class Program
    {
            // static void Main(string[] args)
            // //Programa/Función principal
            // {
            //     //acá va el código...
            //     //PARTES DE LA FUNCIÓN:

            //     //CABECERA - static void Main(string[] args)
            //     //1. TIPO DE DATO - void
            //     //2. NOMBRE - Main
            //     //3. PARÁMETROS (Opcional) - (string[] args)

            //     //CUERPO - {}
            //     //1. DEFINICIÓN/LÓGICA
            //     //2. NOMBRE DE VALOR/RESULTADO (Opcional)
            
            //     // int n = devolverUno();
            //     Console.WriteLine("Fin del programa " + devolverUno());
            // }

            // static int devolverUno()
            // // Función secundaria/Mini-programa
            // {
            //     int nro = 15;
            //     return nro;
            // }
             
        // PARÁMETRO POR VALOR Y POR REFERENCIA
        
        // VALOR: copia en memoria de la variable, NO se modifica el valor original.
        // sumar(int a, int b)
        
        // REFERENCIA:(ref) dirección en memoria de la variable, SI se modifica el valor original. 
        // sumar(ref int a, int b)
        
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);
            //lógica
            //resultado = n1 + n2;
            resultado = sumar(n1, n2);
            //fin lógica

            Console.WriteLine("El resultado es: " + resultado);
            //SCOPE
        }

        static int sumar(int a, int b)
        {
            int r;
            r = a + b;
            return r;
        }

        static void pedirDatos(ref int j, ref int h){
            // void: pide datos pero no hace nada
            Console.WriteLine("Ingrese un nro:");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro:");
            h = int.Parse(Console.ReadLine());
        }
    } 
}
