using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMethodsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee //"emp1" instantiated as new instance of class "Employee"
            {
                FirstName = "Sample", //assigns value to FirstName
                LastName = "Student" //assigns value to LastName
            }; 
            emp1.SayName(); //calls the method for this object instance
            Console.ReadLine();

            IQuittable quitter = new Employee //instantiate an IQuittable object
            {
                Id = 123456 //assign an Id to the new object  
            };
            quitter.Quit(); //call the method for new employee object "quitter"
            Console.ReadLine();

            Employee emp2 = new Employee //new instance of employee "emp2"
            {
                FirstName = "Tony", //assigning values to emp2's attributes
                LastName = "Smith",
                Id = 223445
            };
            Employee emp3 = new Employee
            {
                FirstName = "Matt",
                LastName = "Farschman",
                Id = 456987
            };

            Console.WriteLine(emp2.Id == emp3.Id); //bool reading if the employee's Id numbers are the same
            Console.ReadLine();

            Employee<string> obj1 = new Employee<string>(); //new instance of generic Employee, assign list to obj1
            obj1.things = new List<string>(){ "desk", "pens", "keyboard", "monitor" }; //using "things" from generic employee class
            for (int i = 0; i < obj1.things.Count; i++) //create integer i, when loop is less than the length of the list, add 1 after writing line
            {
                Console.WriteLine(obj1.things[i]); //writes the object within generic Employee class called "things"
            }
            Employee<int> obj2 = new Employee<int>(); //integer instance of generic Employee, assign list to obj2
            obj2.things = new List<int> { 4245, 3352, 2367, 1664 };
            for (int j = 0; j < obj2.things.Count; j++) //create j at 0, while j is less than the length of the list, write line and then add 1 to j
            {
                Console.WriteLine(obj2.things[j]);
            }
            Console.ReadLine();


            //*****using the enum data type in class "Days" named "DaysoftheWeek"

            Console.WriteLine("Please enter the current day of the week."); //request the day of the week
            string daySelect = Console.ReadLine(); //assigns response to variable string "daySelect"
            DaysoftheWeek day1; //creates variable of the DaysoftheWeek class named "day1"
            try
            {
                day1 = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek), daySelect); //try; the variable day1 is parsed through they DaysoftheWeek type enum using user's input

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week."); //personalized error message
                Console.WriteLine(ex.Message); //system error message
            }
            finally
            {
                Console.WriteLine("Thank you!");
                Console.ReadLine();
            }

        }

    }
}
