using System;
using System.Collections.Generic;

namespace Strings_Integers_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try/catch block to add user-friendly error messages for improper user input
            {
                List<int> integerList = new List<int>() { 20, 40, 60, 10, 30, 50 }; //shorthand syntax to create a new list of integers
                Console.WriteLine("Please enter a number by which my list of integers will be divided."); //ask the user for a number
                int userInt = Convert.ToInt32(Console.ReadLine()); //accepts user's input (string) and converts it to an integer in the same step
                foreach (int intSingle in integerList) //foreach loop to iterate through every item in list and do the steps in the loop
                {
                    Console.WriteLine(intSingle / userInt); //iterates through the list and divides each integer by the user's input
                }
            }
            catch (FormatException ex) //error for the user entering anything other than an integer (incorrect format)
            {
                Console.WriteLine(ex.Message + ".. The program will now continue.");
            }
            catch (DivideByZeroException ex) //divide by zero exception
            {
                Console.WriteLine(ex.Message + ".. You cannot divide by zero, dummy. The program will now continue."); //default message + custom text
            }
            catch (Exception ex) //any other exception
            {
                Console.WriteLine(ex.Message); //just default error text for exception type "Exception"
            }
            finally
            {
                Console.ReadLine();
            }
            Console.WriteLine("The Program has now exited the try/catch block successfully. Have a lovely day.");
            Console.ReadLine();
        }
    }
}
