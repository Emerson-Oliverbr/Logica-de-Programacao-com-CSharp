using System.Globalization;

namespace EntradaDeDadosParte2;

internal class Program
{
    static void Main(string[] args)
    {
        string[] minhaFamilia = Console.ReadLine().Split(' ');
        string pai = minhaFamilia[0];
        string mae = minhaFamilia[1];
        string filha = minhaFamilia[2];

        Console.WriteLine("Familia Completa: ");
        Console.WriteLine(pai);
        Console.WriteLine(mae);
        Console.WriteLine(filha); 

        int idade = int.Parse(Console.ReadLine());
        char sexo = char.Parse(Console.ReadLine());
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Sua idade é: {idade}");
        Console.WriteLine($"Seu sexo é: {sexo}");
        Console.WriteLine($"Sua altura é: {altura.ToString("F2",CultureInfo.InvariantCulture)}");

        string[] dadosCadastrais = Console.ReadLine().Split(' ');
        string nome = dadosCadastrais[0];
        int anoNascimento = int.Parse(dadosCadastrais[1]);
        double peso = double.Parse(dadosCadastrais[2],CultureInfo.InvariantCulture);

        Console.WriteLine("Dados atualizados com sucesso: ");
        Console.WriteLine(nome);
        Console.WriteLine(anoNascimento);
        Console.WriteLine(peso.ToString("F2",CultureInfo.InvariantCulture));
    }
}