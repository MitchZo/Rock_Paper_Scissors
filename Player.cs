using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    public abstract class Player
    {
        private string name;
        private string weaponOfChoice;

        public string Name { get; set; }
        public WeaponOfChoice WeaponOfChoice { get; set; }

        public Player()
        {

        }

        public abstract WeaponOfChoice GenerateRoshambo();
    }
}
