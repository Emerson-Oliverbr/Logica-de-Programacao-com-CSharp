using System;
using System.Globalization;

namespace Bee1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(' ');

            int codigoPeca1 = int.Parse(dados[0]);
            int quantidadeDePecas1 = int.Parse(dados[1]);
            double valorUnitarioPeca1 = double.Parse(dados[2],CultureInfo.InvariantCulture);

            dados = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(dados[0]);
            int quantidadeDePecas2 = int.Parse(dados[1]);
            double valorUnitarioPeca2 = double.Parse(dados[2],CultureInfo.InvariantCulture);

            double totalAPagar = valorUnitarioPeca1 * quantidadeDePecas1 + valorUnitarioPeca2 * quantidadeDePecas2;

            Console.WriteLine($"VALOR A PAGAR: R$ {totalAPagar.ToString("F2",CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}



