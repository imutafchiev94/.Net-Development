using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ExcelFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var row = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string[,] matrix = new string[n, row.Length];

            int count = 0;

            while(count != n)
            {
                for (int cols = 0; cols < row.Length; cols++)
                {
                    matrix[count, cols] = row[cols];
                }

                
                count++;
                if(count <= n - 1)
                {
                    row = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                }
            }

            var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();


            switch(command[0])
            {
                case "hide":
                    {
                        matrix = Hide(command[1], n, row.Length, matrix);

                        for (int rows = 0; rows < n; rows++)
                        {
                            for (int cols = 0; cols < row.Length - 1; cols++)
                            {
                                if(cols < row.Length - 2)
                                {
                                    Console.Write(matrix[rows, cols] + " | ");
                                }
                                else
                                {
                                    Console.WriteLine(matrix[rows, cols]);
                                }
                            }
                        }
                        break;
                    }
                case "sort":
                    {
                        matrix = Sort(command[1], n, row.Length, matrix);

                        for (int rows = 0; rows < n; rows++)
                        {
                            for (int cols = 0; cols < row.Length; cols++)
                            {
                                if (cols < row.Length - 1)
                                {
                                    Console.Write(matrix[rows, cols] + " | ");
                                }
                                else
                                {
                                    Console.WriteLine(matrix[rows, cols]);
                                }
                            }
                        }

                        break;
                    }
                case "filter":
                    {
                        matrix = Filter(command[1], command[2], n, row.Length, matrix);

                        for (int rows = 0; rows < matrix.GetLength(0); rows++)
                        {
                            for (int cols = 0; cols < matrix.GetLength(1); cols++)
                            {
                                if (cols < matrix.GetLength(1) - 1)
                                {
                                    Console.Write(matrix[rows, cols] + " | ");
                                }
                                else
                                {
                                    Console.WriteLine(matrix[rows, cols]);
                                }
                            }
                        }

                        break;
                    }
            }

            string[,] Hide(string header, int rows, int cols, string[,] field)
            {
                var index = 0;
                string[,] finalField = new string[rows, cols - 1];

                for (int col = 0; col < cols; col++)
                {
                    if (field[0, col] == header)
                    {
                        index = col;
                    }
                }

               
                for (int row = 0; row < rows; row++)
                {
                    var counter = 0;
                    for (int col = 0; col < cols; col++)
                    {
                        if(index != col)
                        {
                            finalField[row, counter] = field[row, col];
                            counter++;
                        }
                    }
                }
                return finalField;
            }

            string[,] Sort(string header, int rows, int cols, string[,] field)
            {
                var index = 0;
                string[,] finalField = new string[rows, cols];
                List<string> fields = new List<string>();

                for (int col = 0; col < cols; col++)
                {
                    if (field[0, col] == header)
                    {
                        index = col;
                    }
                }


                for (int row = 1; row < rows; row++)
                {
                    
                    for (int col = 0; col < cols; col++)
                    {
                        if(index == col)
                        {
                            fields.Add(field[row, col]);
                        }
                    }
                }

                var counter = 1;
                foreach (var item in fields.OrderBy(x => x))
                {
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            if (row > 0)
                            {
                                if (index == col)
                                {
                                    if (field[row, col] == item)
                                    {
                                        for (int i = 0; i < cols; i++)
                                        {
                                            finalField[counter, i] = field[row, i];
                                        }
                                        counter++;
                                    }
                                }
                            }
                            else
                            {
                                finalField[0, col] = field[0, col];
                            }
                            
                        }
                    }
                }

                return finalField;
            }
            string[,] Filter(string header, string value, int rows, int cols, string[,] field)
            {
                var index = 0;


                for (int col = 0; col < cols; col++)
                {
                    if (field[0, col] == header)
                    {
                        index = col;
                    }
                }

                var count = 1;
                for (int row = 1; row < rows; row++)
                {

                    for (int col = 0; col < cols; col++)
                    {
                        if (index == col)
                        {
                            if (field[row, col] == value)
                            {
                                count++;
                            }
                        }
                    }
                }

                var finalField = new string[count, cols];

                for (int row = 0; row < rows; row++)
                {

                    for (int col = 0; col < cols; col++)
                    {
                        if (row > 0)
                        {
                            if (index == col)
                            {
                                if (field[row, col] == value)
                                {
                                    for (int j = 1; j < count; j++)
                                    {
                                        for (int i = 0; i < cols; i++)
                                        {
                                            finalField[j, i] = field[row, i];
                                        }
                                    }
                                    
                                }
                            }
                        }
                        else
                        {
                            finalField[0, col] = field[0, col];
                        }
                    }
                }

                return finalField;
            }
        }

    }
}
