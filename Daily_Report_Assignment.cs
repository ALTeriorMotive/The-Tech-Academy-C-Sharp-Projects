using System;

namespace DailyReportAssignment
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number are you on.");
            short pgNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false.'");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string generalFB = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            byte studiedHrs = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
