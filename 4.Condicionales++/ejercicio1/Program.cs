using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultado;
           
            Console.WriteLine("Ingrese dos números:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
          
            if(a == b){
                resultado = a + b;
                Console.WriteLine("El resultado de la suma es: " + resultado);
            }
            else if (a > b){
                resultado = a - b;
                Console.WriteLine("El resultado de la resta es: " + resultado);
            }
            else{
                resultado = a * b;
                Console.WriteLine("El resultado del producto es: " + resultado);    
            }        
        }
    }
}
