using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class BookShop
    {
        static void Main(string[] args)
        {
            Book sherlock = new Book("Sherlock Holmes", "Sir Arthur Connan Doyle", 20);

            Console.WriteLine(sherlock);

            GoldenEditionBook specialSherlock = new GoldenEditionBook(sherlock.Title, sherlock.Author, sherlock.Price);

            Console.WriteLine(specialSherlock);
        }
    }
}
