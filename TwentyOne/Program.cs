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
            Deck deck = new Deck(); //created new deck (an instance of the deck object)
            deck = Shuffle(deck); //takes this deck and returns the Shuffled deck to it

            foreach (Card card in deck.Cards) //loops through to write each instance of card of type Card in the deck object
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck) //creating a method called "shuffle" for Deck
        {
            List<Card> TempList = new List<Card>(); //temporary list of cards
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //random index between 0 and 52 (count of cards)
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;
        }
    }
}
