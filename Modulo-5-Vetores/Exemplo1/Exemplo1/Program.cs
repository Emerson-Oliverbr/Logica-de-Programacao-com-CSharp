namespace Exemplo1;

class Program
{
    static void Main(string[] args)
    {
        int[] idades;
        idades = new int[10];
        idades[0] = 40;
        idades[1] = 36;
        idades[2] = 10;

        Console.WriteLine(idades[0]);
        Console.WriteLine(idades[1]);
        Console.WriteLine(idades[2]);
        Console.WriteLine("-----------");
        
        for (int i = 0; i <= 10; i++)
        {
            idades[i] = i + 10;
            Console.WriteLine(idades[i]);
        }
    }
}