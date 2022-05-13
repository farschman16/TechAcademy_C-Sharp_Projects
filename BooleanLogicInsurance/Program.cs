using System;

namespace BooleanLogicInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Program \n Please answer the following questions (honestly, of course)");
            Console.WriteLine("What is your age?"); //asks for age
            string personAge = Console.ReadLine(); //takes in user's response as a string
            int personAgeInt = Convert.ToInt32(personAge); //converts response to an integer
            Console.WriteLine("Your age is " + personAgeInt); //writes their response in console

            Console.WriteLine("Have you ever had a DUI? (please answer \"yes\" or \"no\"");
            string personDUI = Console.ReadLine();
            Console.WriteLine("You answered " + personDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string personTickets = Console.ReadLine();
            int personTicketsInt = Convert.ToInt32(personTickets); //converts response to an integer
            Console.WriteLine("You have had " + personTicketsInt + " speeding tickets.");

            bool isQualified = (personAgeInt > 15) && (personDUI == "no") && (personTicketsInt <= 3); //states that all 3 qualifications must return "true" for the boolean to be true.
            Console.WriteLine("Are you qualified for this insurance?");
            Console.WriteLine(isQualified);
        }
    }
}
