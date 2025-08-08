using System;
using System.Collections.Generic;

namespace ArraysSubmissionAssignment
{
    internal class Program
    {
        static void Main()
        {
            Random rng = new Random();

            string[] names = { "Tim", "John", "Alex", "Brody", "Jeffery"};
            int[] numbers = { rng.Next(0, 101), rng.Next(0, 101), rng.Next(0, 101), rng.Next(0, 101), rng.Next(0, 101) };

            //Array of strings

            Console.WriteLine("Please select an index for names (1-5): ");
            string nameResponse = Console.ReadLine();
            int nameConverted = int.Parse(nameResponse);

            bool acceptedName = false;
            while (!acceptedName)
            {
                if (nameConverted < 1 || nameConverted > 5)
                {
                    Console.WriteLine("That index does not exist, please try again (1-5): ");
                    nameResponse = Console.ReadLine();
                    nameConverted = int.Parse(nameResponse);

                }
                else
                {
                    acceptedName = true;
                    Console.WriteLine("You selected: " + names[nameConverted - 1]);
                }
            }

            //Array of integers

            Console.WriteLine("Please select an index for numbers (1-5): ");
            string numResponse = Console.ReadLine();
            int numConverted = int.Parse(numResponse);

            bool acceptednum = false;
            while (!acceptednum)
            {
                if (numConverted < 1 || numConverted > 5)
                {
                    Console.WriteLine("That index does not exist, please try again (1-5): ");
                    numResponse = Console.ReadLine();
                    numConverted = int.Parse(numResponse);

                }
                else
                {
                    acceptednum = true;
                    Console.WriteLine("You selected: " + numbers[numConverted - 1]);
                }
            }

            //List of strings

            List<string> moreNames = new List<string> { "Jack", "Barry", "Leo", "Austin", "Lucas"};

            Console.WriteLine("Please select an index for more names (1-5): ");
            string nameResponse2 = Console.ReadLine();
            int nameConverted2 = int.Parse(nameResponse2);

            bool acceptedName2 = false;
            while (!acceptedName2)
            {
                if (nameConverted2 < 1 || nameConverted2 > 5)
                {
                    Console.WriteLine("That index does not exist, please try again (1-5): ");
                    nameResponse2 = Console.ReadLine();
                    nameConverted2 = int.Parse(nameResponse2);

                }
                else
                {
                    acceptedName2 = true;
                    Console.WriteLine("You selected: " + moreNames[nameConverted2 - 1]);
                }
            }

            Console.WriteLine("Thank you for you selections");
            Console.ReadLine();
        }
    }
}
