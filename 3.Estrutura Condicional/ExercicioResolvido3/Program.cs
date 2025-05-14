using System;

namespace ExercicioResolvido3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] valores = Console.ReadLine().Split(' ');
			int valor1 = int.Parse(valores[0]);
			int valor2 = int.Parse(valores[1]);
			int valor3 = int.Parse(valores[2]);

			int menor;

			if(valor1 < valor2 && valor1 < valor3) {
				menor = valor1;
			}
			else if (valor2 < valor1 && valor2 < valor3) {
				menor = valor2;
			}
			else {
				menor = valor3;
			}

			Console.WriteLine($"MENOR = {menor}");
		}
	}
	
}
