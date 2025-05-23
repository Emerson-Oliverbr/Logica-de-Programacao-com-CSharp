﻿using System;
using System.Globalization;

namespace EntradaDeDadosParte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            char sexo = char.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] dadosCadastrais = Console.ReadLine().Split(' ');
            string nome = dadosCadastrais[0];
            char genero = char.Parse(dadosCadastrais[1]);
            int idade2 = int.Parse(dadosCadastrais[2]);
            double estatura = double.Parse(dadosCadastrais[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine($"{idade}");
            Console.WriteLine($"{sexo}");
            Console.WriteLine($"{altura.ToString("F2",CultureInfo.InvariantCulture)}" + "\n");
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(idade2);
            Console.WriteLine(estatura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}



