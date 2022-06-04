using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() //constructor goes above properties, shares name with the class = "Deck"
        {
            Cards = new List<Card>(); //refers to the property of the class: created empty list to add objects to
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //first list of properties
            List<string> Faces = new List<string>() //second list of properties
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
                "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces) //iterate through first list (adds a face)
            {
                foreach (string suit in Suits) //for each face, iterates through suits list and adds new card for each instance
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card); //this will iterate through to add a card through both lists
                }
            }

        }
        public List<Card> Cards { get; set; } //properties
    }
}
