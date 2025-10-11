namespace Bee1074ParOuImpar;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int index = 2; index <= n; index += 1)
        {
            int quadrado = 0;
            if (index % 2 == 0)
            {
                quadrado = (int) Math.Pow(index, 2);
                Console.WriteLine($"{index}^2 {quadrado}");
            }
        }
    }
}