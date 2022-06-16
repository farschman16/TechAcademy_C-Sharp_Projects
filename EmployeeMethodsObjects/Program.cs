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
            Employee emp1 = new Employee(); //"emp1" instantiated as new instance of class "Employee"
            emp1.FirstName = "Sample"; //assigns value to FirstName
            emp1.LastName = "Student"; //assigns value to LastName
            emp1.SayName(); //calls the method for this object instance
            Console.ReadLine();
            //emp1.Quit();
            //Console.ReadLine();
            
        }
        private static void Quit(IQuittable quit1) //create object "quit1" of object type IQuittable
        {
            quit1.Quit(); //calling method from interface
            Console.ReadLine();
        }
    }
}
