using System;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number."); //request user input
            var userInput = Convert.ToInt32(Console.ReadLine()); //conver the user's response to an integer

            var AllMethodsObject = new AllMethods(); //instantiate the AllMethods class
            var result = AllMethodsObject.getMath(userInput, 4); //creates variable "result" and calls the getAdd method (performs userInput + 4 per the method definition)

            Console.WriteLine(result);
            Console.ReadLine();

            //calling the second method (same name as the first)

            Console.WriteLine("Please enter a decimal."); //request a decimal
            var userInput2 = Convert.ToDecimal(Console.ReadLine()); //user's input is converted to a decimal to be used by the method

            var AllMethodsObject2 = new AllMethods(); //instantiated the method with a new variable
            var result2 = AllMethodsObject2.getMath(userInput2, 23); //new variable result2 takes the new instance, performs the method based on user input and "23"

            Console.WriteLine(result2);
            Console.ReadLine();

            //calling the third method, accepting a string and converting to int within the method

            Console.WriteLine("Please provide a number.");
            var userInput3 = Console.ReadLine(); //no need to conver the user input to int, this is done within the method

            var AllMethodsObject3 = new AllMethods();
            var result3 = AllMethodsObject3.getMath(userInput3, 6);

            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
