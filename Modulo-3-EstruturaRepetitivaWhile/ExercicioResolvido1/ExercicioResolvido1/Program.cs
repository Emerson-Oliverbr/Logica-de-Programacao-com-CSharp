namespace ExercicioResolvido1;

class Program
{
    static void Main(string[] args)
    {
        string[] numeros = Console.ReadLine().Split(' ');
        int v1 = int.Parse(numeros[0]);
        int v2 = int.Parse(numeros[1]);

        while (v1 != v2)
        {
            if (v1 > v2)
            {
                Console.WriteLine("Decrescente");
            }
            else
            {
                Console.WriteLine("Crescente ");
            }
            numeros = Console.ReadLine().Split(' ');
            v1 = int.Parse(numeros[0]);
            v2 = int.Parse(numeros[1]);
        }
    }
}