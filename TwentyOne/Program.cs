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
            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Matt", "Jesse", "Tony" };
            game.ListPlayers();
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
