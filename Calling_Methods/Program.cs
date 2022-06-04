using System;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What number would you like me to perform math actions on?"); //request user input
            int varSelect = Convert.ToInt32(Console.ReadLine()); //accept the user's input and convert to integer

            Mathy.addMathy(); //call method "addMathy"
            Mathy.mulitplyMathy(); //call method "multiplyMathy"
            Mathy.divideMathy(); //call method "divideMathy"

            Console.ReadLine();
        }
    }
}
