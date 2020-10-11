using System;
using System.Linq;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rows = input[0];
            var cols = input[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var row = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            var command = Console.ReadLine().Split().ToArray();

            while(command[0] != "END")
            {

                if (command.Length < 5 || command.Length > 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    var row1 = int.Parse(command[1]);
                    var col1 = int.Parse(command[2]);
                    var row2 = int.Parse(command[3]);
                    var col2 = int.Parse(command[4]);

                    if (command[0] != "swap" || row1 > rows || row2 > rows || col1 > cols || col2 > cols || row1 < 0 || row2 < 0 || col1 < 0 || col2 < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    else
                    {
                        string num = matrix[row1, col1];

                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = num;

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                if (j == cols - 1)
                                {
                                    Console.WriteLine(matrix[i, j]);
                                }
                                else
                                {
                                    Console.Write(matrix[i, j] + " ");
                                }

                            }
                        }
                    }
                }

                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
