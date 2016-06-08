using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FunWithMatrices
{
    static void Main(string[] args)
    {

        double[,] matrix = new double[4, 4];

        matrix[0, 0] = double.Parse(Console.ReadLine());

        double step = double.Parse(Console.ReadLine());

        //creates the matrix
        matrix[0, 1] = matrix[0, 0] + step;
        matrix[0, 2] = matrix[0, 1] + step;
        matrix[0, 3] = matrix[0, 2] + step;
        for (int row = 1; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                if (col > 0)
                {
                    matrix[row, col] = (matrix[row, col - 1] + step);
                }
                else
                {
                    matrix[row, col] = (matrix[row - 1, 3] + step);
                }
            }
        }
        //everything works until here
        string userInput = "";
        string[] input = new string[4];

        //does operations
        while (true)
        {
            userInput = Console.ReadLine();

            if (userInput == "Game Over!")
                break;

            input = userInput.Split();

            int row = int.Parse(input[0]);
            int col = int.Parse(input[1]);
            string operation = input[2];
            double value = double.Parse(input[3]);

            switch (operation)
            {
                case "multiply":
                    matrix[row, col] *= value;
                    break;

                case "sum":
                    matrix[row, col] += value;
                    break;

                case "power":
                    matrix[row, col] = Math.Pow(matrix[row, col], value);
                    break;
            }
        }

        //gets final result
        double resultLeftD = matrix[0, 0] + matrix[1, 1] + matrix[2, 2] + matrix[3, 3];
        double resultRightD = matrix[3, 0] + matrix[2, 1] + matrix[1, 2] + matrix[0, 3];

        double resultRow = 0;
        double maxRow = double.MinValue;
        double maxRowNum = 0;

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                resultRow += matrix[row, col];
            }
            if (resultRow > maxRow)
            {
                maxRow = resultRow;
                maxRowNum = row;
            }
            resultRow = 0;
        }

        double resultCol = 0;
        double maxCol = double.MinValue;
        double maxColNum = 0;

        for (int col = 0; col < 4; col++)
        {
            for (int row = 0; row < 4; row++)
            {
                resultCol += matrix[row, col];
            }
            if (resultCol > maxCol)
            {
                maxCol = resultCol;
                maxColNum = col;
            }
            resultCol = 0;
        }

        //gets final results
        double[] results = new double[4];

        results[0] = maxRow;
        results[1] = maxCol;
        results[2] = resultLeftD;
        results[3] = resultRightD;

        double finalResult = results.Max();

        if (finalResult == maxRow)
        {
            Console.WriteLine("ROW[{0}] = {1:0.00}", maxRowNum, maxRow);
        }
        else if (finalResult == maxCol)
        {
            Console.WriteLine("COLUMN[{0}] = {1:0.00}", maxColNum, maxCol);
        }
        else if (finalResult == resultLeftD)
        {
            Console.WriteLine("LEFT-DIAGONAL = {1:0.00}", resultLeftD);
        }
        else
        {
            Console.WriteLine("RIGHT-DIAGONAL = {1:0.00}", resultRightD);
        }


        //write the matrix
        /*for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                Console.Write(matrix[row,col]+ " ");
            }
            Console.WriteLine();
        }*/

    }
}