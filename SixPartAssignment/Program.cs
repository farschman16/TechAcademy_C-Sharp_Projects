using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1

            string[] strArray = { "Hello!", "Yo!", "Whatup!", "What's Shakin'?", "Howdy!" }; // creating a string array.
            Console.WriteLine("Please type something random. Anything you can think of."); //requesting the user add text
            string userResponse = Console.ReadLine(); //takes in a user response and assigns that response to variable "userResponse"
            for (int i = 0; i < strArray.Length; i++) //start loop at index 0, continue as long as the array has indexes
            {
                strArray[i]=strArray[i]+userResponse; //append the user's response to each string in the array
            }
            Console.ReadLine();
            
            foreach (string strEach in strArray) //declares each string in the array as strEach
            {
                Console.WriteLine(strEach); //print all values in array
            }

            //step 2 and 3

            int count = 0; //names the integer variable 'count'
            while (count < 16) //starts a while loop (if you reference the incorrect variable, the loop will be an infinite loop
            {
                Console.WriteLine("Count = [" + count + "]"); //for each instance of the loop, writes count = followed by the count number
                count++; //increments count for the loop 
            }
            Console.ReadLine();

            int count2 = 0;
            while (count2 <= 15)
            {
                Console.WriteLine("Counting up to 16, but you're only at " + count2 + ", keep going.");
                count2++;
            }
            Console.ReadLine();

            //step 4

            List<string> stringList = new List<string> { "hamburger", "hotdog", "cheeseburger", "bratwurst", "chicken", "veggies" };
            Console.WriteLine("Pick an item you'd like for me to put on the grill for you.");
            string foodItem = Console.ReadLine();
            switch (foodItem) //switch loop
            {
                case "hamburger": //states "in the case the user's input is hamburger..."
                    Console.WriteLine("{0}", stringList.IndexOf("hamburger")); //gives the index of that item in the string list
                    break; //breaks the loop, otherwise it would just keep coninuing to the next case. Instead, starts again
                case "hotdog":
                    Console.WriteLine("{0}", stringList.IndexOf("hotdog"));
                    break;
                case "cheeseburger":
                    Console.WriteLine("{0}", stringList.IndexOf("cheeseburger"));
                    break;
                case "bratwurst":
                    Console.WriteLine("{0}", stringList.IndexOf("bratwurst"));
                    break;
                case "chicken":
                    Console.WriteLine("{0}", stringList.IndexOf("chicken"));
                    break;
                case "veggies":
                    Console.WriteLine("{0}", stringList.IndexOf("veggies"));
                    break;
                default:
                    Console.WriteLine("Sorry, I do not have that. Try another item.");
                    break;
            }

            //step 5

            List<string> stringList2 = new List<string> { "Avalanche", "Blue Jackets", "Red Wings", "Blues", "Flames", "Blue Jackets" };
            Console.WriteLine("What is your favorite NHL team?");
            string strSelect = (Console.ReadLine()); //accepts the user's input
            if (stringList2.Contains(strSelect) == true) //condition to check if the selection is in the list
            {
                int j = 0;
                foreach (string strSelect2 in stringList2)
                    if (strSelect2 == stringList2[j])
                {
                    Console.WriteLine(stringList2.IndexOf(strSelect2)); //This will write the index of the user's selection
                }
                    else
                    {
                        break;
                    }
            }
            else
            {
                Console.WriteLine("Your selection is not in this list"); //if the selection is not in the list, it will write this line to the user
            }
            Console.ReadLine();

            //step 6

            List<string> stringList3 = new List<string> { "blue", "purple", "green", "orange", "pink", "purple" }; //creates the list of strings
            List<string> stringList4 = new List<string>(); //a blank list to add each item to, then to check if the item is repeated
            foreach (string colorString in stringList3) //foreach loop to iterate through the list
            {
                if (stringList4.Contains(colorString) == true) //this line checks to see if the string has been added to the new list yet
                {
                    stringList4.Add(colorString); //if it has, it will add the string value, and print the next line
                    Console.WriteLine(colorString + " Already exists in list.");
                }
                else
                {
                    Console.WriteLine(colorString + " is not yet in list."); //if it is not in the list, it simply prints this line then adds to the new list.
                    stringList4.Add(colorString);
                }
            }

            Console.ReadLine();
        }
    }
}
