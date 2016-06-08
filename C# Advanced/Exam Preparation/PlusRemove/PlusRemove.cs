using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PlusRemove
{
    static void Main()
    {
        char[][] jagged = new char[100][];
        int line = 0;

        //input
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "END") break;

            jagged[line] = new char[inputLine.Length];

            for (int i = 0; i < inputLine.Length; i++)
            {
                jagged[line][i] = inputLine[i];
    
            }

            line++;
        }
        //end of input

        for (int row = 0; row < 100; row++)
        {
            for (int col = 0; col < jagged[col].Length; col++)
            {
                Console.WriteLine();
            }
        }


    }
}
