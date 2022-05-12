using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // hit ctrl + k + c to comment out lines you've highlighted. ctrl + k + u uncomments the highlighted lines.

            //This is a program
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is " + yourName);
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber); //converts from string to integer
            int total = favNum + 5;
            Console.WriteLine("Your favotie number plus 5 is: " + total);
            Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m; //use decimal for financials

            double heightInCentimeters = 211.23451;

            float secondsLeft = 1.62f;

            short temperatureOnMars = -341;

            string myName = "Matt";

            int currentAge = 37;
            string yearsOld = currentAge.ToString(); //this converts from integer to string

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining); //converts from boolean to string

            Console.WriteLine(questionMark);
            Console.ReadLine();

            int num1 = 10;
            int num2 = 22;
            int sum = num1 + num2;
            Console.WriteLine(sum);

            int num3 = 4;
            int num4 = 6;
            int difference = num3 - num4;
            Console.WriteLine(difference);

            int num5 = 8;
            int num6 = 23;
            int product = num5 * num6;
            Console.WriteLine(product);

            int num7 = 38;
            int num8 = 3;
            int quotient = num7 / num8;
            Console.WriteLine(quotient);

            int num99 = 99;
            string myName2 = "Matt";
            string NameNum = num99 + myName;
            Console.WriteLine(NameNum);
        }
    }
}
