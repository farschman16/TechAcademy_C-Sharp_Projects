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
            //int total = 5 + 10;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.ReadLine();

            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient2 = 100.0 / 17.1;
            //Console.WriteLine(quotient2);
            //Console.ReadLine();

            //int remainder = 11 % 2; //using the modulus (%), if you divide any number by 2, 
            //Console.WriteLine(remainder); // if the remainder is 1, the number is odd. if 0, the number is even.
            //Console.ReadLine();

            //int num9 = 200 / 3;
            //Console.WriteLine(num9);
            //Console.ReadLine();

            //this section includes the comparison operators

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
        }
    }
}
