namespace Bee1134TipoDeCombustivel;

class Program
{
    static void Main(string[] args)
    {
        int numero = int.Parse(Console.ReadLine());

        int alcool = 0, gasolina = 0, diesel = 0;
        while (numero != 4)
        {
            if (numero == 1)
            {
                alcool += 1;
            }
            if (numero == 2)
            {
                gasolina += 1;
            }
            if (numero == 3)
            {
                diesel += 1;
            }
            
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine($"Alcool: {alcool}");
        Console.WriteLine($"Gasolina: {gasolina}");
        Console.WriteLine($"Diesel: {diesel}");
    }
}