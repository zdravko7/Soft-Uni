using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextTransformer
{
    class TextTransformer
    {
        static void Main(string[] args)
        {
            string text = "";

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "burp")
                    break;

                //checked
                text += input;
            }

            string whiteSpacePattern = @"\s+";

            text = Regex.Replace(text,whiteSpacePattern," ");

            string pattern = @"([$&%'])([A-z0-9-_+ #^!@#?=*()]+)\1";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            string blabla = "$ asdasdsd$|asdasd||||";

            blabla = blabla.Trim(new char[] {'$', '|', ' ' });

            Console.WriteLine(blabla);

            /*string dollarPattern = @"\$([A-z0-9-_+]+)\$";
            string percentPattern = @"%([A-z0-9-_+]+)%";
            string ampersandPattern = @"&([A-z0-9-_+]+)&";
            string quotePattern = @"\'([A-z0-9-_+]+)\'";*/

           /* Regex dollarRegex = new Regex(dollarPattern);
            Regex percentRegex = new Regex(percentPattern);
            Regex ampersandRegex = new Regex(ampersandPattern);
            Regex quoteRegex = new Regex(quotePattern);*/

            /*MatchCollection dollars = dollarRegex.Matches(text);
            MatchCollection percents = percentRegex.Matches(text);
            MatchCollection ampersands = ampersandRegex.Matches(text);
            MatchCollection quotes = quoteRegex.Matches(text);*/


            Console.WriteLine();
        }

        //public static int GetValue(
    }
}
