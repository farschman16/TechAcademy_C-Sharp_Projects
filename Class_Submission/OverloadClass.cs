using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Submission
{
    static class OverloadClass
    {
        //overloading a method: multiple methods with the same name, different parameters (either type or number of)
        public static int numAdd(int a, int b) //this method adds two parameters
        {
            int sum = a + b;
            return sum;
        }

        public static int numAdd(int a, int b, int c) //method with the same name that adds three parameters
        {
            int sum = a + b + c;
            return sum;
        }
    }
}
