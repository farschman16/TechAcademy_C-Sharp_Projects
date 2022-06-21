using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMethodsObjects
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName() //implementing the SayName method inside the Employee class
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName); //defines what the method will accomplish
        }
        public void Quit() //implementing the method "Quit" from interface "IQuittable" 
        {
            Console.WriteLine("Employee number " + Id + " has quit."); //defining what the method will do
        }
        public static bool operator ==(Employee employee, Employee employee2) //overload the "==" operator
        {
            if (employee.Id == employee2.Id) //compares the two employee Ids to see if they are the same
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee employee, Employee employee2) //also overloading the "not equal" operator
        {
            return employee.Id != employee2.Id;
        }
    }
}
