using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Submission
{
    class OutputClass
    {
        public void GetValues(out int x, out int y) //public method, outputs integer x and integer y
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine()) *3; //takes the user input, multiplies by 3 within the method

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine()) +7; //takes user input, adds 7 to output new value for y
        }
    }
}
