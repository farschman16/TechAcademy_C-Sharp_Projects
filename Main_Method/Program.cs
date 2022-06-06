using System;
using System.Reflection.Metadata;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number."); //request user input
            var userInput = Convert.ToInt32(Console.ReadLine()); //conver the user's response to an integer

            var AllMethodsObject = new AllMethods(); //instantiate the AllMethods class
            var result = AllMethodsObject.getMath(userInput); //creates variable "result" and calls the getAdd method (performs userInput + 4 per the method definition)

            Console.WriteLine(result);
            Console.ReadLine();

            //calling the second method (same name as the first)

            Console.WriteLine("Please enter a decimal."); //request a decimal
            var userInput2 = Convert.ToDecimal(Console.ReadLine()); //user's input is converted to a decimal to be used by the method

            var AllMethodsObject2 = new AllMethods(); //instantiated the method with a new variable
            var result2 = AllMethodsObject2.getMath(userInput2); //new variable result2 takes the new instance, performs the method based on user input and "23"

            Console.WriteLine(result2);
            Console.ReadLine();

            //calling the third method, accepting a string and converting to int within the method

            Console.WriteLine("Please provide a number.");
            var userInput3 = Console.ReadLine(); //no need to conver the user input to int, this is done within the method

            var AllMethodsObject3 = new AllMethods();
            var result3 = AllMethodsObject3.getMath(userInput3);

            Console.WriteLine(result3);
            Console.ReadLine();

            //*** This section is related to the "Method Submission Assignment" Page; step 280.

            Console.WriteLine("Please enter a number, hit enter, and enter either a second number or leave blank.");
            var userNumber1 = Convert.ToInt32(Console.ReadLine());

            var OtherMethodsObject = new OtherMethods(); //instantiate OtherMethods, call it "OtherMethodsObject"
            int methodResult; //create a variable for the result of this method
            //parse to see if input is entered, go to if/else statement
            if (int.TryParse(Console.ReadLine(), out int userNumber2)) // if input, system assigns input to int userNumber2
            {
                methodResult = OtherMethodsObject.twoInts(userNumber1, userNumber2); //... and uses both inputs for this function
            }
            else
            {
                methodResult = OtherMethodsObject.twoInts(userNumber1); //if user does not enter input, use this function
            }

            Console.WriteLine(methodResult);
            Console.ReadLine();


            //***** This section is related to the "Method Class Submission Assignment" Page; step 281

            var MethodClassObject = new MethodClass(); //instantiating the class "MethodClass"
            MethodClassObject.VoidMethod(12, 33);
            //MethodClassObject.VoidMethod(); current issue***

        }

    }
}
