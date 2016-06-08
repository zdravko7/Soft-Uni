using System;
using System.Text.RegularExpressions;

class ValidUsernames
{
    static void Main()
    {
        MatchCollection usernames = Regex.Matches(Console.ReadLine(), @"(\b[a-zA-Z][^\\\/\)\(\s]{2,24}?\b)");

        int sum = 0;
        int biggestSum = 0;
        int biggestIndex = 0;

        for (int i = 0; i < usernames.Count - 1; i++)
        {
            sum = usernames[i].Length + usernames[i + 1].Length;
            if (sum > biggestSum)
            {
                biggestSum = sum;
                biggestIndex = i;
            }
        }
        Console.WriteLine(usernames[biggestIndex]);
        Console.WriteLine(usernames[biggestIndex + 1]);
    }
}