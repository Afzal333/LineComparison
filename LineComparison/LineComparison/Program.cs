using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem Statement");
            CalculateLength calculateLength = new CalculateLength(5, 2, 5, 1);
            calculateLength.Calculate();
        }
    }
}
