using System.Globalization;

namespace Bee1040Media3;

class Program
{
    static void Main(string[] args)
    {
        float n1, n2, n3, n4, media, notaExame,  mediaExame;
        
        string[] notas = Console.ReadLine().Split(' ');
        n1 = float.Parse(notas[0],CultureInfo.InvariantCulture);
        n2 = float.Parse(notas[1],CultureInfo.InvariantCulture);
        n3 = float.Parse(notas[2],CultureInfo.InvariantCulture);
        n4 = float.Parse(notas[3],CultureInfo.InvariantCulture);

        media = (n1 * 2f + n2 * 3f + n3 * 4f + n4 * 1f) / 10f;
        
        if (media >= 5f && media <= 6.9f)
        {
            Console.WriteLine("Aluno em exame.");
            Console.Write($"Nota exame: ");
            notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            mediaExame = (notaExame + media) / 2f;
           
            if (mediaExame >= 5f)
            {
                Console.WriteLine("Aluno aprovado");
                Console.WriteLine($"Media final: {mediaExame.ToString("F1",CultureInfo.InvariantCulture)}");
            }
        }

        else if (media >= 7f)
        {
            Console.WriteLine($"Media {media.ToString("F1",CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno aprovado.");
        }
        else 
        {
            Console.WriteLine($"Media {media.ToString("F1",CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno Reprovado.");
        }
    }
}