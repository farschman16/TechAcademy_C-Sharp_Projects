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

            IQuittable quitter = new Employee(); //instantiate an IQuittable object
            quitter.Id = 123456; //assign an Id to the new object  
            quitter.Quit(); //call the method for new employee object "quitter"
            Console.ReadLine();

        }
    }
}
