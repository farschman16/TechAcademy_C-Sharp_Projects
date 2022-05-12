using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.ReadLine();

            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            int quotient = 100 / 5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            double quotient2 = 100.0 / 17.1;
            Console.WriteLine(quotient2);
            Console.ReadLine();

            int remainder = 11 % 2; //using the modulus (%), if you divide any number by 2, 
            Console.WriteLine(remainder); // if the remainder is 1, the number is odd. if 0, the number is even.
            Console.ReadLine();

            int num9 = 200 / 3;
            Console.WriteLine(num9);
            Console.ReadLine();

            this section includes the comparison operators

            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            int roomTemperature = 70; //setting the variable for a room temp
            int currentTemperature = 72; //this is the variable for current state
            bool isWarm = currentTemperature > roomTemperature; //if current is greater than constant (room temp), bool is true. if not, false.
            Console.WriteLine(isWarm);
            Console.ReadLine();

            int roomTemperature2 = 70; //setting constant
            int currentTemperature2 = 72; //variable for current state
            bool isWarm2 = currentTemperature2 == roomTemperature2; // double equals signs looks for equality only
            Console.WriteLine(isWarm2); // if you use !=, that means is variable A NOT equal to variable B
            Console.ReadLine();

            //Console Application Assignment starts here

            Console.WriteLine("Please enter a number");
            string randomNumber = Console.ReadLine(); //user has to enter number, this needs to be a string for ReadLine()
            double ranNum = Convert.ToInt32(randomNumber); //converts the response to a double (number)
            double ranNumMult = ranNum * 50; //multiples that number by 50
            Console.WriteLine("Your number multiplied by 50 = " + ranNumMult); // displays the text and the result of their number x 50

            Console.WriteLine("Please enter another number");
            string randomNumber2 = Console.ReadLine();
            int ranNum2 = Convert.ToInt32(randomNumber2); //convert to integer
            int ranNumAdd = ranNum2 + 25; //adds 25
            Console.WriteLine("Your number plus 25 = " + ranNumAdd);

            Console.WriteLine("Please enter yet another number");
            string randomNumber3 = Console.ReadLine();
            double ranNum3 = Convert.ToDouble(randomNumber3); //converts to a double (these have decimals)
            double ranNumDivide = ranNum3 / 12.5; //divides by 12.5
            Console.WriteLine("Your number divided by 12.5 = " + ranNumDivide); //text output of results

            Console.WriteLine("Please enter a number again!");
            string randomNumber4 = Console.ReadLine();
            int ranNum4 = Convert.ToInt32(randomNumber4);
            bool isGreater = ranNum4 > 50; //a boolean seeing if the number added is greater than 50
            Console.WriteLine("Is your number greater than 50? " +isGreater); //output text showing the result

            Console.WriteLine("Last time, please enter one more number");
            string randomNumber5 = Console.ReadLine();
            int ranNum5 = Convert.ToInt32(randomNumber5); //again, converts to an integer to use for calculations
            int divideBySeven = ranNum5 % 7; //using a modulus to show the remainder when divided by 7
            Console.WriteLine("Your number of " + ranNum5 + " divided by 7 leaves a remainder of " + divideBySeven); //prints results
        }
    }
}
