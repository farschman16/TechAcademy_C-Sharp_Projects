﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            Console.WriteLine("Provide a number to write to the log.");
            int writeNum = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\farsc\Logs\log2.txt", true))
            {
                file.WriteLine(writeNum);
            }
            Console.WriteLine(File.ReadAllText(@"C:\Users\farsc\Logs\log2.txt"));
            Console.ReadLine();

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("please enter a number");
            double enterDate = Convert.ToDouble(Console.ReadLine());
            DateTime lateTime = DateTime.Now.AddHours(enterDate);
            Console.WriteLine(lateTime);
            Console.ReadLine();

            const string thrsHockey = "WolfPack";
            var wedHockey = "BT5";
            Console.WriteLine(thrsHockey + " " + wedHockey);
            Console.ReadLine();
        }
    }
}
