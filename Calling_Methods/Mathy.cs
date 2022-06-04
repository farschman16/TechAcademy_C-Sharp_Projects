using System;
using System.Collections.Generic;
using System.Text;

namespace Calling_Methods
{
    public class Mathy //makes this class public (able to be used by other parts of the program)
    {
        public static void addMathy(int varSelect) //creating a method called addMathy within class "Mathy" to add to user input
        {
            Console.WriteLine(varSelect + 150); //this is what I want the method to do with the user input value of "varSelect"
        }
        public static void multiplyMathy(int varSelect)
        {
            Console.WriteLine(varSelect * 26);
        }
        public static void divideMathy(int varSelect)
        {
            Console.WriteLine(varSelect / 77);
        }
    }
}
