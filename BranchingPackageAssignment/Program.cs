using System;

namespace BranchingPackageAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. \n Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package in pounds (lbs.)?");
            int pWeight = Convert.ToInt32(Console.ReadLine()); //this line accepts the user's input and converts it to an integer
            if (pWeight > 50) //statement if the user input is larger than 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day."); //if it is larger than 50, this line prints
                Environment.Exit(0); //then this line ends the program since they cannot ship their package
            }
            Console.WriteLine("What is the width of your package in inches?"); //next 3 ask for dimensions and converts the answers to integers
            int pWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of your package in inches?");
            int pHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the length of your package in inches?");
            int pLength = Convert.ToInt32(Console.ReadLine());
            if (pWidth + pHeight + pLength > 50) //add the user inputs and if they add up to more than 50...
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day."); // the package cannot ship
                Environment.Exit(0); //ends the program right here. if not more than 50, program continues.
            }
            int pTotal = ((pHeight * pWidth * pLength) * pWeight) / 100; //creates a quote multiplying the dimensions and dividing the total by 100 for a dollar amount
            Console.WriteLine("Your estimated total for shipping this package is: $" + pTotal +"\n Thank you!"); //displays the result

        }
    }
}
