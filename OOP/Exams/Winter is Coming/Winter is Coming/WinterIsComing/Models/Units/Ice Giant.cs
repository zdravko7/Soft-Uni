using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Units
{
    class Ice_Giant : Unit
    {
        public Ice_Giant(string name, int x, int y) : base(name, x, y)
        {
            this.AttackPoints = 150;
            this.HealthPoints = 300;
            this.DefensePoints = 40;
            this.EnergyPoints = 120;
            this.range = 2;
            this.combatHandler = new WarriorCombatHandler();
        }
    }
}
