using System;

namespace BooleanLogicAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please enter 'true' or 'false.'");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            byte ticketNum = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Qualified?");
            Console.WriteLine((age > 15) && (dui == false) && (ticketNum <= 3));
            Console.ReadLine();

        }
    }
}
