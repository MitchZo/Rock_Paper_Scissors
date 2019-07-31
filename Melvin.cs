using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class Melvin : Player
    {
        readonly Random rng = new Random();
        public override string GenerateRoshambo()
        {
            int melvinChoice = rng.Next(4);
            if (melvinChoice == 1)
            { return "rock"; }
            else if (melvinChoice ==2)
            { return "paper"; }
            else
            { return "scissors"; }
        }
    }
}
