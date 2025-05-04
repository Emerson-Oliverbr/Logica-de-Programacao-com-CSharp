using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola, Mundo! \n");         

            double x = 10.35784;
            int idade = 32;
            string nome = "Emerson";
            char genero = 'M';

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2",CultureInfo.InvariantCulture),"\n");
            Console.WriteLine($"Resultado {x}");
            Console.WriteLine($"O valor do troco é: R${x} reais");
            Console.WriteLine($"O valor do troco é: R${x.ToString("F2",CultureInfo.InvariantCulture)} reais \n");
            Console.WriteLine($"O nome do paciente é {nome} tem {idade} anos e seu sexo é {genero}");

            Console.ReadKey();
        }
    }
}



