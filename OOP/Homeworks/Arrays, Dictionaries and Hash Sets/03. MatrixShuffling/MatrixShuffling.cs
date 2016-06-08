using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixShuffling
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];

            //creates matrix
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }
            Console.WriteLine();
            //operations
            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "END")
                    break;

                if (input[0] != "swap" || input.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine();
                    continue;
                }

                int x1 = int.Parse(input[1]);
                int x2 = int.Parse(input[2]);
                int y1 = int.Parse(input[3]);
                int y2 = int.Parse(input[4]);

                //swap operation
                try
                {
                    string temp = matrix[x1, x2];
                    matrix[x1, x2] = matrix[y1, y2];
                    matrix[y1, y2] = temp;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
                
                PrintMatrix(matrix);
                Console.WriteLine();
            }            
        }

        public static void PrintMatrix(string[,] matrix)
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
