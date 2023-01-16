using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, state = 0;
            Console.WriteLine("Ingrese un nro:");
            numero = int.Parse(Console.ReadLine());
            
            positivoNegativoCero(numero, ref state);
            
            Console.WriteLine("El estado del valor " + numero + " es: " + state);
        }
        static void positivoNegativoCero(int valor,ref int estado){
            if(valor > 0)
            estado = 1;
            else if(valor < 0)
            estado = -1;
            else
            estado = 0;
        }
    }
}
