using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && false);
            Console.WriteLine(true && true); //and function
            Console.WriteLine(false && false);

            Console.WriteLine(true || true);
            Console.WriteLine(true || false); //or function
            Console.WriteLine(false || false);

            Console.WriteLine(true == true);
            Console.WriteLine(true == false); //equal to
            Console.WriteLine(false == false);

            Console.WriteLine(true != true);
            Console.WriteLine(true != false); // NOT true
            Console.WriteLine(false != false);

            Console.WriteLine(true ^ true);
            Console.WriteLine(true ^ false); // called xor is true only if one of these things is true
            Console.WriteLine(false ^ false);

            Console.ReadLine();
        }
    }
}
