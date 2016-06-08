using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Ships
{
    class Frigate : Starship
    {

        public Frigate(string name, Locations.StarSystem location)
            : base(name, location)
        {
            //Frigate - has start health 60, shields 50, damage 30 and fuel 220. Shoots a ShieldReaver with damage equal to its own damage.
            this.Health = 60;
            this.Shields = 50;
            this.Damage = 30;
            this.Fuel = 220;
        }
    }
}
