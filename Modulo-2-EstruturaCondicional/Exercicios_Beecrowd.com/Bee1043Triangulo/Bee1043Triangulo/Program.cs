namespace Bee1043Triangulo;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double perimetro, area;
        
        string[] valores = Console.ReadLine().Split(' ');
        double v1 = double.Parse(valores[0],CultureInfo.InvariantCulture);
        double v2 = double.Parse(valores[1],CultureInfo.InvariantCulture);
        double v3 = double.Parse(valores[2],CultureInfo.InvariantCulture);
        
        if (v1 < v2 + v3 && v2 < v1 + v3 && v3 < v1 + v2) {
            perimetro = v1 + v2 + v3;
            Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
        }
        else {
            area = ((v1 + v2) * v3) / 2.0;
            Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}