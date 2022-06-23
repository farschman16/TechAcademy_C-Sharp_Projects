using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number(); //create new instance of "Number" named num1
            num1.Amount = 9995; //assign a value to new variable
            Console.WriteLine(num1.Amount); //print to console the variable's value of the Amount property
            Console.ReadLine();
        }
    }
}
