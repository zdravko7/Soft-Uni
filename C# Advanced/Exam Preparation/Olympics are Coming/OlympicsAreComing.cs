using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Olympics_are_Coming
{
    class OlympicsAreComing
    {
        static void Main(string[] args)
        {  
            
            Dictionary<string, Dictionary<string, int>> countries = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string pattern = @"\s+";

                string inputString = Console.ReadLine();

                inputString = Regex.Replace(inputString,pattern,"");

                string[] input = inputString.Split('|');

                if (input[0] == "report")
                    break;

               /* for (int i = 0; i < input.Length; i++)
                {
                    input[i] = Trimmer(input[i]);
                }*/

                foreach (var item in input)
                {
                    Console.WriteLine(item);
                }  

                string country = input.Last();

                string[] names = input[0].Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string fullName = names[0] + names[1];

                foreach (var item in input)
                {
                    Console.WriteLine(item);
                }

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string,int>());
                }

                if (!countries[country].ContainsKey(fullName))
                {
                    countries[country].Add(fullName, 1);
                }
                else if (countries[country].ContainsKey(fullName))
                {
                    countries[country][fullName]++;
                }





            }


        }

        public static string Trimmer(string input)
        {
            input = input.Trim();
            return input;
        }
    }
}






/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympics_are_Coming
{
    class OlympicsAreComing
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> countries = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "report")
                    break;

                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = Trimmer(input[i]);
                }


                
            }

        }

        public static string Trimmer(string input)
        {
            input = input.Trim();
            return input;
        }

    }
}
*/