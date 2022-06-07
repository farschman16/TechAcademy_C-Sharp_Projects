using System;

namespace Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number"); //request input
            var userSelect = Convert.ToInt32(Console.ReadLine()); // create variable userSelect to assign the input as an integer
            var AssignClassObject = new AssignClass(); //instantiates the class
            AssignClassObject.DivideMethod(userSelect);

            //this involves calling a method with output parameters x and y, local variables (within main program) a and b.
            OutputClass n = new OutputClass(); //n is the variable for the new OutputClass object

            int a, b; //defining a local variable to use in the function below
            n.GetValues(out a, out b); //OutputObject object "n", dot GetValues(the method), the two variables named earlier
            Console.WriteLine("After calling GetValues, the first value (a) is : {0}", a); //should be input multiplied by 3
            Console.WriteLine("After calling GetValues, the second value (b) is : {0}:", b); //input added to 7
            Console.ReadLine();

            //utilizing an overloaded method - commented out to utilize the static version below

            //OverloadClass newOC = new OverloadClass(); //"newOC" named as new instance of the OverloadClass
            //int sum1 = newOC.numAdd(7, 10); //this version will use the first method with the name numAdd
            //int sum2 = newOC.numAdd(11, 22, 33); //this will use the second version with the name numAdd since there are three inputs
            //Console.WriteLine("First Method named numAdd adds two integers and spits out " + sum1 + ".");
            //Console.WriteLine("Second Method named numAdd adds three integers and spits out " + sum2 + ".");
            //Console.ReadLine();

            Console.WriteLine(OverloadClass.numAdd(11, 112)); //calling a static object, you do not instantiate, simply call the method.
            Console.WriteLine(OverloadClass.numAdd(33, 123, 55)); //both versions will work because the method is overloaded
            Console.ReadLine();
        }
    }
}
