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
    }
}
