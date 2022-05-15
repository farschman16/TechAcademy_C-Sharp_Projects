using System;
using System.Collections.Generic;


namespace ArraySubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "Hello!", "Yo!", "Whatup!", "What's Shakin'?", "Howdy!" }; // creating a string array. in this syntax, you don't have to add the instance. C# figures out you're creating an array.
            Console.WriteLine("Please pick an index of my array of greetings to print a random greeting.");
            int greeting = Convert.ToInt32(Console.ReadLine()); //converts the user input to an integer so it can be used to point to an index in my string array
            if (greeting > 4) //since the array only has indexes 0 through 4, anything greater than 4 has to include an error message
            {
                Console.WriteLine("Indexes above 4 do not exist "); //if user input greater than 4 is true, write this error message
            }
            else
            {
                Console.WriteLine(strArray[greeting]); //"else," if user input is NOT above 4, use their input to print one of the index values in my array
            }
            Console.ReadLine();

            int[] intArray = { 22, 150, 16, 787, 9 }; //creates an array of integers named intArray
            Console.WriteLine("Please pick an index of my array of integers to display a random number.");
            int indSelect = Convert.ToInt32(Console.ReadLine()); //convert the user's response (string) to an integer to be used to find the value of the index selected
            if (indSelect > 4)
            {
                Console.WriteLine("indexes above 4 do not exist."); //since the array only has indexes 0 through 4, nothing at position above 4 exists in the array
            }
            else
            {
                Console.WriteLine("Your random number is: " + intArray[indSelect]); //print the random number at the selected index
            }
            Console.ReadLine();

            List<string> stringList = new List<string>(); //creates a list called "stringList", adds new instance of a list, specifies data type <string>
            stringList.Add("A flamingo's head has to be upside-down when they eat."); //adds value to position 0
            stringList.Add("A cockroach's brain is inside of its body."); //adds value to position 1
            stringList.Add("A turtle's shell is best compared to a ribcage in humans."); //adds value to position 2
            stringList.Add("Armadillos can catch leprosy."); //value at position 3
            stringList.Add("Female ferrets die if they do not mate once they go into heat.");

            Console.WriteLine("Please pick an idex of my string list to display a random animal fact.");
            int strSelect = Convert.ToInt32(Console.ReadLine());
            if (strSelect > 4)
            {
                Console.WriteLine("indexes above 4 do not exist."); //again, this list only has indexes 0 through 4, nothing above 4 will print a value
            }
            else
            {
                Console.WriteLine(stringList[strSelect]); //if indexes 0 through 4 are chosen, the value at that index will be displayed.
            }
            Console.ReadLine();

        }
    }
}
