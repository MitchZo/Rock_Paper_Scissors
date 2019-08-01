using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class Harry : Player
    {
        //all harry does is throw rock
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
