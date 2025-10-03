namespace Bee1050DDD;

class Program
{
    static void Main(string[] args)
    {
        int valor = int.Parse(Console.ReadLine());

        string cidade = null;
        
        switch (valor)
        {
            case 61:
                cidade = "Brasilia";
                break;
            case 71:
                cidade = "Salvador";
                break;
            case 11:
                cidade = "São Paulo";
                break;
            case 21:
                cidade = "Rio de Janeiro";
                break;
            case 32:
                cidade = "Juiz de Fora";
                break;
            case 19:
                cidade = "Campinas";
                break;
            case 27:
                cidade = "Vitoria";
                break;
            case 31:
                cidade = "Belo Horizonte";
                break;
            default:
                cidade = "DDD Inválido";
                break;
        }

        Console.WriteLine(cidade);
    }
}