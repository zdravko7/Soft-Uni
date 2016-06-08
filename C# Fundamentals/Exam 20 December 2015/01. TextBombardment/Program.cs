using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TextBombardment
{
    static void Main(string[] args)
    {
        string inputText = Console.ReadLine();
        int tableWidth = int.Parse(Console.ReadLine());

        string columnNumbers = Console.ReadLine();
        string[] columnNumbersStringArray = columnNumbers.Split();
        int[] columnNumbersIntArray = new int[columnNumbersStringArray.Length];

        for (int i = 0; i < columnNumbersStringArray.Length; i++)
        {
            columnNumbersIntArray[i] = int.Parse(columnNumbersStringArray[i]);
        }

        string outputText = "";

        for (int i = 0; i < inputText.Length; i++)
        {
            char currentSymbol = inputText[i];

            outputText += currentSymbol;
        }

        Console.WriteLine(outputText);

        for (int i = 0; i < columnNumbersIntArray.Length; i++)
        {
            int currentBombNumber = columnNumbersIntArray[i];
            int currentOutputPosition = currentBombNumber;

            do
            {
                outputText = outputText.Substring(0, currentOutputPosition-1) + ' ' + outputText.Substring(currentOutputPosition+1);

            } while ((outputText[currentOutputPosition] != ' ') && (currentOutputPosition < outputText.Length));

        }
    }
}