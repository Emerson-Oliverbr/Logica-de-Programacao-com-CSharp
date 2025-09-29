namespace Exemplo1;

class Program
{
    static void Main(string[] args)
    {
        int horas = 5;

        Console.WriteLine("Que horas são agora? ");
        horas = int.Parse(Console.ReadLine());

        if (horas < 12)
        {
            Console.WriteLine("Bom dia");
        }
        else if(horas > 18)
        {
            Console.WriteLine("Boa noite");
        }
        else
        {
            Console.WriteLine("Boa tarde");
        }
    }
}