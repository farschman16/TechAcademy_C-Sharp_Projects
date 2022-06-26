using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; } //Name and Dealer are properties of the class "Game"
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        public abstract void Play(); //abstract methods can only exist inside an abstract class, and contains no implementation
        //any class inheriting this class must inherit this method

        public virtual void ListPlayers() //ListPlayers is a method of object "Game". "virtual" methods have implementation, can be overridden
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
