namespace EntradaDeDados;

internal class Program
{
    static void Main(string[] args)
    {
        string frase = Console.ReadLine();
        Console.WriteLine("Voce digitou: " + frase);

        string cor1 = Console.ReadLine();
        string cor2 = Console.ReadLine();
        string cor3 = Console.ReadLine();

        Console.WriteLine("Cores digitadas: ");
        Console.WriteLine(cor1);
        Console.WriteLine(cor2);
        Console.WriteLine(cor3);

        string frutas = Console.ReadLine();

        string[] minhasFrutas = frutas.Split(' ');
        string fruta1 = minhasFrutas[0];
        string fruta2 = minhasFrutas[1];
        string fruta3 = minhasFrutas[2];

        Console.WriteLine(fruta1);
        Console.WriteLine(fruta2);
        Console.WriteLine(fruta3);
    }
}

