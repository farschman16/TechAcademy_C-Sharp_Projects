using System;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What number would you like me to perform math actions on?"); //request user input
            int varSelect = Convert.ToInt32(Console.ReadLine()); //accept the user's input and convert to integer
            var MathyObject = new Mathy(); //instantiate the Mathy class
            var result = MathyObject.addMathy(varSelect); //creates variable "result" and takes the user's input to perform the math function
            Console.WriteLine(result);

            //calling second method
            var result2 = MathyObject.multiplyMathy(varSelect);
            Console.WriteLine(result2);

            //calling third method
            var result3 = MathyObject.divideMathy(varSelect);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
