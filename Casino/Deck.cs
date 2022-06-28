using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck() //constructor goes above properties, shares name with the class = "Deck"
        {
            Cards = new List<Card>(); //refers to the property of the class: created empty list to add objects to

            for (int i = 0; i < 13; i++) //looping through each "Face", looped using i as the integer
            {
                for (int j = 0; j < 4; j++) //each time it loops through Face, it loops through Suit using j as the integer
                {
                    Card card = new Card(); //creating a new card 
                    card.Face = (Face)i; //casting to Face (index 0 in Face is 2, so it starts with 2)
                    card.Suit = (Suit)j; //casting to Suit (index 0 in Suit is Clubs, so starts with Clubs)
                    Cards.Add(card); //adds the card, goes back through loop
                }
            }

        }
        public List<Card> Cards { get; set; } //properties

        public void Shuffle(int times = 1) //creating a method (sometimes called function) called "shuffle" for Deck
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>(); //temporary list of cards
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); //random index between 0 and 52 (count of cards)
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }

        }
    }
}
