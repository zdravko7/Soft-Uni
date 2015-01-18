// This program finds the factorial of a given number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Numerics;

public class SomeFactorials
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your number: ");
        double number = Convert.ToDouble(Console.ReadLine());
        BigInteger result = new BigInteger();
        result = 1;

        while (number != 0)
        {
            result = result * (BigInteger) number;
            number--;
        }

        Console.Write("The factorial of the given number is: ", number);
        Console.WriteLine(result);

    }
}
