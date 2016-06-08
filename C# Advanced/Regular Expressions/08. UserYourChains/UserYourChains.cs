using System;
using System.Text.RegularExpressions;
using System.Text;

class UseYourChains
{
    static void Main()
    {
        string input = Console.ReadLine();

        string text = null;

        MatchCollection extractedInfo = Regex.Matches(input, "<p>(.*?)</p>");

        foreach (Match match in extractedInfo)
        {
            text += match.Groups[1];
        }

        text = Regex.Replace(text, @"[^a-z0-9]", " ");
        text = Regex.Replace(text, @"\s+", " ");

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= 'a' && text[i] < 'n')
            {
                output.Append((char)(text[i] + 13));
            }
            else if (text[i] >= 'n' && text[i] <= 'z')
            {
                output.Append((char)(text[i] - 13));
            }
            else
            {
                output.Append((char)text[i]);
            }
        }

        Console.WriteLine(output.ToString());
    }
}