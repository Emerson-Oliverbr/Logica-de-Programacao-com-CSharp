using System;
using System.Globalization;

namespace ExercicioResolvido1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double delta, R1, R2;

			string[] valores = Console.ReadLine().Split(' ');
			double A = double.Parse(valores[0],CultureInfo.InvariantCulture);
			double B = double.Parse(valores[1],CultureInfo.InvariantCulture);
			double C = double.Parse(valores[2],CultureInfo.InvariantCulture);

			delta = Math.Pow(B, 2.0) - 4 * A * C;

			if(A == 0 || delta < 0.0)
			{
				Console.WriteLine("Impossivel calcular");			
			}
			else 
			{
				R1 = (-B + Math.Sqrt(delta)) / (2.0 * A);	
				R2 = (-B - Math.Sqrt(delta)) / (2.0 * A);
				Console.WriteLine($"R1 = {R1.ToString("F5",CultureInfo.InvariantCulture)}");	
				Console.WriteLine($"R2 = {R2.ToString("F5",CultureInfo.InvariantCulture)}");
			}
		}
	}
}