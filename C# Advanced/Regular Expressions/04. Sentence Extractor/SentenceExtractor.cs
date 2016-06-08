using System;
using System.Text.RegularExpressions;
using System.Linq;

class SentenceExtractor
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string input = Console.ReadLine();

        MatchCollection sentences = Regex.Matches(input, @"\b.*?\b" + keyword + @"\b.*?[!.?]", RegexOptions.IgnoreCase);

        int[] numbers = Console.ReadLine().Split().Select(p => int.Parse(p)).ToArray();

        foreach (Match sentence in sentences)
        {
            Console.WriteLine(sentence);
        }
    }
}