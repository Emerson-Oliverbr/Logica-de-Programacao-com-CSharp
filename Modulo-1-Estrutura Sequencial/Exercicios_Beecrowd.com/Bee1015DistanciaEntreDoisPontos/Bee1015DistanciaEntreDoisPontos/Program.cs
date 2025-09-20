namespace Bee1015DistanciaEntreDoisPontos;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string[] linha1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(linha1[0], CultureInfo.InvariantCulture);
        double y1 = double.Parse(linha1[1], CultureInfo.InvariantCulture);

        string[] linha2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(linha2[0], CultureInfo.InvariantCulture);
        double y2 = double.Parse(linha2[1], CultureInfo.InvariantCulture);
        
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine(distancia.ToString("F4",CultureInfo.InvariantCulture));
    }
}