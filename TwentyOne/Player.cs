using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Player
    {
        public Player(string name, int beginngBalance)
        {
            Hand = new List<Card>();
            Balance = beginngBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator+ (Game game, Player player) //operands game and player return Game
        {
            game.Players.Add(player); //adds a player to the list
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player); //removes player from list
            return game;
        }

    }
}
