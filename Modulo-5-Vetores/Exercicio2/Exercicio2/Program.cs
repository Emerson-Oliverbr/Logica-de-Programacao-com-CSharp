namespace Exercicio2;
using System.Globalization; 

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double[] numeros = new double[n];

        string[] valores = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            numeros[i] = double.Parse(valores[i],CultureInfo.InvariantCulture);
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            Console.Write(numeros[i].ToString("F1",CultureInfo.InvariantCulture) + " ");
        }

        int quantidade = 0;
        double totalValores = 0.0;
        double media = 0.0;
        
        for (int i = 0; i < n; i++)
        {
            numeros[i] = double.Parse(valores[i],CultureInfo.InvariantCulture);
            quantidade += 1;
            totalValores += numeros[i];
            media = (double) totalValores / quantidade;
        }
        Console.WriteLine();
        Console.WriteLine(totalValores.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
    }
}