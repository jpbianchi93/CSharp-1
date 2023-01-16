using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,resultado;
            Console.WriteLine("Ingrese un nro:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro nro:");
            n2 = int.Parse(Console.ReadLine());

            resultado = producto(n1,n2);

            Console.WriteLine("El producto es: " + resultado);
        }
        static int producto(int a,int b){
            // int r = a * b;
            return a * b;
        }
    }
}
