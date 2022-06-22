using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

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
