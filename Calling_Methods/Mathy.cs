﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calling_Methods
{
    public class Mathy //makes this class public (able to be used by other parts of the program)
    {
        public int addMathy(int data, int value) //creating a method called addMathy within class "Mathy" to add to user input
        {
            return data + value; //this is what I want the method to do with the user input value of "varSelect"
        }
        public int multiplyMathy(int data, int value)
        {
            return data * value;
        }
        public int divideMathy(int data, int value)
        {
            return data / value;
        }
    }
}
