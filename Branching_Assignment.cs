using System;

namespace BranchingSubmissionAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            float weight = Convert.ToSingle(Console.ReadLine());
            if(weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                float width = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Please enter the package height");
                float height = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                float length = Convert.ToSingle(Console.ReadLine());
                if((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    string quote = Convert.ToString((height * width * length * weight) / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
