using System.Globalization;
namespace ExercicioIdadeMedia;

class Program
{
    static void Main(string[] args)
    {
        string[] dadosPessoas = Console.ReadLine().Split(' ');
        string nomePessoa1 = dadosPessoas[0];
        int idadePessoa1 = int.Parse(dadosPessoas[1]);
        
        dadosPessoas = Console.ReadLine().Split(' ');
        string nomePessoa2 = dadosPessoas[0];
        int idadePessoa2 = int.Parse(dadosPessoas[1]);

        double idadeMedia = (idadePessoa1 + idadePessoa2) / 2.0;

        Console.WriteLine($"A idade média de {nomePessoa1} e {nomePessoa2} é {idadeMedia.ToString("F1",CultureInfo.InvariantCulture)} anos");
    }
}