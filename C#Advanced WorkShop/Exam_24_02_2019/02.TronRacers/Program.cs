using System;
using System.Linq;

namespace _02.TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];

            int firstPlayerRow = 0;

            int firstPlayerCol = 0;

            int secondPlayerRow = 0;

            int secondPlayerCol = 0;

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    field[i, j] = row[j];

                    if(row[j] == 'f')
                    {
                        firstPlayerRow = i;
                        firstPlayerCol = j;
                    }
                    else if(row[j] == 's')
                    {
                        secondPlayerRow = i;
                        secondPlayerCol = j;
                    }
                }
            }

            var command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            while(true)
            {
                var firstPlayerCommand = command[0];
                var secondPlayerCommand = command[1];

                switch(firstPlayerCommand)
                {
                    case "up":
                        {

                            if(firstPlayerRow == 0)
                            {
                                if (field[n - 1, firstPlayerCol] == 's')
                                {
                                    field[n - 1, firstPlayerCol] = 'x';

                                    firstPlayerRow = n - 1;

                                    break;
                                }
                                else
                                {
                                    firstPlayerRow = n - 1;

                                    field[firstPlayerRow, firstPlayerCol] = 'f';
                                }
                            }
                            else
                            {
                                if (field[firstPlayerRow - 1, firstPlayerCol] == 's')
                                {
                                    field[firstPlayerRow - 1, firstPlayerCol] = 'x';

                                    firstPlayerRow--;

                                    break;
                                }
                                else
                                {
                                    firstPlayerRow--;

                                    field[firstPlayerRow, firstPlayerCol] = 'f';
                                }
                            }

                            break;
                        }

                    case "down":
                        {
                            if (firstPlayerRow == n - 1)
                            {
                                if (field[0, firstPlayerCol] == 's')
                                {
                                    field[0, firstPlayerCol] = 'x';

                                    firstPlayerRow = 0;

                                    break;
                                }
                                else
                                {
                                    firstPlayerRow = 0;

                                    field[firstPlayerRow, firstPlayerCol] = 'f';
                                }
                            }
                            else
                            {
                                if (field[firstPlayerRow + 1, firstPlayerCol] == 's')
                                {
                                    field[firstPlayerRow + 1, firstPlayerCol] = 'x';

                                    firstPlayerRow++;

                                    break;
                                }
                                else
                                {
                                    firstPlayerRow++;

                                    field[firstPlayerRow, firstPlayerCol] = 'f';
                                }
                            }

                            break;
                        }
                    case "right":
                        {
                            if (firstPlayerCol == n - 1)
                            {
                                if (field[firstPlayerRow, 0] == 's')
                                {
                                    field[firstPlayerRow, 0] = 'x';

                                    firstPlayerCol = 0;

                                    break;
                                }
                                else
                                {
                                    firstPlayerCol = 0;

                                    field[firstPlayerRow, firstPlayerCol] = 'f';
                                }
                            }
                            else
                            {
                                if (field[firstPlayerRow, firstPlayerCol + 1] == 's')
                                {
                                    field[firstPlayerRow, firstPlayerCol + 1] = 'x';

                                    firstPlayerCol++;

                                    break;
                                }
                                else
                                {
                                    firstPlayerCol++;

                                    field[firstPlayerRow, firstPlayerCol] = 'f';
                                }
                            }

                            break;
                        }
                    case "left":
                        {
                            if (firstPlayerCol == 0)
                            {
                                if (field[firstPlayerRow, n - 1] == 's')
                                {
                                    field[firstPlayerRow, n - 1] = 'x';

                                    firstPlayerCol = n - 1;

                                    break;
                                }
                                else
                                {
                                    firstPlayerCol = n - 1;

                                    field[firstPlayerRow, firstPlayerCol] = 'f';
                                }
                            }
                            else
                            {
                                if (field[firstPlayerRow, firstPlayerCol - 1] == 's')
                                {
                                    field[firstPlayerRow, firstPlayerCol - 1] = 'x';

                                    firstPlayerCol--;

                                    break;
                                }
                                else
                                {
                                    firstPlayerCol--;

                                    field[firstPlayerRow, firstPlayerCol] = 'f';
                                }
                            }

                            break;
                        }
                }

                if (field[firstPlayerRow, firstPlayerCol] != 'x')
                {
                    switch (secondPlayerCommand)
                    {
                        case "up":
                            {

                                if (secondPlayerRow == 0)
                                {
                                    if (field[n - 1, secondPlayerCol] == 'f')
                                    {
                                        field[n - 1, secondPlayerCol] = 'x';

                                        secondPlayerRow = n - 1;

                                        break;
                                    }
                                    else
                                    {
                                        secondPlayerRow = n - 1;

                                        field[secondPlayerRow, secondPlayerCol] = 's';
                                    }
                                }
                                else
                                {
                                    if (field[secondPlayerRow - 1, secondPlayerCol] == 'f')
                                    {
                                        field[secondPlayerRow - 1, secondPlayerCol] = 'x';

                                        secondPlayerRow--;

                                        break;
                                    }
                                    else
                                    {
                                        secondPlayerRow--;

                                        field[secondPlayerRow, secondPlayerCol] = 's';
                                    }
                                }

                                break;
                            }

                        case "down":
                            {
                                if (secondPlayerRow == n - 1)
                                {
                                    if (field[0, secondPlayerCol] == 'f')
                                    {
                                        field[0, secondPlayerCol] = 'x';

                                        secondPlayerRow = 0;

                                        break;
                                    }
                                    else
                                    {
                                        secondPlayerRow = 0;

                                        field[secondPlayerRow, secondPlayerCol] = 's';
                                    }
                                }
                                else
                                {
                                    if (field[secondPlayerRow + 1, secondPlayerCol] == 'f')
                                    {
                                        field[secondPlayerRow + 1, secondPlayerCol] = 'x';

                                        secondPlayerRow++;

                                        break;
                                    }
                                    else
                                    {
                                        secondPlayerRow++;

                                        field[secondPlayerRow, secondPlayerCol] = 's';
                                    }
                                }

                                break;
                            }
                        case "right":
                            {
                                if (secondPlayerCol == n - 1)
                                {
                                    if (field[secondPlayerRow, 0] == 'f')
                                    {
                                        field[secondPlayerRow, 0] = 'x';

                                        secondPlayerCol = 0;

                                        break;
                                    }
                                    else
                                    {
                                        secondPlayerCol = 0;

                                        field[secondPlayerRow, secondPlayerCol] = 's';
                                    }
                                }
                                else
                                {
                                    if (field[secondPlayerRow, secondPlayerCol + 1] == 'f')
                                    {
                                        field[secondPlayerRow, secondPlayerCol + 1] = 'x';

                                        secondPlayerCol++;

                                        break;
                                    }
                                    else
                                    {
                                        secondPlayerCol++;

                                        field[secondPlayerRow, secondPlayerCol] = 's';
                                    }
                                }

                                break;
                            }
                        case "left":
                            {
                                if (secondPlayerCol == 0)
                                {
                                    if (field[secondPlayerRow, n - 1] == 'f')
                                    {
                                        field[secondPlayerRow, n - 1] = 'x';

                                        secondPlayerCol = n - 1;

                                        break;
                                    }
                                    else
                                    {
                                        secondPlayerCol = n - 1;

                                        field[secondPlayerRow, secondPlayerCol] = 's';
                                    }
                                }
                                else
                                {
                                    if (field[secondPlayerRow, secondPlayerCol - 1] == 'f')
                                    {
                                        field[secondPlayerRow, secondPlayerCol - 1] = 'x';

                                        secondPlayerCol--;

                                        break;
                                    }
                                    else
                                    {
                                        secondPlayerCol--;

                                        field[secondPlayerRow, secondPlayerCol] = 's';
                                    }
                                }

                                break;
                            }
                    }
                }

                //Console.WriteLine();

                //for (int i = 0; i < n; i++)
                //{
                //    for (int j = 0; j < n; j++)
                //    {
                //        Console.Write(field[i, j]);
                //    }

                //    Console.WriteLine();
                //}

                if(field[secondPlayerRow, secondPlayerCol] == 'x' || field[firstPlayerRow, firstPlayerCol] == 'x')
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(field[i, j]);
                        }

                        Console.WriteLine();
                    }

                    break;
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

        }
    }
}
