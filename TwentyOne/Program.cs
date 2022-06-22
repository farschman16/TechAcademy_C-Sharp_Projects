using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            //creates a new instance of the TwentyOneGame, adds players to game.
            //TwentyOneGame game = new TwentyOneGame(); //new instance of TwentyOneGame called "game"
            //game.Players = new List<string>() { "Matt", "Tony", "Andy" }; //in-line initializing into the list using curly braces
            //game.ListPlayers();
            //Console.ReadLine();

            //Game game = new TwentyOneGame(); //new instance of the game
            //game.Players = new List<Player>(); //instantiates the list "Players"
            //Player player = new Player();
            //player.Name = "Jesse";
            //game += player; //same as "game = game + player;
            //game -= player; //same as "game = game - player;


            Deck deck = new Deck(); //created new deck (an instance of the deck object)
            deck.Shuffle(3); //takes this deck and returns the Shuffled deck to it - calls the method "Shuffle"

            foreach (Card card in deck.Cards) //loops through to write each instance of card of type Card in the deck object
            {
                Console.WriteLine(card.Face + " of " + card.Suit); //writes the name of each card
            }
            Console.WriteLine(deck.Cards.Count); //displays the count of cards (how many cards)
            Console.ReadLine();
        }

    }
}
