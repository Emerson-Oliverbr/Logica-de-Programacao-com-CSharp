namespace Bee1011Esfera;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double pi = 3.14159;

        int raio = int.Parse(Console.ReadLine());

        double volume = (4 / 3.0) * pi * Math.Pow(raio, 3.0);

        Console.WriteLine($"Volumne {volume.ToString("F3",CultureInfo.InvariantCulture)}");
    }
}