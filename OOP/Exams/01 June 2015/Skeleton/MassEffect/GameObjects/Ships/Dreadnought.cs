using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Ships
{
    class Dreadnought : Starship
    {
        public Dreadnought(string name, Locations.StarSystem location) 
            : base(name,location)
        {
            //Dreadnought - has start health 200, shields 300, damage 150 and fuel 700. Shoots a Laser with damage equal to half its shields + own damage. Responds to an attack by raising its shields by 50 before the attack and removes them after it.
            this.Health = 60;
            this.Shields = 50;
            this.Damage = 30;
            this.Fuel = 220;
        }
    }
}
