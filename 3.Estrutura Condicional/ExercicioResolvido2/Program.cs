using System;
using System.Globalization;

namespace ExercicioResolvido2
{
	internal class Program
	{ 
		static void Main(string[] args)
		{
			  double nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
			  double nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

			  double media = nota1 + nota2;

			  if(media > 60.0) {
			  		Console.WriteLine($"NOTA FINAL = {media.ToString("F1",CultureInfo.InvariantCulture)}");		
			  }
			  else{
			  		Console.WriteLine($"NOTA FINAL {media.ToString("F1",CultureInfo.InvariantCulture)}");
			  		Console.WriteLine($"REPROVADO");
			  }
		}
	}
}