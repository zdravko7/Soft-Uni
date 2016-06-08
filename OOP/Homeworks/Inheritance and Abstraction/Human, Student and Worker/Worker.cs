using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human__Student_and_Worker
{
    class Worker : Human
    {
        internal decimal weekSalary;
        internal decimal workHoursPerWeek;

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }
        public decimal WorkHoursPerWeek { get; set; }

        public Worker (string firstName, string lastName) : base(firstName, lastName) {}

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerWeek) : this(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerWeek = workHoursPerWeek;
        }
        
        internal decimal MoneyPerHour()
        {
            return this.weekSalary / this.workHoursPerWeek;
        }

        //WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
    }
}
