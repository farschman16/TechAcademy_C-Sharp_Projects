using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //this method takes the dealt card list and adds Hand
        {
            Hand.Add(Deck.Cards.First()); //adds the first card availble in deck to Hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //writes the card being added to console
            Deck.Cards.RemoveAt(0); //removes first item in list from the Deck
        }
    }
}
