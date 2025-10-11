namespace Bee1094Experiencias;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int sapos=0, ratos=0, coelhos=0, totalCobaias=0;
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <n; i++)
        {
            string[] cobaias = Console.ReadLine().Split(' ');
            int quantidadeCobaia = int.Parse(cobaias[0]);
            char tipoCobaia = char.Parse(cobaias[1]);

            if (tipoCobaia == 'c' || tipoCobaia == 'C')
            {
                coelhos += quantidadeCobaia;
            }
            else if (tipoCobaia == 's' || tipoCobaia == 'S')
            {
                
                sapos += quantidadeCobaia;
            }
            else
            {
                ratos += quantidadeCobaia;
            }

            if (tipoCobaia == 's' || tipoCobaia == 'S' || tipoCobaia == 'r' || tipoCobaia == 'R' || tipoCobaia == 'c' ||
                tipoCobaia == 'C')
            {
                totalCobaias += quantidadeCobaia;
            }
        }

        double percentualCoelhos = (double) coelhos /  totalCobaias * 100.0;
        double percentualSapos = (double) sapos /  totalCobaias * 100.0;
        double percentualRatos = (double) ratos /  totalCobaias * 100.0;
        
        Console.WriteLine($"Total: {totalCobaias} cobaias");
        Console.WriteLine($"Total de coelhos: {coelhos}");
        Console.WriteLine($"Total de ratos: {ratos}");
        Console.WriteLine($"Total de sapos: {sapos}");
        Console.WriteLine($"Percentual de coelhos: {coelhos.ToString("F2",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Percentual de ratos: {ratos.ToString("F2",CultureInfo.InvariantCulture)}"); 
        Console.WriteLine($"Percentual de sapos: {sapos.ToString("F2",CultureInfo.InvariantCulture)}");       
    }
}