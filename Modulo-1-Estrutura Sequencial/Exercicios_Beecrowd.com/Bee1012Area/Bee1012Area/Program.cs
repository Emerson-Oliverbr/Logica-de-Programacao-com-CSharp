namespace Bee1012Area;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double triangulo, circulo, trapezio, quadrado, retangulo;

        triangulo = valor1 * valor3 / 2.0;
        circulo = 3.14159 * valor3 * valor3;
        trapezio = (valor1 + valor2) / 2.0 * valor3;
        quadrado = valor2 * valor2;
        retangulo = valor1 * valor2;

        Console.WriteLine($"Triangulo: {triangulo.ToString("F3",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Circulo: {circulo.ToString("F3",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Trapezio: {trapezio.ToString("F3",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Quadrado: {quadrado.ToString("F3",CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Retangulo: {retangulo.ToString("F3",CultureInfo.InvariantCulture)}");
    }
}