using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(p => int.Parse(p)).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(p => int.Parse(p)).ToArray();

                for (int i = 0; i < input.Length; i++)
                {
                    matrix[row, i] = input[i];
                }
            }

            int currentSum = 0;
            int maxSum = int.MinValue;

            int[,] biggestMatrix = new int[3, 3];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    try
                    {
                        currentSum += matrix[row, col] + matrix[row, col+1] + matrix[row, col+2] + matrix[row+1, col] + matrix[row+1, col+1] + matrix[row+1, col+2]
                           + matrix[row + 2, col] + matrix[row+2, col + 1] + matrix[row+2, col+2];

                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;

                            biggestMatrix[0,0] = matrix[row, col];
                            biggestMatrix[0,1] = matrix[row, col+1];
                            biggestMatrix[0,2] = matrix[row, col+2];
                            biggestMatrix[1,0] = matrix[row+1, col];
                            biggestMatrix[1,1] = matrix[row+1, col+1];
                            biggestMatrix[1,2] = matrix[row+1, col+2];
                            biggestMatrix[2,0] = matrix[row+2, col];
                            biggestMatrix[2,1] = matrix[row+2, col+1];
                            biggestMatrix[2,2] = matrix[row+2, col+2];

                        }
                        currentSum = 0;
                    }
                    catch (Exception) { };
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum = " + maxSum);
            PrintMatrix(biggestMatrix);


        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
