namespace Exercicio1;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] valores = new int[n];

        string[] s = Console.ReadLine().Split(' ');
        
        for (int i=0; i<n; i++)
        {
            valores[i] = int.Parse(s[i]);
        }
        
        for (int i=0; i<n; i++)
        {
            if (valores[i] < 0)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}