using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card
    {
        public Suit Suit { get; set; } //Card class has a public (accessible to other parts of the probram) data type of string named Suit
        public Face Face { get; set; } //actions can be get or set of the properties

        public override string ToString()
        {
            return string.Format("{0} of {1} ", Face, Suit);
        }

    }
    //defining the suit enum right below "Card" class, with the 4 allowable values

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
