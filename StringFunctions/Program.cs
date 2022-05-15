using System;
using System.Text;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Matt";
            string quote = "The man said, \"Hello\" Matt. \n Hello on a new line. \n \t Hello on a tab."; // \n is a new line, \t is a tab
            string fileName = @"C:\Users\farsc"; //the @ tells C# that everything after it and the quotes is the quote. the backslashes are not escape characters

            bool trueOrFalse = name.Contains("s"); //does name contain s? Can also be "name.EndsWith" and other options.

            int length = name.Length; //just gives the number of characters that variable contains

            name = name.ToUpper(); //changes variable "name" to all uppercase. Can also be name.ToLower or others.

            StringBuilder sb = new StringBuilder(); //this requires the "using System.Text;" line on the top of the page.
            sb.Append("my name is Matt"); //adds the quote to StringBuilder named "sb." This saves memory space.

            Console.WriteLine(quote);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(length);
            Console.ReadLine();

            //String Assignment

            string string1 = "Hello, my name is Matt.";
            string string2 = "I play hockey in Columbus, Ohio";
            string string3 = "...but not for the Blue Jackets. Sad face.";

            string stringFull = string1 + string2 + string3; //this concatenates all the lines
            Console.WriteLine(stringFull); //write the new concatenated string
            Console.ReadLine();

            string states = "Oh, Ak, Mi, De, Va...";
            states = states.ToUpper(); //converts all to uppercase
            Console.WriteLine(states);
            Console.ReadLine();

            StringBuilder newBuild = new StringBuilder(); //creates a new stringbuilder called "newBuild"
            newBuild.Append("This is how you build a string through StringBuilder. ");
            newBuild.Append("At least I think this is how it works. ");
            newBuild.Append("We will find out when I debug this thing. ");
            newBuild.Append("Maybe this won't even work.");

            Console.WriteLine(newBuild);
            Console.ReadLine();
        }
    }
}
