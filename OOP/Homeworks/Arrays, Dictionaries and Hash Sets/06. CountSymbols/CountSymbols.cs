using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] chars = new char[input.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = input[i];
            }

            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < chars.Length; i++)
            {
                if (!letters.ContainsKey(chars[i]))
                {
                    letters.Add(chars[i], 1);
                }
                else
                {
                    letters[chars[i]]++;
                }
            }

            var result = letters.Keys.ToList();
            result.Sort();

            // Loop through keys.
            foreach (var key in result)
            {
                Console.WriteLine("{0}: {1} time/s", key, letters[key]);
            }
 
        }

        public static void PrintDictionary(Dictionary<char, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine("{0}, {1}", item.Key, item.Value);
            }
        }
    }
}
