using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Ships
{
    class Cruiser : Starship
    {
        //Cruiser - has start health 100, shields 100, damage 50 and fuel 300. Shoots a PenetrationShell with damage equal to its own damage.
        public Cruiser(string name, Locations.StarSystem location) 
            : base(name,location)
        {
            this.Health = 100;
            this.Shields = 100;
            this.Damage = 50;
            this.Fuel = 300;
        }
    }
}
