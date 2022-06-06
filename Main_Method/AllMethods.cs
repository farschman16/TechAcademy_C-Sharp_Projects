using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method
{
    public class AllMethods
    {
        public int getMath(int data, int value) //creates method "getMath" and defines it as (some type of data, and a value)
        {
            return data + value; //the return for this method is adding the two inputs
        }
        //create a second method with the same name, different parameters and functions
        public decimal getMath(decimal data, int value)
        {
            return Convert.ToInt32(data * value);
        }

        //create a third method that can accept a string and a value and perfom math on them
        public int getMath(string data, int value)
        {
            return (Convert.ToInt32(data)) / value;
        }
    }
}
