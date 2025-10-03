namespace Bee1066ParesImparesPositivosENegativos;

class Program
{
    static void Main(string[] args)
    {
        int valoresPares = 0;
        int valoresImpares = 0;
        int valoresPositivos = 0;
        int valoresNegativos = 0;

        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0) {
            valoresPares++;
        }
        else {
            valoresImpares++;
        }
        if (num > 0) {
            valoresPositivos++;
        }
        else if (num < 0) {
            valoresNegativos++;
        }

        num = int.Parse(Console.ReadLine());
        if (num % 2 == 0) {
            valoresPares +=1;
        }
        else {
            valoresImpares +=1;
        }
        if (num > 0) {
            valoresPositivos += 1;
        }
        else if (num < 0) {
            valoresNegativos +=1;
        }

        num = int.Parse(Console.ReadLine());
        if (num % 2 == 0) {
            valoresPares +=1;
        }
        else {
            valoresImpares +=1;
        }
        if (num > 0) {
            valoresPositivos +=1;
        }
        else if (num < 0) {
            valoresNegativos +=1;
        }

        num = int.Parse(Console.ReadLine());
        if (num % 2 == 0) {
            valoresPares +=1;
        }
        else {
            valoresImpares += 1;
        }
        if (num > 0) {
            valoresPositivos +=1;
        }
        else if (num < 0) {
            valoresNegativos += 1;
        }

        num = int.Parse(Console.ReadLine());
        if (num % 2 == 0) {
            valoresPares += 1;
        }
        else {
            valoresImpares += 1;
        }
        if (num > 0) {
            valoresPositivos += 1;
        }
        else if (num < 0) {
            valoresNegativos += 1;
        }
        Console.WriteLine($"{valoresPares} valor(es) par(es) ");
        Console.WriteLine($"{valoresImpares} valor(es) impar(es) ");
        Console.WriteLine($"{valoresPositivos} valor(es) positivo(s) ");
        Console.WriteLine($"{valoresNegativos} valor(es) negativo(s) ");
    }
}