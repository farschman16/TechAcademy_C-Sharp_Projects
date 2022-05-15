using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 }; // we will be looking for passing scores within this integer array

            for (int i = 0; i < testScores.Length; i++) //for loop, in parentheses 3 conditions: starting value; how long to do loop; what to do after each time the loop runs
            {
                if (testScores[i] > 85) //adds condition: if score is above 85, it is passing
                {
                    Console.WriteLine("Passing test score: " + testScores[i]); //this prints all the scores that meet the condition
                }
            }
            Console.ReadLine();
            //this went through: start the loop at integer position 0 (first in the array)
            //as long as integer i is less than the length of the array...
            //each time the loop is completed, add one to integer variable i. 
            //as soon as the loop completes enough times that i is equal to 8 (number of values in the array), it ends the loop, and continues the program.


            string[] names = { "Matt", "Jesse", "Andrew", "Tony" }; //string array

            for (int j = 0; j < names.Length; j++) //starting value at position 0; goes the length of the string array; each time it goes through the loop it adds 1 to the value(index position)
            {
                if (names[j] == "Jesse")
                {
                    Console.WriteLine(names[j]);
                }
            }
            Console.ReadLine();

            //iteration for a list!!

            List<int> testScores2 = new List<int>(); //this is creating a class of list, then an instance of that class
            testScores2.Add(98);
            testScores2.Add(99);
            testScores2.Add(81);
            testScores2.Add(72);
            testScores2.Add(70);

            foreach (int score in testScores2) //for each item in the list, creates variable "score" within the list
            {
                if (score > 85) //creates the constraint of what to look for
                {
                    Console.WriteLine("Passing test score:" + score); //if the item within testScores2 fits the criteria >85, it does this
                }
            }
            Console.ReadLine();

            List<string> names2 = new List<string>() { "Jesse", "Erik", "Adam", "Matt" };

            foreach (string name2 in names2)
            {
                if (name2 == "Matt")
                {
                    Console.WriteLine(name2); //to print all the names in the list to the console, remove the "if" section, leaving this write.line part
                }
            }
            Console.ReadLine();


            List<int> testScores3 = new List<int>() { 98, 99, 12, 74, 23, 97 };
            List<int> passingScores = new List<int>(); //this is a blank list we will be adding things to

            foreach (int score3 in testScores3) //for every instance within the list that (meets below requirement, do the action)
            {
                if (score3 > 85)
                {
                    passingScores.Add(score3); //this adds all of the ones that fit the >85 requirement to the previously-blank list
                }
            }
            Console.WriteLine(passingScores.Count); //this counts the number of scores that meet the criteria
            Console.ReadLine();
        }
    }
}
