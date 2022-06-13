using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; } //Name and Dealer are properties of the class "Game"
        public string Dealer { get; set; }

        public abstract void Play(); //abstract methods can only exist inside an abstract class, and contains no implementation
        //any class inheriting this class must inherit this method

        public virtual void ListPlayers() //ListPlayers is a method of object "Game". "virtual" methods have implementation, can be overridden
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
