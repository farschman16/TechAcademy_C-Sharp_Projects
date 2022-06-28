using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //this method takes the dealt card list and adds Hand
        {
            Hand.Add(Deck.Cards.First()); //adds the first card availble in deck to Hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card); //writes the card being added to console
            using (StreamWriter file = new StreamWriter(@"C:\Users\farsc\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now); //logs the date and time of now(when this happened)
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0); //removes first item in list from the Deck
        }
    }
}
