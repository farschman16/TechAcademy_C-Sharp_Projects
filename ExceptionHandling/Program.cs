using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try //basically, "try this program"
            {
                Console.WriteLine("Pick a number."); //this function creates three integers, the first two used to calculate with each other, the third is the result
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Divide the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by" + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex) //the catch lines function as a way to handle errors without system error messages
            {
                Console.WriteLine(ex.Message); //instead of "ex.Message", you can put in your own error in quotation marks.
            }
            catch (DivideByZeroException ex) //divide by zero exception
            {
                Console.WriteLine("You cannot divide by zero, dummy.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally //this is what will run no matter what. Even if the try executes with no exceptions or with exceptions
            {
                Console.ReadLine();
            }
        }   
    }
}
