using System.Globalization;

namespace Casting;

internal class Program
{
    static void Main(string[] args)
    {
        int x, y;
        x = 5;
        y = 2 * x;

        int n1 = 5;
        double n2 = 2 * n1;

        Console.WriteLine("Valor de x é = " + x);
        Console.WriteLine("Valor de y é = " + y);
        Console.WriteLine("Valor de b é = " + n2 + "\n");

        double b, B, h, area;

        b = 6.0;
        B = 8.0;
        h = 5.0;

        area = (b + B) / 2.0 * h;

        Console.WriteLine($"Area = {area}");
        Console.WriteLine();
        int v1, v2;
        v1 = 5;
        v2 = 2;
        double resultado = (double) v1 / v2;

        Console.WriteLine(resultado.ToString("F1",CultureInfo.InvariantCulture));
        
        
    }
}