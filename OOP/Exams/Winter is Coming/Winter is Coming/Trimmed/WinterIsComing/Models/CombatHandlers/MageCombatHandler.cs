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
    class MageCombatHandler : ICombatHandler
    {
        private IUnit unit;

        public MageCombatHandler(IUnit unit)
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
            var sortedTargets = (from pair in candidateTargets orderby pair.HealthPoints descending, pair.Name select pair).ToList();

            List<IUnit> finalTarget = new List<IUnit>();

            if (sortedTargets.Count < 3)
            {
                for (int i = 0; i < sortedTargets.Count; i++)
                {
                    finalTarget.Add(sortedTargets[i]);
                }
            }
            else
            {
                finalTarget.Add(sortedTargets[0]);
                finalTarget.Add(sortedTargets[1]);
                finalTarget.Add(sortedTargets[2]);
            }

            return finalTarget;
        }

        private string lastSpell = "Blizzard";

        public ISpell GenerateAttack()
        {
            if (lastSpell == "Blizzard")
            {
                var fireBreath = new FireBreath();

                if (this.unit.EnergyPoints - fireBreath.EnergyCost < 0)
                {
                    throw new NotEnoughEnergyException(string.Format("{0} does not have enough energy to cast Fire Breath", this.Unit.Name));
                }

                fireBreath.damage = this.Unit.AttackPoints;

                this.unit.EnergyPoints -= fireBreath.EnergyCost;

                lastSpell = "Fire Breath";

                return fireBreath;
            }
            else
            {
                var blizzard = new Blizzard();

                if (this.unit.EnergyPoints - blizzard.EnergyCost < 0)
                {
                    throw new NotEnoughEnergyException(string.Format("{0} does not have enough energy to cast Blizzard", this.Unit.Name));
                }

                blizzard.damage = (this.Unit.AttackPoints * 2);

                this.unit.EnergyPoints -= blizzard.EnergyCost;

                lastSpell = "Blizzard";

                return blizzard;
            }
        }
    }
}
