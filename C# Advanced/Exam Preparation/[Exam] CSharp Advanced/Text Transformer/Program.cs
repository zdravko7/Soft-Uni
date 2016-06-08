using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class TextTransformer
{
    static void Main(string[] args)
    {
        //List<string> input = new List<string>();

        StringBuilder input = new StringBuilder();

        while (true)
        {
            string inputString = Console.ReadLine();
            if (inputString == "burp") break;
            input.Append(inputString);
        }

        string finalString = String.Concat(input);

        finalString = System.Text.RegularExpressions.Regex.Replace(finalString, @"\s+", " ");

        string pattern = @"(\$([^'%&$]+)\$)|(\&([^'%&$]+)\&)|(%([^'%&$]+)%)|(\'([^'%&$]+)\')";
        MatchCollection matches = Regex.Matches(finalString, pattern, RegexOptions.IgnorePatternWhitespace);

        //checks for dollars
        foreach (var match in matches)
        {
            string currentMatch = match.ToString();

            string result = "";
            for (int i = 0; i < currentMatch.Length; i++)
            {
                switch (currentMatch[0])
                {
                    case '$':

                        if (i % 2 == 0)
                        {
                            result += (char)(currentMatch[i] - 1);
                            result = result.Trim(new char[] { ((char)(currentMatch[0] - 1)) });
                        }
                        else
                        {
                            result += (char)(currentMatch[i] + 1);
                            result = result.Trim(new char[] { ((char)(currentMatch[0] + 1)) });
                        }
                        break;

                    case '%':

                        if (i % 2 == 0)
                        {
                            result += (char)(currentMatch[i] - 2);
                            result = result.Trim(new char[] { ((char)(currentMatch[0] - 2)) });
                        }
                        else
                        {
                            result += (char)(currentMatch[i] + 2);
                            result = result.Trim(new char[] { ((char)(currentMatch[0] + 2)) });
                        }
                        break;

                    case '&':

                        if (i % 2 == 0)
                        {
                            result += (char)(currentMatch[i] - 3);
                            result = result.Trim(new char[] { ((char)(currentMatch[0] - 3)) });
                        }
                        else
                        {
                            result += (char)(currentMatch[i] + 3);
                            result = result.Trim(new char[] { ((char)(currentMatch[0] + 3)) });
                        }
                        break;

                    case '\'':

                        if (i % 2 == 0)
                        {
                            result += (char)(currentMatch[i] - 4);
                            result = result.Trim(new char[] { ((char)(currentMatch[0] - 4)) });
                        }
                        else
                        {
                            result += (char)(currentMatch[i] + 4);
                            result = result.Trim(new char[] { ((char)(currentMatch[0] + 4)) });
                        }
                        break;
                }
            }
            Console.Write(result + " ");
        }
    }
}