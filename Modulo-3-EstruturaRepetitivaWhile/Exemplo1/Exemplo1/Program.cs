namespace Exemplo1;

class Program
{
    static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine());

        int contador = 0;
        while (x != 0)
        {
            contador += x;
            x = int.Parse(Console.ReadLine());
            
        }
        Console.WriteLine($"{contador}");
    }
}