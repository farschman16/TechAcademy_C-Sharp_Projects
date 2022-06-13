using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMethodsObjects
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public override void SayName() //implementing the SayName method inside the Employee class
        {
            base.SayName();
        }
    }
}
