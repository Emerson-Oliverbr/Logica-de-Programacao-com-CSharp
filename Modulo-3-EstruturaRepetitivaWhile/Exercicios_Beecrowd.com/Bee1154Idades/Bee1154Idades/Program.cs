namespace Bee1154Idades;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double idades = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        double idadeMedia = 0.0;
        double somaIdades = 0.0;
        int contadorDeIdades = 0;
        
        while (idades >= 0.0)
        {
            contadorDeIdades += 1;
            somaIdades += idades;
            idades = double.Parse(Console.ReadLine());
        }

        idadeMedia = somaIdades / contadorDeIdades;

        Console.WriteLine($"{idadeMedia.ToString("F2",CultureInfo.InvariantCulture)}");
    }
}