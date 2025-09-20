namespace Bee1009SalarioComBonus;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome do vendedor: ");
        string nome = Console.ReadLine();
        Console.Write("Digite o salário fixo do vendedor: ");
        double salarioFixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Digite o total de vendas efetuadas no mês (em dinheiro): ");
        double totalDeVendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        double comissao = totalDeVendas * 0.15;
        double salarioBruto = salarioFixo + comissao;

        Console.WriteLine($"Total = R$ {salarioBruto.ToString("F2",CultureInfo.InvariantCulture)}");
    }
}