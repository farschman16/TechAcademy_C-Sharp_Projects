using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    interface IWalkAway //interface naming convention; must start with uppercase letter
    {
        void WalkAway(Player player); //automatically public, doesn't need to be specified
    }
}
