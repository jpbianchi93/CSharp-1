using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // char[] frase = new char[30];
            // char letra, letraActual, letraNueva;
            // int indice = 0;

            // Console.WriteLine("Ingrese una letra para la frase:");
            // letra = char.Parse(Console.ReadLine());
            // while (letra != '0' && indice < 30)
            // {
            //     frase[indice] = letra;
            //     Console.WriteLine("Ingrese otra letra para la frase:");
            //     letra = char.Parse(Console.ReadLine());
            //     indice++;
            // }
            // frase[indice] = '\0'; //final de una cadena
            // Console.Write("La frase es: ");
            // Console.WriteLine(frase);

            // Console.WriteLine("Caracter que desea reemplazar:");
            // letraActual = char.Parse(Console.ReadLine());
            // Console.WriteLine("Caracter de reemplazo: ");
            // letraNueva = char.Parse(Console.ReadLine());
            // indice = 0;
            // while(frase[indice] !='\0')
            // {
            //     if (frase[indice] == letraActual)
            //         frase[indice] = letraNueva;
            //     indice++;
            // }
            // Console.Write("La frase modificada es: ");
            // Console.WriteLine(frase);

            string frase;
            char letraActual, letraNueva;

            Console.WriteLine("Ingrese la frase:");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a reemplazar:");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese letra nueva:");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual,letraNueva);

            Console.WriteLine("la cadena nueva es: ");
            Console.WriteLine(frase);
        }
    }
}
