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

            string name1 = "Jeb";
            if (name1 == "Steve")
            {
                Console.WriteLine("your name is not Matt");
            }
            else if (name1 == "Carl")
            {
                Console.WriteLine("you are a Carl");
            }
            else if (name1 == "Matt")
            {
                Console.WriteLine("hello, Matt.");
            }
            else
            {
                Console.WriteLine("Who the hell are you?");
            }

            if (1 != 2)
            {
                Console.WriteLine("Obviously.");
            }
            else
            {
                Console.WriteLine("please help.");
            }
        }
    }
}
