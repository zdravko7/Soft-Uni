using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Models.CombatHandlers;

namespace WinterIsComing.Models.Units
{
    class IceGiant : Unit
    {
        public IceGiant(string name, int x, int y) : base(name, x, y)
        {
            this.AttackPoints = 150;
            this.HealthPoints = 300;
            this.DefensePoints = 60;
            this.EnergyPoints = 50;
            this.range = 1;
            this.combatHandler = new IceGiantCombatHandler(this);
        }

        public override string ToString()
        {
            if (this.HealthPoints > 0)
            {
                return string.Format(">{0} - IceGiant at ({1},{2})\n-Health points = {3}\n-Attack points = {4}\n-Defense points = {5}\n-Energy points = {6}\n-Range = {7}",
                    this.Name, this.X, this.Y, this.HealthPoints, this.AttackPoints, this.DefensePoints, this.EnergyPoints, this.Range);
            }
            else
            {
                return string.Format(">{0} - IceGiant at ({1},{2})\n(Dead)", this.Name, this.X, this.Y);
            }
        }
    }
}
