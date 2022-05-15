using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isGuessed = number == 12; //states that the correct response is 12
            do //do this while loop no matter what
            {
                switch (number) //switch loop
                {
                    case 62: //states "in the case the user's input is 62..."
                        Console.WriteLine("You guessed 62. Try again."); //writes this line, and tells them to guess again
                        Console.WriteLine("Guess a number"); //gues again
                        number = Convert.ToInt32(Console.ReadLine()); //converts their input to integer again
                        break; //breaks the loop, otherwise it would just keep coninuing to the next case. Instead, starts again
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. That is correct!");
                        isGuessed = true; //since the correct answer is 12, changes the value of isGuessed to "true"
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed); //"While the variable 'isGuessed' is false"

            Console.ReadLine();
        }
    }
}
