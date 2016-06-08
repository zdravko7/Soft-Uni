using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TerroristsWin
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();
        char[] input = new char[inputString.Length];

        for (int i = 0; i < inputString.Length; i++)
        {
            input[i] = inputString[i];
        }

        for (int i = 0; i < input.Length; i++)
        {
            long blastRange = 0;
            long blast = 0;
            long bombCounter = 2;
            //bomb counter checks how many letters are inside the bomb

            if (input[i] == '|')
            {
                if (input[i] == '|' && input[i + 1] == '|')
                {
                    input[i] = '.';
                    input[i + 1] = '.';
                    continue;
                }

                do
                {
                    blast += (long)input[i+1];
                    i++;
                    bombCounter++;
                }
                while (input[i+1] != '|');

                i++;
                blastRange = getValue(blast);

                //if (blastRange == 0)
               // {
                 //   
                //}

                //blasts letter infront of the bomb
                try
                {
                    for (int j = 0; j <= blastRange; j++)
                    {
                        input[i + j] = '.';
                    }
                }
                catch (IndexOutOfRangeException) {}

                //blasts letters behind the bomb
                try
                {
                    for (int k = 0; k < (blastRange + bombCounter); k++)
                    {
                        input[i - k] = '.';
                    }
                }
                catch (IndexOutOfRangeException) { }
            }
        }

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[i]);
        }

            
    }

    public static int getValue(long letter)
    {
        int result = (int) letter % 10;

        return result;
    }
}
