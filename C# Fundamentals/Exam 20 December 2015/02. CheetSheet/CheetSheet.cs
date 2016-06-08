using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class CheetSheet

    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int verticalStart = int.Parse(Console.ReadLine());
            int horizontalStart = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = new BigInteger[500, 500];

            //generates the whol matrix
            for (int row = 0; row < 500; row++)
            {
                for (int col = 0; col < 500; col++)
                {
                    if (row == 0)
                    {
                        matrix[row, col] = (col + 1);
                    }
                    else
                    {
                        //int temp = matrix[row, col];
                        //int temp2 = matrix[0, col];
                        matrix[row, col] = ((matrix[row, col] +row) * col);
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[verticalStart,horizontalStart] + " ");
                    horizontalStart++;
                    
                }
                Console.WriteLine();
                verticalStart++;

            }




           /* for (int row = verticalStart; row < (verticalStart + rows) ; row++)
            {
                for (int col = horizontalStart; col < (horizontalStart + cols); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
                
            }*/

        }
    }