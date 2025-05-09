using System;
using System.Globalization;

namespace Bee1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoDoFuncionario = int.Parse(Console.ReadLine());
            int QuantidadeDeHorasTrabalhadas = int.Parse(Console.ReadLine());
            double salarioPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioBruto = QuantidadeDeHorasTrabalhadas * salarioPorHora;

            Console.WriteLine($"NUMBER = {codigoDoFuncionario}");
            Console.WriteLine($"SALARY = U$ {salarioBruto.ToString("F2",CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}



