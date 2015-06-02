//Finds the 24th, 101st and 251st prime number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{

    public static bool Fibonacci(int number1, int number2, int number3)
    {
        bool isFibonacci = true;

        if (number1 + number2 == number3)
        {
            isFibonacci = true;
        }
        else
        {
            isFibonacci = false;
        }

        Console.WriteLine(isFibonacci);
        return isFibonacci;

    }

    public static void Main(string[] args)
    {

        int primeNumber = 1;
        int primeCounter = 0;

        //IF you change these to Console.ReadLine(), you will get a program, which checks for Fibonacci sequence on given prime numbers
        int primeA = 24;
        int primeB = 101;
        int primeC = 251;

        while (true)
        {
            if (primeNumber % 2 != 0 && primeNumber % 3 != 0 && primeNumber % 5 != 0 && primeNumber % 7 != 0 && primeNumber / primeNumber == 1)
            {
                //Console.WriteLine(primeNumber);
                primeCounter++;
            }

            if (primeCounter == 24 && primeA == 24)
            {
                primeA = primeNumber;
                Console.WriteLine("The 24th Prime number is: " + primeA);

            }
            else if (primeCounter == 101 && primeB == 101)
            {
                primeB = primeNumber;
                Console.WriteLine("The 101th Prime number is: " + primeB);
            }
            else if (primeCounter == 251 && primeC == 251)
            {
                primeC = primeNumber;
                Console.WriteLine("The 251th Prime number is: " + primeC);
            }

            primeNumber++;

            if (primeCounter == 251)
                break;

        }
        Console.WriteLine();
        Console.Write("Are the given numbers in a Fibonacci sequrence? ");
        Fibonacci(primeA, primeB, primeC);


    }
}
