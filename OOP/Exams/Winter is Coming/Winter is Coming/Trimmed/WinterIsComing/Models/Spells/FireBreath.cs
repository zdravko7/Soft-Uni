using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;

namespace WinterIsComing.Models.Spells
{
    class FireBreath : ISpell
    {
        internal int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
        }

        public int EnergyCost
        {
            get
            {
                return 30;
            }
        }
    }
}
