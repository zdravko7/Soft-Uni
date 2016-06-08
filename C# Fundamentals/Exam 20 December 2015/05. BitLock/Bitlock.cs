using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bitlock
{
    static void Main(string[] args)
    {
        string inputNumbers = Console.ReadLine();

        string[] inputStringArray = inputNumbers.Split();
        int[] numbers = new int[8];

        for (int i = 0; i < inputStringArray.Length; i++)
        {
            numbers[i] = int.Parse(inputStringArray[i]);
        }

        //operations
        while (true)
        {
            string input = Console.ReadLine();

            //stops the while loop
            if (input == "end")
                break;

            //contains input information
            string[] inputInfo = input.Split();

            //operation "Check"
            if (input.Contains("check"))
            {
                int bitCounter = 0;

                //checks the numbers for the bit
                for (int i = 0; i < numbers.Length; i++)
			    {
			        int bit = GetBits(numbers[i], int.Parse(inputInfo[1]));
                    if (bit == 1)
                        bitCounter++;
			    }
                Console.WriteLine(bitCounter);
            }

            //direction changers
            if (inputInfo.Length == 3)
            {
                int position = int.Parse(inputInfo[0]);
                string direction = inputInfo[1];
                int change = int.Parse(inputInfo[2]);

                //RIGHT
                if (direction == "right")
                {
                    for (int i = 0; i < change; i++)
                    {
                        int holdBit = GetBits(numbers[position], 0);
                        numbers[position] = numbers[position] >> 1;
                        numbers[position] = ExchangeBits(numbers[position], 11, holdBit);

                    }       
                }

                //LEFT
               if (direction == "left")
                {
                    for (int i = 0; i < change; i++)
                    {
                        int holdBit = GetBits(numbers[position], 11);

                        numbers[position] = ExchangeBits(numbers[position], 11, 0);

                        numbers[position] = numbers[position] << 1;
                        numbers[position] = ExchangeBits(numbers[position], 0, holdBit);

                    }
               }
            }


        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

    }

    public static int GetBits(int number, int position)
    {
        int newPosition = number >> position;
        int bit = newPosition & 1;

        // Console.WriteLine(bit);

        return bit;
    }

    public static int ExchangeBits(int number, int position, int value)
    {
        int result = 0;

        if (value == 0)
        {
            int mask = ~(1 << position);
            result = number & mask;

        }
        else
        {
            int mask = 1 << position;
            result = number | mask;
        }

        return result;
    }
}