using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class Melvin : Player
    {
        readonly Random rng = new Random();
        public override Enum GenerateRoshambo()
        {
            int melvinChoice = rng.Next(4);
            if (melvinChoice == 1)
            { return Roshambo.rock; }
            else if (melvinChoice ==2)
            { return Roshambo.paper; }
            else
            { return Roshambo.scissors; }
        }
    }
}
