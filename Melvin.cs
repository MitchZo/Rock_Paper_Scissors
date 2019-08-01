using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public class Melvin : Player
    {
        readonly Random rng = new Random();
        public override WeaponOfChoice GenerateRoshambo()
        {
            int melvinChoice = rng.Next(4);
            if (melvinChoice == 1)
            { 
                return WeaponOfChoice.rock; 
            }
            else if (melvinChoice ==2)
            {
                return WeaponOfChoice.paper; 
            }
            else
            {   
                return WeaponOfChoice.scissors; 
            }
        }
    }
}
