using System;
using System.Globalization;

namespace ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quantidadeDeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de algum produto: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu ultimo nome, idade e altura (na mesma linha): ");

            string[] dados = Console.ReadLine().Split(' ');
            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2],CultureInfo.InvariantCulture);
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quantidadeDeQuartos);
            Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}



