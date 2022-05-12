using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \n Student Daily Report"); //writes the opening greeting

            Console.WriteLine("What is your name?"); //string, asks person to write a string that is their name
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?"); //another string asking to write a string of the course
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What page number?"); //string asking for page number
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber); //converts from string to integer

            Console.WriteLine("Do you need help with anything? \n Please answer \"True\" or \"False\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = Convert.ToBoolean(needHelp);
            Console.WriteLine("You've answered " + needHelpBool + " to needing additional help at this time.");

            Console.WriteLine("Were there any positive experiences you'd like to share? \n Please give specifics.");
            string posEx = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hrsStudy = Console.ReadLine(); //answer as a string
            int hrStudyInt = Convert.ToInt32(hrsStudy); //convert the string to an integer
            Console.WriteLine("You've studied " + hrStudyInt + "hrs today!"); //use that integer in the displayed text

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this Shortly. \n Have a Great Day!");

            //end of program
        }
    }
}
