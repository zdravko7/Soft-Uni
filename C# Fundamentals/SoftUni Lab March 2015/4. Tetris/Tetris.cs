using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Tetris
    {
        static void Main(string[] args)
        {
            string inputRowCol = Console.ReadLine();
            string[] inputArray = inputRowCol.Split();

            int rowSize = int.Parse(inputArray[0]);
            int colSize = int.Parse(inputArray[1]);

            char[,] matrix = new char[rowSize, colSize];

            for (int row = 0; row < rowSize; row++)
            {
                string input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    matrix[row, i] = input[i];
                }
            }

            //checks the whole matrix

            int iCounter = 0;
            int lCounter = 0;
            int jCounter = 0;
            int oCounter = 0;
            int zCounter = 0;
            int sCounter = 0;
            int tCounter = 0;


            for (int row = 0; row < rowSize; row++)
            {
                for (int col = 0; col < colSize; col++)
                {
                    if (matrix[row, col] == 'o')
                    {
                        //main logic here

                        //checks I
                        if (row < (rowSize - 3) && (matrix[row,col] == matrix[row+1,col]) && (matrix[row+1,col] == (matrix[row+2,col])) && (matrix[row+2,col] == matrix[row+3,col]))
                        {
                            iCounter++;
                        }
                        //checks L
                        if (row < (rowSize - 2) && (col < colSize-1) && (matrix[row,col] == matrix[row+1,col]) && (matrix[row,col] == (matrix[row+2,col])) && (matrix[row,col] == matrix[row+2, col+1]))
                        {
                            lCounter++;
                        }
                        //checks J
                        if (row < (rowSize - 2) && (matrix[row, col] == matrix[row + 1, col]) && (matrix[row + 1, col] == (matrix[row + 2, col])) && (matrix[row + 2, col] == matrix[row + 2, col-1]))
                        {
                            jCounter++;
                        }
                        //checks O
                        if (row < (rowSize - 1) && (col < colSize - 1) && (matrix[row, col] == matrix[row, col + 1]) && (matrix[row, col] == matrix[row + 1, col]) && (matrix[row, col] == matrix[row + 1, col + 1]))
                        {
                            oCounter++;
                        }
                        //checks Z
                        if ((row < (rowSize - 1)) && (col < colSize - 2) && (matrix[row, col] == matrix[row, col + 1]) && (matrix[row, col] == matrix[row+1, col + 1]) && (matrix[row, col] == matrix[row+1, col + 2]))
                        {
                            zCounter++;
                        }
                        //checks S
                        if ((row < rowSize - 1) && (col - 1 >= 0) && (col < colSize - 1) && (matrix[row, col] == matrix[row, col + 1]) && (matrix[row, col] == matrix[row + 1, col]) && (matrix[row, col] == matrix[row + 1, col - 1]))
                        {
                            sCounter++;
                        }
                        //T
                        if ((row < rowSize-1) && (col < colSize -2) && (matrix[row, col] == matrix[row, col+1]) && (matrix[row, col] == matrix[row, col + 2]) && (matrix[row, col] == matrix[row+1, col + 1]))
                        {
                            tCounter++;
                        }

                        /*if ((row > 0) && (col <= colSize - 2) && (matrix[row, col] == matrix[row, col + 1]) && (matrix[row, col] == matrix[row-1, col + 1]) && (matrix[row, col] == matrix[row - 1, col + 2]))
                        {
                            sCounter++;
                        }*/

                    }
                }
            }
            Console.WriteLine("I:{0}, L:{1}, J:{2}, O:{3}, Z:{4}, S:{5}, T:{6}", iCounter, lCounter, jCounter, oCounter, zCounter, sCounter, tCounter);


           /* for (int row = 0; row < rowSize; row++)
            {
                for (int col = 0; col < colSize; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }*/
        }
    }
