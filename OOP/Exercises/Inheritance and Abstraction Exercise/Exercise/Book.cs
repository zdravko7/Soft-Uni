using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        internal string Title 
        {    
            get
            {
                return this.title;
            }
            set
            {
                //validation

                this.title = value;
            }
        }

        internal string Author 
        { 
            get
            {
                return this.author;
            }
            set
            {
                //validation

                this.author = value;
            }
        }

        internal virtual double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be a positive number");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Title: {0}, Author: {1}, Price: {2}$", title, author, price);
        }
    }
}
