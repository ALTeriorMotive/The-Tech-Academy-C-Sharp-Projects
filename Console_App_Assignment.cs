using System;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();

            int number = random.Next(1, 101);
            Console.WriteLine("Correct number (for ease of submission): " + number);
            Console.WriteLine("Please guess a number between 0 and 100:");
            int guess = Convert.ToInt16(Console.ReadLine());
            bool correct = false;

            do
            {
                if (!(guess >= 0 && guess <= 100))
                {
                    Console.WriteLine("Something went wrong. You are likely outside the requested range, please try again:");
                    guess = Convert.ToInt16(Console.ReadLine());
                }
                else
                {
                    if (guess == number)
                    {
                        Console.WriteLine("You guessed " + guess + ", you are right. Good Job!");
                        correct = true;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You guessed " + guess + ", you are wrong. Try again!");
                        guess = Convert.ToInt16(Console.ReadLine());
                    }
                }
            }
            while (!correct);
        }
    }
}
