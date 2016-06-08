using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace The_Numbers
{
    class TheNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] splitNumbers = Regex.Split(input, @"\D+");

            List<int> numbers = new List<int>();

            //checks for null entries (just in case)
            for (int i = 0; i < splitNumbers.Length; i++)
            {
                if (!string.IsNullOrEmpty(splitNumbers[i]))
                {
                    numbers.Add(int.Parse(splitNumbers[i]));
                }
            }

            List<string> hexNumbers = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                hexNumbers.Add(numbers[i].ToString("X").PadLeft(4,'0'));
            }

            for (int i = 0; i < hexNumbers.Count; i++)
            {
                if (i != hexNumbers.Count - 1)
                {
                    Console.Write("0x{0}-", hexNumbers[i]);
                }
                else
                {
                    Console.Write("0x{0}", hexNumbers[i]);
                }
            }
            
        }
    }
}
