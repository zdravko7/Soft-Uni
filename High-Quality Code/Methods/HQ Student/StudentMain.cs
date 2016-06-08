using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQStudent
{
    class StudentMain
    {
        static void Main(string[] args)
        {
            Student ivan = new Student("Ivan", "Ivanov", new DateTime(1992, 03, 17));
            Student gunio = new Student("Gunio", "Prostia", new DateTime(1993, 11, 03));

            Console.WriteLine(ivan);
            Console.WriteLine(gunio);

            Console.WriteLine("{0} is older than {1} -> {2}",
                ivan.FullName, gunio.FullName, ivan.CompareStudentsBirthDates(gunio));

            Console.WriteLine("{0} is older than {1} -> {2}",
               gunio.FullName,ivan.FullName, gunio.CompareStudentsBirthDates(ivan));
        }
    }
}