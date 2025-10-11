namespace Bee1080MaiorEPosicao;

class Program
{
    static void Main(string[] args)
    {
        int x, maior = 0, posicao = 0;;
        for (int i = 1; i <= 10; i++)
        {
            x = int.Parse(Console.ReadLine());

            if (x > maior)
            {
                maior = x;
                posicao = i;
            }
        }

        Console.WriteLine($"Maior: {maior}");
        Console.WriteLine($"Posição: {posicao}");
    }
}