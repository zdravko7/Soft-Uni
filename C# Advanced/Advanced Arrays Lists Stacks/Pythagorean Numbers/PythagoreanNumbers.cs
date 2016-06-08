using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythagorean_Numbers
{
    class PythagoreanNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            List<int> powNumbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                numbers.Add(input);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                powNumbers.Add((int)Math.Pow(numbers[i], 2));
            }
        }
    }
}
