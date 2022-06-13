using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMethodsObjects
{
    public abstract class Person //abstract class; this cannot be instantiated directly, used to pass parameters to other classes
    {
        public string FirstName { get; set; } //FirstName and LastName are properties of the class "Person"
        public string LastName { get; set; }

        public virtual void SayName() //SayName is a method within class "Person": virtual method, can be overridden
        {
                Console.WriteLine("Name: " + FirstName +" "+ LastName);
        }
    }
}
