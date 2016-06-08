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
    class IceGiantCombatHandler : ICombatHandler
    {
        private IUnit unit;

        public IceGiantCombatHandler(IUnit unit)
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
            if (this.Unit.HealthPoints > 150)
            {
                var sortedTargets = from pair in candidateTargets orderby pair.HealthPoints, pair.Name select pair;
                return sortedTargets;
            }
            else
            {
                var sortedTargets = from pair in candidateTargets orderby pair.HealthPoints, pair.Name select pair;
                List<IUnit> finalTarget = new List<IUnit>();
                finalTarget.Add(sortedTargets.First());

                return finalTarget;
            }
        }

        public ISpell GenerateAttack()
        {
            Stomp stomp = new Stomp();

            if (this.unit.EnergyPoints - stomp.EnergyCost < 0)
            {
                throw new NotEnoughEnergyException(string.Format("{0} does not have enough energy to cast Stomp", this.Unit.Name));
            }

            stomp.damage = this.Unit.AttackPoints;

            //increases attack by 5;
            this.unit.AttackPoints += 5;

            return stomp;
        }
    }
}
