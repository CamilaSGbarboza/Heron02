using System;

namespace Heron02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Área do triângulo");
            Console.ResetColor();
            Console.WriteLine();
 
            Console.WriteLine("Digite a área do triângulo:");
            Console.WriteLine();
 
            Console.WriteLine("Lado 1:");
            double a = Convert.ToDouble(Console.Read());
 
            Console.WriteLine("Lado 2:");
            double b = Convert.ToDouble(Console.ReadLine());
 
            Console.WriteLine("Lado 3:");
            double c = Convert.ToDouble(Console.ReadLine());
 
            double p = (a + b + c) / 2;
            Console.WriteLine($"Semiprerimetro: {p}");
 
            double A = Math.Sqrt (p *(p - a) * (p - b)* (p - c) );
            Console.WriteLine($"Área: {A}");


        }
    }
}
