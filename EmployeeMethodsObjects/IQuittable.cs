using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMethodsObjects
{
    interface IQuittable
    {
        int Id { get; set; } //initializing the Id field to be used by this interface

        void Quit(); //creates the method "Quit()"
    }
}
