using System;
using System.Globalization;

namespace Bee1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);            

            double kml = (double) X / Y;

            Console.WriteLine($"{kml.ToString("F3",CultureInfo.InvariantCulture)} km/l");


            Console.ReadKey();
        }
    }
}



