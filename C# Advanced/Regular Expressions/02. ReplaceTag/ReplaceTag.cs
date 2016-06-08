using System;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
        //string input = Console.ReadLine(); //for custom input

        string input = "<ul ><li><a href=http://softuni.bg>SoftUni</a> </li></ul>";

        Regex regex = new Regex(@"(?:<a href=)(.[^>]+)(?:>)(.[^<]+)(?:<\/a>)");

        Console.WriteLine(regex.Replace(input, "[URL href=$1]$2[/URL]"));
    }
}