namespace Bee1035TesteDeSelecao;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string[] dados = Console.ReadLine().Split(' ');
        int codigo = int.Parse(dados[0]);
        int quantidade = int.Parse(dados[1]);

        double valorAPagar = 0.0;
        if (codigo == 1)
        {
            valorAPagar = quantidade * 4.00;
        }
        else if (codigo == 2)
        {
            valorAPagar = quantidade * 4.50;
        }
        else if (codigo == 3)
        {
            valorAPagar = quantidade * 5.00;
        }
        else if (codigo == 4)
        {
            valorAPagar = quantidade * 2.00;
        }
        else if (codigo == 5)
        {
            valorAPagar = quantidade * 1.50;
        }
        else
        {
            Console.WriteLine("Codigo não existe");
        }

        Console.WriteLine($"Total: R$ {valorAPagar.ToString("F2",CultureInfo.InvariantCulture)}");
    }
}    
    