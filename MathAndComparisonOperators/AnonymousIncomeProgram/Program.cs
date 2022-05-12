using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly rate"); //request input from the user
            string p1Hourly = Console.ReadLine(); //accept user input as a string
            double p1HourlyCalc = Convert.ToDouble(p1Hourly); //convert the string to a double(number that accepts decimals)
            Console.WriteLine("Please enter your hours worked per week"); //request additional input from the user
            string p1HoursWorked = Console.ReadLine(); //accepts the input as a string
            double p1HoursWorkedCalc = Convert.ToDouble(p1HoursWorked); //converts the string entered into a double
            
            //use the same code for person 2, but rename the variables with "p2" prefix
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly rate");
            string p2Hourly = Console.ReadLine();
            double p2HourlyCalc = Convert.ToDouble(p2Hourly);
            Console.WriteLine("Please enter your hours worked per week");
            string p2HoursWorked = Console.ReadLine();
            double p2HoursWorkedCalc = Convert.ToDouble(p2HoursWorked);

            double p1Salary = p1HourlyCalc * p1HoursWorkedCalc * 52; //salary = hourly wage * hours worked * 52 weeks in a year
            double p2Salary = p2HourlyCalc * p2HoursWorkedCalc * 52;

            Console.WriteLine("Annual Salary of Person 1: \n" + p1Salary); //these lines print the calculated salaries of both persons
            Console.WriteLine("Annual Salary of Person 2: \n" + p2Salary);

            Console.WriteLine("Does Person 1 make more money than Person 2?"); //start the comparison
            bool p1Greater = p1Salary > p2Salary; //boolean that shows whether or not Person1 makes more than Person 2
            Console.WriteLine(p1Greater);
        }
    }
}
