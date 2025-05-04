using System;
using System.Globalization;

namespace ProcessamentoDadosECasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;

            valor1 = 5;
            valor2 = 2 * valor1;

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine();

            int valor3;
            double valor4;

            valor3 = 5;
            valor4 = 2 * valor3;

            Console.WriteLine(valor3);
            Console.WriteLine(valor4);
            Console.WriteLine();

            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;

            Console.WriteLine(area + "\n");

            int valor5, valor6;
            double resultado;

            valor5 = 5;
            valor6 = 2;

            resultado = (double) valor5 / valor6;

            Console.WriteLine(resultado);
            Console.WriteLine(resultado.ToString("F1",CultureInfo.InvariantCulture));


            Console.ReadKey();
        }
    }
}



