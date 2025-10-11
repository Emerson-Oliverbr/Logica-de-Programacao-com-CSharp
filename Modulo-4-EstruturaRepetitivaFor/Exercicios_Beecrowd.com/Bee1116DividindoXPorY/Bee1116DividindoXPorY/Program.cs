namespace Bee1116DividindoXPorY;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {   
            string[] numeros = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(numeros[0]);
            int valor2 = int.Parse(numeros[1]);

            if (valor2 == 0)
            {
                Console.WriteLine("Divisão imposivel");
            }
            else
            {
                double resultado = (double) valor1 / valor2;
                Console.WriteLine($"{resultado.ToString("F1",CultureInfo.InvariantCulture)}");
            }
        }
    }
}