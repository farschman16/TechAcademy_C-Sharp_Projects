using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //use arrays for fixed quantities you want to group together. Also want to use arrays for large quantities of something
        //lists can change and are easy to add/remove lines


        //lists!!!

        List<int> intList = new List<int>(); //creating a new list of <integers> named intList. create new instance of a list in second statement
        intList.Add(4); //add value at position 0
        intList.Add(10); //add value at position 1
        intList.Remove(10); //removes the value listed (in this case, at position1)

        List<string> stringList = new List<string>();
        stringList.Add("Hello"); //adds value to position 0
        stringList.Add("Matt"); //adds value to position 1
        stringList.Add("Whatup"); //adds value to position 2

        Console.WriteLine(stringList[2]); //prints value of position 2 of list "stringList" - in this case, "Whatup"
        Console.ReadLine();

        Console.WriteLine(intList[0]); //write line of intList at position 0 (which is 4, since it was added first).
        Console.ReadLine();

        //here is one way to write an array - this way is very inefficient

        int[] numArray = new int[5]; //here I have an integer array named "numArray", must use square brackets. have to define the length in the second part (the instance of the array)
        numArray[0] = 5; //value of the first integer in the array (at position 0, always starts at 0) is 5
        numArray[1] = 2; //value of the second integer (at position 1) is 2
        numArray[2] = 10; //value of the third integer (at position 2) is 10
        numArray[3] = 200; //value of the fourth integer (at position 3) is 200
        numArray[4] = 5000; //value of the fifth integer (at position 4) is 5000

        Console.WriteLine(numArray[3]); //this will print the integer at position 3
        Console.ReadLine();

        //this is a more efficient way to write the same exact array

        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 }; //integer array name numArray1 is a [new array] with these values at position {0, 1, 2, 3, and 4}

        Console.WriteLine(numArray1[3]);
        Console.ReadLine();

        // one more way to do the same thing

        int[] numArray2 = { 5, 2, 10, 200, 5000 }; //in this syntax, you don't have to add the instance. C# figures out you're creating an array.

        numArray2[4] = 650; //this is changing the value of the integer of the array in position 4, which used to be 5000, now will be 650
        Console.WriteLine(numArray2[4]);
        Console.ReadLine();


        //small introduction to byte arrays
        byte[] byteArray = new byte[5000]; //you can use byte arrays for very large quantities. more on this later

    }
}