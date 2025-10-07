namespace ExercicioResolvido2;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int idade = int.Parse(Console.ReadLine());
        
        double idadeMedia = 0.0;
        int somaIdades = 0;
        int contadorIdades = 0;

        if (idade < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }

        else
        {
            while (idade >= 0)
            {
                somaIdades += idade;
                contadorIdades += 1;
                idade = int.Parse(Console.ReadLine());
            }

            idadeMedia = (double) somaIdades / contadorIdades;
        
            Console.WriteLine($"{idadeMedia.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}