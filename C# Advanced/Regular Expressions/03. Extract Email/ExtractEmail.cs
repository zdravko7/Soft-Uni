using System;
using System.Text.RegularExpressions;

class ExtractEmail
{
    static void Main()
    {
        MatchCollection emails = Regex.Matches(Console.ReadLine(), @"(?<=\s|^)([^-._\s][\w\.\-]+@[\w-]+\.[\w\.]+)");

        foreach (Match email in emails) Console.WriteLine(email.ToString().Trim('.'));
    }
}