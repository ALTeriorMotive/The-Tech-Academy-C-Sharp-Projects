using System;
using System.Collections.Generic;

namespace sixPartAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add user text to string array
            string[] stuff = { "words", "more words", "some stuff", "things", "text" };
            Console.WriteLine("Please input some text: ");
            string userInput = " + " + Console.ReadLine();

            for (int i = 0; i < stuff.Length; i++)
            {
                stuff[i] = stuff[i] + userInput;
            }

            for (int i = 0; i < stuff.Length; i++)
            {
                Console.WriteLine(stuff[i]);
            }


            //Loop using <
            int secretNum = 5;
            Console.WriteLine("Pick a number that's lower than the secret number");
            int guess = Convert.ToInt32(Console.ReadLine());
            bool answer = false;
            while (!answer)
            {
                if (guess < secretNum)
                {
                    answer = true;
                    Console.WriteLine("Well done! You guessed lower than the secret number!");
                }
                else
                {
                    Console.WriteLine("Try again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }


            //Loop using <=
            Console.WriteLine("Pick a number that's lower than or equal to the secret number");
            int guess2 = Convert.ToInt32(Console.ReadLine());
            bool answer2 = false;
            while (!answer2)
            {
                if (guess2 <= secretNum)
                {
                    answer2 = true;
                    Console.WriteLine("Well done! The secret number was " + secretNum + "!");
                }
                else
                {
                    Console.WriteLine("Try again");
                    guess2 = Convert.ToInt32(Console.ReadLine());
                }
            }


            //Search list of strings
            List<string> items = new List<string>() { "first", "second", "third", "fourth" };
            Console.WriteLine("Input text to search for here: ");
            string userQuery = Console.ReadLine();
            int index = 0;
            foreach (string item in items)
            {
                if (userQuery == item)
                {
                    Console.WriteLine("The index you are looking for is: " + Convert.ToString(index));
                    break;
                }
                index++;
                if (index == items.Count)
                {
                    Console.WriteLine("No match has been found");
                }
            }


            //Search list of strings containing two identical strings
            List<string> items2 = new List<string>() { "one", "two", "three", "four", "two" };
            List<string> matching = new List<string>();
            Console.WriteLine("Input text to search for here: ");
            string userQuery2 = Console.ReadLine();
            int index2 = 0;
            foreach (string item in items2)
            {
                if (userQuery2 == item)
                {
                    matching.Add(Convert.ToString(index2));
                }
                index2++;
                if (index2 == items2.Count && matching.Count == 0)
                {
                    Console.WriteLine("No match has been found");
                }
            }

            if (matching.Count > 0)
            {
                Console.WriteLine("Here are your matches: ");
                foreach (string match in matching)
                {
                    Console.WriteLine(match);
                }
            }


            //Shows strings in list and if it already appeared
            Console.WriteLine("Here is a list of strings");
            List<string> names = new List<string>() { "Dave", "Teo", "Bridget", "Veronica", "Dave", "Dave", "Teo", "Larry", "Dave"};
            List<string> namesMatch = new List<string>();
            bool repeat;

            foreach(string name in names)
            {
                repeat = false;
                foreach(string match in namesMatch)
                {
                    if (match == name)
                    {
                        Console.WriteLine(name + " (This name has appeared before)");
                        repeat = true;
                    }
                }
                if (!repeat)
                {
                    Console.WriteLine(name);
                    namesMatch.Add(name);
                }
            }


            //Infinite loop
            Console.WriteLine("Would you like to begin an infinite loop? y/n");
            string loopResponse = Console.ReadLine();
            int loopVar = 0;
            bool loop = false;
            if(loopResponse == "y")
            {
                loop = true;
            }
                while (loop)
                {
                    Console.WriteLine(Convert.ToString(loopVar));
                    loopVar++;
                }
        }
    }
}
