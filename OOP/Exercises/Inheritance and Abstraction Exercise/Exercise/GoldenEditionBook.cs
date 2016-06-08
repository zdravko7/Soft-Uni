using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, double price) : base(title, author, price)  {}

        internal override double Price
        {
            get
            {
                return base.Price * 1.3;
            }
            set
            {
                base.Price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Title: {0} Golden Edition, Author: {1}, Price: {2}$", Title, Author, Price);
        }
    }
}
