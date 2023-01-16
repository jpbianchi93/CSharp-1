using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, menor;

            Console.WriteLine("Ingrese 4 números distintos:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2)
                menor = n1;
            else
                menor = n2;
            
            if(n3 < menor)
                menor = n3;
            
            if(n4 < menor)
                menor = n4;

            Console.WriteLine("El valor menor es: " + menor);
        }
    }
}
