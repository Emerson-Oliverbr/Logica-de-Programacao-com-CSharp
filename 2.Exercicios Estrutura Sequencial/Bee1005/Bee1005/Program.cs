using System;
using System.Globalization;

namespace MyApp
{
    internal class Bee1005
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (A*3.5 + B*7.5) / 11.0;

            Console.WriteLine($"{media.ToString("F5",CultureInfo.InvariantCulture)}");
            Console.ReadKey();
        }
    }
}



