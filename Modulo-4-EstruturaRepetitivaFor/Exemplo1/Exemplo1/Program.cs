﻿namespace Exemplo1;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int x, soma = 0;
        for (int i = 1; i <= n; i++)
        {
            x = int.Parse(Console.ReadLine());
            soma += x;
        }
        
        Console.WriteLine(soma);
        
    }
}