using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method
{
    public class AllMethods
    {
        public int getMath(int data) //creates method "getMath" and defines it as (some type of data, and a value)
        {
            return data + 4; //the return for this method is adding the two inputs
        }
        //create a second method with the same name, different parameters and functions
        public int getMath(decimal data)
        {
            return Convert.ToInt32(data * 23);
        }

        //create a third method that can accept a string and a value and perfom math on them
        public int getMath(string data)
        {
            return (Convert.ToInt32(data)) / 6;
        }
    }
}
