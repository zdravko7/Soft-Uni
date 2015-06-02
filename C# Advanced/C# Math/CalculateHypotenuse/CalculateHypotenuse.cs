//Calculates Hypotenuse from given 2 Cathets

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main(string[] args)
    {
        
        Console.Write("Please enter first cathet: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter first cathet: ");
        int b = Convert.ToInt32(Console.ReadLine());
        double hypotenuse;

        //Calculate Hypotenuse
        hypotenuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        Console.Write("The hypotenuse is: ");
        Console.WriteLine(hypotenuse);

    }
}
