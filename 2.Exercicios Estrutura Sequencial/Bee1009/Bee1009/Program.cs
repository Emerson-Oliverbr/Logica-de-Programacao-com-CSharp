using System;
using System.Globalization;

namespace Bee1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeDoVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioBruto = salarioFixo + (totalDeVendas * 0.15);

            Console.WriteLine($"TOTAL = R$ {salarioBruto.ToString("F2",CultureInfo.InvariantCulture)}");


            Console.ReadKey();
        }
    }
}



