using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem Statement");
            CalculateLength calculateLength1 = new CalculateLength(5, 2, 5, 1);
            double lenght1 = calculateLength1.Calculate();
            CalculateLength calculateLength2 = new CalculateLength(5, 2, 5, 1);
            double lenght2 = calculateLength2.Calculate();

            if (lenght1.Equals(lenght2))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Both Lines are not equal");            
        }
    }
}
