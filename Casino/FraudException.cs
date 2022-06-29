using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException() //constructor
            : base() { } //inherits from the base exception
        public FraudException(string message) //overloading the class with a second format
            : base(message) { } //also inherits from the base exception
    }
}
