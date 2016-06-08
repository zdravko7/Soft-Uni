using System;
using System.Linq;

namespace HighQualityMethods.Utils
{
    static class NumberUtil
    {
        private static readonly string[] DigitsAsNames =
        {
            "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
        };

        /// <summary>
        /// Return digit name if it is in range 0 - 9
        /// </summary>
        /// <param name="digit"></param>
        /// <returns></returns>
        public static string GetDigitName(int digit)
        {
            if (digit < 0 || digit > 9)
            {
                throw new ArgumentOutOfRangeException("Digit must be in range 0-9!");
            }

            string digitName = DigitsAsNames[digit];
            return digitName;
        }

        public static int FindMaxNumber(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Collection can be null!");
            }

            if (elements.Length == 0)
            {
                throw new ArgumentOutOfRangeException( "Collections does not contain elements!");
            }

            int maxElement = elements.Max();
            return maxElement;
        }

        public static void PrintNumberAsPercent(dynamic number)
        {
            Console.WriteLine("{0:P2}", number);
        }

        public static void PrintNumberWithFixedPoint(dynamic number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintNumberRightAlignment(dynamic number)
        {
            Console.WriteLine("{0,8}", number);
        }
    }
}