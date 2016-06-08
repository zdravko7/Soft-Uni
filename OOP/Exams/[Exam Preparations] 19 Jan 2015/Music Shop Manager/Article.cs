using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Shop_Manager
{
    class Article : MusicShop
    {
        internal string make;
        internal string model;
        internal decimal price;

        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

    }
}
