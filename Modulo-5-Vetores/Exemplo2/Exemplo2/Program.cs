namespace Exemplo2;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double[] valores = new double[4];

        valores[0] = 10.5;
        valores[1] = 4.2;
        valores[2] = -7.1;
        valores[3] = 15.0;

        Console.WriteLine(valores[0].ToString("F1",CultureInfo.InvariantCulture));
        Console.WriteLine(valores[1].ToString("F1",CultureInfo.InvariantCulture));
        Console.WriteLine(valores[2].ToString("F1",CultureInfo.InvariantCulture));
        Console.WriteLine(valores[3].ToString("F1",CultureInfo.InvariantCulture));
        Console.WriteLine();
        
        int n;
        n = int.Parse(Console.ReadLine());

        double[] vet = new double[n];
        
        for (int i = 0; i < n; i++)
        {
            vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(vet[i].ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}