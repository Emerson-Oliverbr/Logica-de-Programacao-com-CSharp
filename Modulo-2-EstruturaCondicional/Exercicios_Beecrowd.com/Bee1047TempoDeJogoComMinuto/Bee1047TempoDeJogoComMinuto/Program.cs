namespace Bee1047TempoDeJogoComMinutos;

class Program
{
    static void Main(string[] args)
    {
        string[] entrada = Console.ReadLine().Split(' ');
        int horaInicio = int.Parse(entrada[0]);
        int minutoInicio = int.Parse(entrada[1]);
        int horaFim = int.Parse(entrada[2]);
        int minutoFim = int.Parse(entrada[3]);

        int inicioTotalMinutos = horaInicio * 60 + minutoInicio;
        int fimTotalMinutos = horaFim * 60 + minutoFim;

        int duracaoMinutos;

        if (fimTotalMinutos > inicioTotalMinutos)
        {
            duracaoMinutos = fimTotalMinutos - inicioTotalMinutos;
        }
        else
        {
            duracaoMinutos = (24 * 60 - inicioTotalMinutos) + fimTotalMinutos;
        }

        int horas = duracaoMinutos / 60;
        int minutos = duracaoMinutos % 60;

        Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
    }
}