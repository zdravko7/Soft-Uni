using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.email = email;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
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

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be larger than 0");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            if (!String.IsNullOrEmpty(this.email))
            {
        	    return String.Format("Name: {0}, Age: {1}, Email: {2}", this.name, this.age, this.email);
            }
            else
            {
                return String.Format("Name: {0}, Age: {1}", this.name, this.age);
            }
        }

        static void Main(string[] args)
        {
            Person Pesho = new Person("Pesho", 69);
            Person Gosho = new Person("Gosho", 24, "gosho@abv.bg");

            Console.WriteLine(Pesho);
            Console.WriteLine(Gosho);
        }
    }
