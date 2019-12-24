using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número: ");
            int n = int.Parse(Console.ReadLine());
            Calculator.calcular(ref n);
            Console.WriteLine(n);
        }
    }
}
