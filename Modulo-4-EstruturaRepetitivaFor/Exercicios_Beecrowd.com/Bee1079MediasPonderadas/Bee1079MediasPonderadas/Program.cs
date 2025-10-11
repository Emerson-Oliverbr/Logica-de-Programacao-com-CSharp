namespace Bee1079MediasPonderadas;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double media = 0.0;
        
        for (int i=0; i<n; i++)
        {
            string[] notas = Console.ReadLine().Split(' ');
            double notas1 = double.Parse(notas[0],CultureInfo.InvariantCulture);
            double notas2 = double.Parse(notas[1],CultureInfo.InvariantCulture);
            double notas3 = double.Parse(notas[2],CultureInfo.InvariantCulture);
            
            media = (notas1 * 2 + notas2 * 3 + notas3 * 5) / 10.0;

            Console.WriteLine($"{media.ToString("F1",CultureInfo.InvariantCulture)}");
        }
    }
}