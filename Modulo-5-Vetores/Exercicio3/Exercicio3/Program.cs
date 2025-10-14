namespace Exercicio3;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        string[] nomes = new string[n];
        int[] idades = new int[n];
        double[] alturas = new double[n];

        for (int i = 0; i < n; i++)
        {
            string[] dadosPessoais = Console.ReadLine().Split(' ');
            nomes[i] = dadosPessoais[0];
            idades[i] = int.Parse(dadosPessoais[1]);
            alturas[i] = double.Parse(dadosPessoais[2],CultureInfo.InvariantCulture);
        }

        double soma = 0.0;
        for (int i = 0; i < n; i++)
        {
            soma += alturas[i];
        }
        double media = soma / n;
        Console.WriteLine($"Altura media: {media.ToString("F2",CultureInfo.InvariantCulture)}");

        int quantidadeDePessoas = 0;
        for (int i = 0; i < n; i++)
        {
            if (idades[i] < 16)
            {
                quantidadeDePessoas++;
            }
        }
        double porcentagem = (double) quantidadeDePessoas / n * 100.0;
        Console.WriteLine($"Pessoas com menos de 16 anos: {porcentagem.ToString("F1",CultureInfo.InvariantCulture)} %");
    }
}
