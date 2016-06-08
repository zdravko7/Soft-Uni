using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppercaseWords
{
    class UppercaseWords
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                    break;

                var strwords = FilterWords(input);
                string[] words = strwords.ToArray();

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].Trim(new char[] { ',', ' ', '1', '2', '3','4','5','6','7','8','9' });
                }

                words = words.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                //input tested, the array words contains all the uppercase words

                string[] reversedWords = new string[words.Length];

                for (int i = 0; i < words.Length; i++)
                {
                    if (Reverse(words[i]) != words[i])
                    {
                        reversedWords[i] = Reverse(words[i]);
                    }
                    else
                    {
                        reversedWords[i] = Double(words[i]);
                    }
                }

                /*foreach (var item in reversedWords)
                {
                    Console.WriteLine(item);
                }*/

                for (int i = 0; i < words.Length; i++)
                {
                    input = input.Replace(words[i], reversedWords[i]);
                }

                Console.WriteLine(input);
            }
        }

        static IEnumerable<string> FilterWords(string str)
        {
            var upper = str.Split(new char[] {' ', '.', '!','?' })
                        .Where(s => String.Equals(s, s.ToUpper()/*.Trim(new char[] { ',' })*/,
                                    StringComparison.Ordinal));

            return upper;

        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string Double(string s)
        {
            string doubled = "";

            for (int i = 0; i < s.Length; i++)
            {
                if(char.IsLetter(s[i]))
                {
                    doubled += s[i];
                    doubled += s[i];
                }
                else
                {
                    doubled += s[i];
                    continue;
                }
            }

            return doubled;
        }
    }
}
