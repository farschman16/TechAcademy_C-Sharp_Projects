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


            TwentyOneGame game = new TwentyOneGame(); //new instance of TwentyOneGame called "game"
            game.Players = new List<string>() { "Matt", "Tony", "Andy" }; //in-line initializing into the list using curly braces
            game.ListPlayers();
            Console.ReadLine();


            Console.ReadLine();

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
