using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, suma, producto;

            Console.WriteLine("Ingrese 3 números enteros de manera aleatoria:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            suma = a + b;
            producto = b * c;
            
            if(suma > producto)
                Console.WriteLine("La suma de " + a + " y de " + b + ", es mayor al producto de " + b + " y " + c);
            else
                Console.WriteLine("La suma de " + a + " y de " + b + ", no es mayor al producto de " + b + " y " + c); 
        }
    }
}
