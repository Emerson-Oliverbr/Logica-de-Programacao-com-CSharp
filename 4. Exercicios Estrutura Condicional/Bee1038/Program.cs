using System;
using System.Globalization;

internal class Bee1038
{
	internal class Program
	{ 
		static void Main(string[] args)
		{ 
			string[] opcoes = Console.ReadLine().Split(' ');
			int codigo = int.Parse(opcoes[0]);
			int quantidade = int.Parse(opcoes[1]);

			double totalAPagar = 0.0;

			if(codigo == 1) 
			{
				totalAPagar = quantidade * 4.00;
			}
			else if(codigo == 2)
			{
				totalAPagar = quantidade * 4.50;
			}
			else if(codigo == 3)
			{
				totalAPagar = quantidade * 5.00;
			}
			else if(codigo == 4)
			{
				totalAPagar = quantidade * 2.00;
			}
			else if(codigo == 5)
			{
				totalAPagar = quantidade * 1.50;
			}
			else 
			{
				Console.WriteLine("Codigo invalido");
			}

			Console.WriteLine($"Total: R$ {totalAPagar.ToString("F2",CultureInfo.InvariantCulture)}");
		}
	}
}