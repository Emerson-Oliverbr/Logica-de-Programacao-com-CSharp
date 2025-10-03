namespace BeeParesEntreCincoNumeros;

class Program
{
    static void Main(String[] args)
    {
        int v1 = int.Parse(Console.ReadLine());
        int v2 = int.Parse(Console.ReadLine());
        int v3 = int.Parse(Console.ReadLine());
        int v4 = int.Parse(Console.ReadLine());
        int v5 = int.Parse(Console.ReadLine());

        int valoresPares = 0;
        if (v1 % 2 == 0)
        {
            valoresPares += 1;
        }
        if (v2 % 2 == 0)
        {
            valoresPares += 1;
        }
        if (v3 % 2 == 0)
        {
            valoresPares += 1;
        }
        if (v4 % 2 == 0)
        {
            valoresPares += 1;
        }
        if (v5 % 2 == 0)
        {
            valoresPares += 1;
        }

        Console.WriteLine($"{valoresPares} valores pares");
    }
}