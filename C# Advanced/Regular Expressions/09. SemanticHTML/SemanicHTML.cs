using System;
using System.Text.RegularExpressions;

class SemanticHTML
{
    static void Main()
    {
        string input = Console.ReadLine();

        while (input != "END")
        {
            Match html = Regex.Match(input, "(\\s*)<div(.*?)(?:id|class)\\s*=\\s*\"(\\w+)\"(.*?)>");

            string output = ("<" + html.Groups[3] + html.Groups[2] + html.Groups[4]).TrimEnd() + ">";

            output = Regex.Replace(output, @"\s+", " ");

            if (output != "<>")
            {
                Console.WriteLine(html.Groups[1] + output);
            }
            else
            {
                html = Regex.Match(input, @"(\s*)</div>\s*<!--\s*(.*?)\s*-->");

                output = "</" + html.Groups[2] + ">";

                if (output != "</>")
                {
                    Console.WriteLine(html.Groups[1] + output);
                }
                else
                {
                    Console.WriteLine(input);
                }
            }
            input = Console.ReadLine();
        }
    }
}