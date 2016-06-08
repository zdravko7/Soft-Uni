using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class QueryMess
{
    static void Main()
    {
        string input = Console.ReadLine();

        Regex whiteSpace = new Regex(@"((%20|\+)+)");

        while (input != "END")
        {
            MatchCollection query = Regex.Matches(input, @"(?:%20|\+)*([^?]*?)(?:%20|\+)*=(?:%20|\+)*(.*?)(?:%20|\+)*(?:&|\Z|\s)");

            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            foreach (Match match in query)
            {
                string entry = whiteSpace.Replace(match.Groups[1].ToString(), " ").Trim();
                string value = whiteSpace.Replace(match.Groups[2].ToString(), " ").Trim();

                if (!output.ContainsKey(entry))
                {
                    output.Add(entry, new List<string>());
                }
                output[entry].Add(value);
            }

            foreach (var line in output)
            {
                Console.Write(line.Key);
                Console.Write("=[" + string.Join(", ", line.Value) + "]");
            }
            Console.WriteLine();

            input = Console.ReadLine();
        }
    }
}