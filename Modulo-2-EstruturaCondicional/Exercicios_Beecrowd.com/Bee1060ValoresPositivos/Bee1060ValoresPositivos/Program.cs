namespace Bee1060ValoresPositivos;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double v1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double v2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double v3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double v4 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double v5 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        double v6 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        int valoresPositivos = 0;
        
        if (v1 > 0.0)
        {
            valoresPositivos += 1;
        }
        if (v2 > 0.0)
        {
            valoresPositivos += 1;
        }
        if (v3 > 0.0)
        {
            valoresPositivos += 1;
        }
        if (v4 > 0.0)
        {
            valoresPositivos += 1;
        }
        if (v5 > 0.0)
        {
            valoresPositivos += 1;
        }
        if (v6 > 0.0)
        {
            valoresPositivos += 1;
        }

        Console.WriteLine($"{valoresPositivos} valores positivos");
    }
}