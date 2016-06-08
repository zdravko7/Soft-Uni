using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterIsComing.Contracts;
using WinterIsComing.Core.Exceptions;

namespace WinterIsComing.Models.Units
{
    abstract class Unit : IUnit
    {
        private int x;
        private int y;
        private readonly string name;
        internal int range;
        private int attackPoints;
        private int healthPoints;
        private int defensePoints;
        private int energyPoints;
        internal ICombatHandler combatHandler;

        public Unit(string name, int x, int y)
        {
            this.name = name;
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new InvalidPositionException("Index outside of matrix");
                }

                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new InvalidPositionException("Index outside of matrix");
                }

                this.y = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Range
        {
            get { return this.range; }
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                if (value < 0)
                {
                    //throw new GameException("Value must be positive");
                }

                this.attackPoints = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value < 0)
                {
                    //throw new GameException("Value must be positive");
                }

                this.healthPoints = value;
            }
        }

        public int DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            set
            {
                if (value < 0)
                {
                    // throw new GameException("Value must be positive");
                }

                this.defensePoints = value;
            }
        }

        public int EnergyPoints
        {
            get
            {
                return this.energyPoints;
            }
            set
            {
                if (value < 0)
                {
                    //throw new NotEnoughEnergyException("");
                }

                this.energyPoints = value;
            }
        }

        public ICombatHandler CombatHandler
        {
            get { return this.combatHandler; }
        }
    }
}
