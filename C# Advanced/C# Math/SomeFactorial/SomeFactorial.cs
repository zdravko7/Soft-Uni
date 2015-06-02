// This program finds the factorial of a given number

using System;
using System.Numerics;

public class SomeFactorials
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        while (number > 1)
        {
            result = result * number;
            number--;
        }

        Console.Write("The factorial of the given number is: ", number);
        Console.WriteLine(result);

    }
}
