using MassEffect.GameObjects.Locations;
using MassEffect.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEffect.GameObjects.Ships
{
    class Starship : IStarship
    {
        private string name;
        private int health;
        private int shields;
        private int damage;
        private double fuel;
        private StarSystem location;

        public Starship()
        {
        }

        public Starship(string name, StarSystem location)
        {
            this.Name = name;
            this.Location = location;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public int Shields
        {
            get
            {
                return this.shields;
            }
            set
            {
                this.shields = value;
            }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }

        public double Fuel
        {
            get
            {
                return this.fuel;
            }
            set
            {
                this.fuel = value;
            }
        }

        public Locations.StarSystem Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public IProjectile ProduceAttack()
        {
            throw new NotImplementedException();
        }

        public void RespondToAttack(IProjectile attack)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Enhancements.Enhancement> Enhancements
        {
            get { throw new NotImplementedException(); }
        }

        public void AddEnhancement(Enhancements.Enhancement enhancement)
        {
            throw new NotImplementedException();
        }
    }
}
