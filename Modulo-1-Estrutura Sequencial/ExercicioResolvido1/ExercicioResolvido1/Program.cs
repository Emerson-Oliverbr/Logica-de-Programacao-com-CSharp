using System.Globalization;
using System.Net;

namespace ExercicioResolvido1;

internal class Program
{
    static void Main(string[] args)
    {
        double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double comprimento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double precoMetroQuadrado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        
        double area = largura * comprimento;
        double preco = area * precoMetroQuadrado;

        Console.WriteLine($"Area = {area.ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Preco = {preco.ToString("F2",CultureInfo.InvariantCulture)}");
    }
}