using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, con = 0;

            Console.WriteLine("Ingrese 4 números distintos:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            if (n1 > 100){
                Console.WriteLine("El primer valor: " + n1 + ", es mayor a 100.");
                con++;
            }
            if (n2 > 100){
                Console.WriteLine("El segundo valor: " + n2 + ", es mayor a 100.");
                con++;
            }
            if (n3 > 100){
                Console.WriteLine("El tercer valor: " + n3 + ", es mayor a 100.");
                con++;
            }
            if (n4 > 100){
                Console.WriteLine("El cuarto valor: " + n4 + ", es mayor a 100.");
                con++;
            }
            if (con != 0)
                Console.WriteLine("Hay " + con + " números mayores a 100.");
            else
                Console.WriteLine("No hay números mayores a 100.");
        }
    }
}
