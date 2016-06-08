using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];
            int counter = 1;

            //first matrix
            Console.WriteLine();
            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            PrintMatrix(matrix);
            Console.WriteLine();

            //resets matrix
            Array.Clear(matrix, 0, matrix.GetLength(0)*matrix.GetLength(1));

            //second matrix
            counter = 1;

            for (int col = 0; col < size; col++)
            {
                if (col % 2 != 0)
                {
                    counter += 3;
                }
                else if (col % 2 == 0 && col != 0)
                {
                    counter += 5;
                }

                for (int row = 0; row < size; row++)
                {       
                    if (col % 2 == 0)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                    else
                    {
                        matrix[row, col] = counter;
                        counter--;
                    }
                }
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
