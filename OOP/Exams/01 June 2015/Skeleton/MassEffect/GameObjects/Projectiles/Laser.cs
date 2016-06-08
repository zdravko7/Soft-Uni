using MassEffect.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Projectiles
{
    class Laser : Projectile
    {
        public Laser(int damage) : base(damage)
        {
        }

        public new void Hit(IStarship ship)
        {
            int healthDamage = this.Damage - ship.Health;

            //checks if the damage is more than the shield
            if (healthDamage > 0)
            {
                ship.Shields = 0;
                ship.Health -= healthDamage;
            }
            else
            {
                ship.Shields -= this.Damage;
            }
        }
    }
}
