using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing;
using WinterIsComing.Contracts;
using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    class Mage : Unit
    {  
        public Mage(string name, int x, int y) : base(name, x, y)
        {
            this.AttackPoints = 80;
            this.HealthPoints = 80;
            this.DefensePoints = 40;
            this.EnergyPoints = 120;
            this.range = 2;
            this.combatHandler = new MageCombatHandler(this);
        } 

        public override string ToString()
        {
            if (this.HealthPoints > 0)
            {
                return string.Format(">{0} - Mage at ({1},{2})\n-Health points = {3}\n-Attack points = {4}\n-Defense points = {5}\n-Energy points = {6}\n-Range = {7}",
                    this.Name, this.X, this.Y, this.HealthPoints, this.AttackPoints, this.DefensePoints, this.EnergyPoints, this.Range);
            }
            else
            {
                return string.Format(">{0} - Mage at ({1},{2})\n(Dead)", this.Name, this.X, this.Y);
            }
        }
    }
}
