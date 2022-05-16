using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 20.");
            int numCorrect = Convert.ToInt32(Console.ReadLine()); //converts answer to intenger

            bool isGuessed = numCorrect == 16; //states that the correct response is 16, otherwise will be false
            do //do this while loop no matter what
            {
                switch (numCorrect) //switch loop
                {
                    case 0: //states "in the case the user's input is less than 1..."
                        Console.WriteLine("You guessed too low. Number needs to be above 0. Try again."); //writes this line, and tells them to guess again
                        Console.WriteLine("Guess a number"); //guess again
                        numCorrect = Convert.ToInt32(Console.ReadLine()); //converts their input to integer again
                        break; //breaks the loop, otherwise it would just keep coninuing to the next case. Instead, starts again
                    case 20:
                        Console.WriteLine("You guessed 20. That is too high. Try again.");
                        Console.WriteLine("Guess a number");
                        numCorrect = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 40:
                        Console.WriteLine("You guessed 40, and I said guess between 1 and 20. Do better. Try again.");
                        Console.WriteLine("Guess a number");
                        numCorrect = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 16:
                        Console.WriteLine("You guessed 16. That is correct!");
                        isGuessed = true; //since the correct answer is 16, changes the value of isGuessed to "true" and the while loop will end in the next lines
                        break; //now that the "while"(below) is true, breaks out of the loop and continues through the program.
                    default: //default for any other incorrect case not explicitly written in the loop
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number");
                        numCorrect = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed); //"While the variable 'isGuessed' is false..." -this is changed to true when the correct answer is chosen.

            Console.ReadLine();


            //simple while loop

            int i = 0; //gives the variable i a value of 0
            while (i < 20) //initiates a while loop, and sets the parameters as i being less than 20
            {
                Console.WriteLine(i); //writes the value of i every time the loop is executed
                i++; //increases the value of i by 1 every time the loop executes. Once the loop goes through engough times to make i = 20, it exits the loop and continues the program.
            }
            Console.ReadLine();
        }
    }
}
