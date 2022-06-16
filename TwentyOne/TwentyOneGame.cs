using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway //putting the object "Game" after TwentyOneGame makes "Game" a superclass
    {
        public override void Play() //method within "TwentyOneGame" object, must use "override" since "Play" is abstract in class "Game"
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers() //this overrides the virtual method in Game
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }

        public void WalkAway(Player player) //implementing the interface "IWalkAway"
        {
            throw new NotImplementedException();
        }
    }
}
