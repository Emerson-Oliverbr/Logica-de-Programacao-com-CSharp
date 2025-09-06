using System.Globalization;

namespace SaidaDados;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ola, Mundo!");
        Console.WriteLine("Bom dia!");

        double x = 10.35784;
        string nome = "Emerson";
        char sexo = 'M';
        
        Console.WriteLine(x);
        Console.WriteLine(x.ToString("F2"));
        Console.WriteLine(x.ToString("F2"));
        Console.WriteLine(x.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine(x.ToString("F4",CultureInfo.InvariantCulture) + "\n");
        
        Console.WriteLine($"Resultado {x}");
        Console.WriteLine($"O valor do troco é R${x.ToString("F2",CultureInfo.InvariantCulture)} reais");
        Console.WriteLine($"Nome: {nome} é do sexo {sexo}");
    }
}

