using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMethodsObjects
{
    public class Person
    {
        public string FirstName { get; set; } //FirstName and LastName are properties of the class "Person"
        public string LastName { get; set; }

        public void SayName() //SayName is a method within class "Person"
        {
                Console.WriteLine("Name: " + FirstName +" "+ LastName);
        }
    }
}
