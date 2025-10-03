namespace Bee1064PositivosEMedia;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double v3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double v4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double v5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double v6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int valoresPositivos = 0;
        double contadorPositivos = 0;
        double media = 0.0;

        if (v1 > 0)
        {
            valoresPositivos += 1;
            contadorPositivos += v1;
        }
        if (v2 > 0)
        {
            valoresPositivos += 1;
            contadorPositivos += v2;
        }
        if (v3 > 0)
        {
            valoresPositivos += 1;
            contadorPositivos += v3;
        }
        if (v4 > 0)
        {
            valoresPositivos += 1;
            contadorPositivos += v4;
        }
        if (v5 > 0)
        {
            valoresPositivos += 1;
            contadorPositivos += v5;
        }
        if (v6 > 0)
        {
            valoresPositivos += 1;
            contadorPositivos += v6;
        }

        media = (contadorPositivos) / valoresPositivos;

        Console.WriteLine($"{valoresPositivos} valores positivos");
        Console.WriteLine($"{media.ToString("F1",CultureInfo.InvariantCulture)}");
    }
}