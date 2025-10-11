namespace Bee1075Resto2;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 100; i++)
        {
            if (i % n == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}