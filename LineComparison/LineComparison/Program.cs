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
            CalculateLength calculateLength2 = new CalculateLength(5, 2, 5, 2);
            double lenght2 = calculateLength2.Calculate();

            if (lenght1.Equals(lenght2))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Both Lines are not equal");
            if(lenght1.CompareTo(lenght2) == 0)
                Console.WriteLine("Line 1and Line 2 both are equal");
            if(lenght1.CompareTo(lenght2) > 0)
                Console.WriteLine("Line 1 is greate than Line 2");
            else
                Console.WriteLine("Line 2 is greater than Line 1");
        }
    }
}
