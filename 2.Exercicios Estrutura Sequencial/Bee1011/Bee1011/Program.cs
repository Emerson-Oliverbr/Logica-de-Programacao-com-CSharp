﻿using System;
using System.Globalization;

namespace Bee1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

            Console.WriteLine($"VOLUME = {volume.ToString("F3",CultureInfo.InvariantCulture)}");
            
            Console.ReadKey();
        }
    }
}



