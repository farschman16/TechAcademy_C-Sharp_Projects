using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Card
    {
       public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; } //Card class has a public (accessible to other parts of the probram) data type of string named Suit
        public string Face { get; set; } //actions can be get or set of the properties

    }
}
