using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Hyperlinks
{
    class ExtractHyperlinks
    {
        static void Main(string[] args)
        {
            string pattern = @"\bhref\b\s*=\s*\"".+?""";

            string quotePattern = @""".+?""";
            Regex regex = new Regex(pattern);

            while (true)
            {

                string text = Console.ReadLine();
                if (text == "END")
                    break;

                MatchCollection matches = regex.Matches(text);

                foreach (var match in matches)
                {
                    Console.WriteLine(Regex.Match(match.ToString(),quotePattern).ToString().Trim(new char[] {'"'}));
                }
            }
            

        }
    }
}
