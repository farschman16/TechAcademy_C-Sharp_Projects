﻿using System;
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
            emp1.FirstName = "Sample";
            emp1.LastName = "Student";
            emp1.SayName();
            Console.ReadLine();
        }
    }
}
