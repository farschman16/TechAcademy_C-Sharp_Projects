using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    interface IWalkAway //interface naming convention; must start with uppercase letter
    {
        void WalkAway(Player player); //automatically public, doesn't need to be specified
    }
}
