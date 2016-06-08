using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    class Parachute
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[40,40];
            int rowCount = 0;
            //input
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                    break;

                for (int i = 0; i < input.Length; i++)
                {
                    matrix[rowCount, i] = input[i];
                }
                rowCount++;
            }

            //movement
            int moveLeft = 0;
            int moveRight = 0;
            bool finished = false;

            int[] jumperLocation = FindJumper(matrix);

            for (int row = jumperLocation[0]+1; row < matrix.GetLength(0); row++)
            {
                    jumperLocation[0]++;

                    //check for wind
                    for (int wind = 0; wind < matrix.GetLength(1); wind++)
                    {
                        if (matrix[row, wind] == '>')
                        {
                            moveRight++;
                        }
                        else if (matrix[row, wind] == '<')
                        {
                            moveLeft++;
                        }
                    }

                    int finalMovement = moveRight - moveLeft;

                    jumperLocation[1] += finalMovement;

                    switch (matrix[jumperLocation[0], jumperLocation[1]])
                    {
                        case '_':
                            Console.WriteLine("Landed on the ground like a boss!");
                            Console.WriteLine(jumperLocation[0] + " " + jumperLocation[1]);
                            finished = true;
                            break;

                        case '~':
                            Console.WriteLine("Drowned in the water like a cat!");
                            Console.WriteLine(jumperLocation[0] + " " + jumperLocation[1]);
                            finished = true;
                            break;

                        case '/':
                            Console.WriteLine("Got smacked on the rock like a dog!");
                            Console.WriteLine(jumperLocation[0] + " " + jumperLocation[1]);
                            finished = true;
                            break;

                        case '|':
                            Console.WriteLine("Got smacked on the rock like a dog!");
                            Console.WriteLine(jumperLocation[0] + " " + jumperLocation[1]);
                            finished = true;
                            break;

                        case '\\':
                            Console.WriteLine("Got smacked on the rock like a dog!");
                            Console.WriteLine(jumperLocation[0] + " " + jumperLocation[1]);
                            finished = true;
                            break;
                    }

                    if (finished == true)
                        break;

                    //resets movement
                    moveLeft = 0;
                    moveRight = 0;
                   
            }
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static int[] FindJumper(char[,] matrix)
        {
            int[] result = new int[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'o')
                    {
                        result[0] = row;
                        result[1] = col;
                        return result;
                    }
                }        
            }

            return result;
        }
    }
}
