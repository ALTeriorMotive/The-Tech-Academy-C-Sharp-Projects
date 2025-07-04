using System;

namespace MathAndComperisonOperators
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter the following details: Hourly Rate");
            double rate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the following details: Hours worked per week");
            double hours1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter the following details: Hourly Rate");
            double rate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the following details: Hours worked per week");
            double hours2 = Convert.ToDouble(Console.ReadLine());

            double salary1 = rate1 * hours1 * 52;
            Console.WriteLine("Annual salary of Person 1: " + Convert.ToString(salary1));
            double salary2 = rate2 * hours2 * 52;
            Console.WriteLine("Annual salary of Person 2: " + Convert.ToString(salary2));

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool greaterThan = salary1 > salary2;
            Console.WriteLine(greaterThan);
            Console.ReadLine();
        }
    }
}
