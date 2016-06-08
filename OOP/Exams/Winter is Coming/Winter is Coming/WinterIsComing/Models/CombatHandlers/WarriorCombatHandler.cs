using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Core.Exceptions;
using WinterIsComing.Models.Spells;

namespace WinterIsComing.Models.CombatHandlers
{
    class WarriorCombatHandler : ICombatHandler
    {
        private IUnit unit;

        public WarriorCombatHandler(IUnit unit)
        {
            this.Unit = unit;
        }

        public IUnit Unit
        {
            get
            {
                return this.unit;
            }
            set
            {
                this.unit = value;
            }
        }

        public IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var sortedTargets = (from pair in candidateTargets orderby pair.HealthPoints, pair.Name select pair).ToList();

            if (sortedTargets.Count > 0)
            {
                List<IUnit> finalTarget = new List<IUnit>();
                finalTarget.Add(sortedTargets.First());
                return finalTarget;
            }
            return candidateTargets;
        }

        public ISpell GenerateAttack()
        {
            Cleave cleave = new Cleave();

            if (this.unit.EnergyPoints - cleave.EnergyCost < 0)
            {
                throw new NotEnoughEnergyException( string.Format("{0} does not have enough energy to cast Cleave", this.Unit.Name));
            }

            cleave.damage = this.Unit.AttackPoints;

            if (this.Unit.HealthPoints <= 80)
            {
                cleave.damage += (this.Unit.HealthPoints * 2);
            }

            if (this.unit.HealthPoints > 50)
            {
                this.unit.EnergyPoints -= cleave.EnergyCost;
            }

            return cleave;
        }
    }
}
