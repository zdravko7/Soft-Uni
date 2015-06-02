//Find the 24th, 101st and 251st prime number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class SomePrimes
{
    public static void Main(string[] args)
    {

        int primeNumber = 1;
        int primeCounter = 0;

        int prime24 = 24;
        int prime101 = 101;
        int prime251 = 251;

        while (true)
        {
            if (primeNumber % 2 != 0 && primeNumber % 3 != 0 && primeNumber % 5 != 0 && primeNumber % 7 != 0 && primeNumber / primeNumber == 1)
            {
                //Console.WriteLine(primeNumber);
                primeCounter++;
            }

            if (primeCounter == 24 && prime24 == 24)
            {
                prime24 = primeNumber;
                Console.WriteLine("The 24th Prime number is: " + prime24);

            }
            else if (primeCounter == 101 && prime101 == 101)
            {
                prime101 = primeNumber;

                Console.WriteLine("The 101th Prime number is: " + prime101);
            }
            else if (primeCounter == 251 && prime251 == 251)
            {
                prime251 = primeNumber;
                Console.WriteLine("The 251th Prime number is: " + prime251);
            }

            primeNumber++;

            if (primeCounter == 251)
                break;

        }

    }
}