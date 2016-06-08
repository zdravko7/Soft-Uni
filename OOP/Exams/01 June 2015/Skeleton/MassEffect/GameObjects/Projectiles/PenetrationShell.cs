using MassEffect.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Projectiles
{
    class PenetrationShell : Projectile
    {
        public PenetrationShell(int damage) : base(damage)
        {
        }

        public new void Hit(IStarship ship)
        {
            ship.Health -= this.Damage;
        }
    }
}
