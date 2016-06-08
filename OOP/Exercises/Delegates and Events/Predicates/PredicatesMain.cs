using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicates
{
    class PredicatesMain
    {
        static void Main(string[] args)
        {
            var students = new List<string> 
            { 
                "Pesho",
                "Joro",
                "Gunio",
                "Pesho",
                "Gunio"
            };

            var info = students.FirstOrD(p => p.First() == 'J');
            
            info.ToList().ForEach(p => Console.WriteLine(p));
        }
    }
}
