using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ByteParty
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        while (true)
        {
            string commandsInput = Console.ReadLine();

            if (commandsInput == "party over")
                break;

            string[] commandsString = commandsInput.Split();
            int[] commands = new int[2];

            commands[0] = int.Parse(commandsString[0]);
            commands[1] = int.Parse(commandsString[1]);

            //starts operations
            if (commands[0] == -1)
            {
                for (int i = 0; i < n; i++)
			{
                int value = GetBits(numbers[i], commands[1]);

                if (value == 0)
                {
                    numbers[i] = ExchangeBits(numbers[i], commands[1], 1);
                }
                else
                {
                    numbers[i] = ExchangeBits(numbers[i], commands[1], 0);
                }

			}
                
            }
            else if (commands[0] == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = ExchangeBits(numbers[i], commands[1], 0);
                }
            }
            else if (commands[0] == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = ExchangeBits(numbers[i], commands[1], 1);
                }
            }
        }

        //writes final numbers
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(numbers[i]);
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
