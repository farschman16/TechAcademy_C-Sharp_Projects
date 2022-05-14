using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemperature = 75;
            int roomTemperature = 70;

            string comparisonResult = currentTemperature == roomTemperature ? "It is room temp" : "It is not room temp";
            Console.WriteLine(comparisonResult);
            Console.ReadLine();

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("Room temperature is greater than current temperature");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            }
            Console.ReadLine();

            int roomTemperature = 70;

            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exaclty room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("It is colder than room temperature");
            }
            else
            {
                Console.WriteLine("Something went wrong");

                Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have a fav number of 12." : "You just don't like 12.";
            Console.WriteLine(result);
            Console.ReadLine();
            
        }
    }
}
