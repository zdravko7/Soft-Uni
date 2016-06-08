using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    class Action
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int> { 1, 2, 3, 4, 5 };

            collection.ForEach(Console.WriteLine);
        }
    }
}
