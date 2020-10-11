using System;
using System.Linq;

namespace _02.PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presents = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];

            int santasRow = 0;

            int santasCol = 0;

            int countOfNiceKids = 0;

            int niceKidsWithPresents = 0;

            for (int rows = 0; rows < n; rows++)
            {
                var row = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int cols = 0; cols < n; cols++)
                {
                    field[rows, cols] = row[cols][0];
                    if(row[cols][0] == 'S')
                    {
                        santasRow = rows;
                        santasCol = cols;
                    }
                    else if(row[cols][0] == 'V')
                    {
                        countOfNiceKids++;
                    }

                }
            }

            var command = Console.ReadLine();


            while (presents != 0 && command != "Christmas morning")
            {
                switch(command)
                {
                    case "up":
                        {
                            if(field[santasRow - 1, santasCol] == 'X')
                            {
                                field[santasRow, santasCol] = '-';
                                santasRow--;
                                field[santasRow, santasCol] = 'S';
                            }
                            else if(field[santasRow - 1, santasCol] == 'V')
                            {
                                field[santasRow, santasCol] = '-';
                                field[santasRow - 1, santasCol] = 'S';
                                santasRow--;
                                presents--;
                                niceKidsWithPresents++;
                            }
                            else if(field[santasRow - 1, santasCol] == 'C')
                            {
                                field[santasRow, santasCol] = '-';
                                field[santasRow - 1, santasCol] = 'S';
                                santasRow--;
                                var presentsAndKids = CheckUp(field, santasRow, santasCol, presents, niceKidsWithPresents);
                                presents = presentsAndKids[0];
                                niceKidsWithPresents = presentsAndKids[1];
                                presentsAndKids = CheckDown(field, santasRow, santasCol, presents, niceKidsWithPresents);
                                presents = presentsAndKids[0];
                                niceKidsWithPresents = presentsAndKids[1];
                                presentsAndKids = CheckLeft(field, santasRow, santasCol, presents, niceKidsWithPresents);
                                presents = presentsAndKids[0];
                                niceKidsWithPresents = presentsAndKids[1];
                                presentsAndKids = CheckRight(field, santasRow, santasCol, presents, niceKidsWithPresents);
                                presents = presentsAndKids[0];
                                niceKidsWithPresents = presentsAndKids[1];
                            }
                            else
                            {
                                field[santasRow - 1, santasCol] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasRow--;
                            }

                            break;
                        }
                    case "down":
                        {
                            if (field[santasRow + 1, santasCol] == 'X')
                            {
                                field[santasRow + 1, santasCol] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasRow++;
                            }
                            else if (field[santasRow + 1, santasCol] == 'V')
                            {
                                field[santasRow + 1, santasCol] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasRow++;
                                presents--;
                                niceKidsWithPresents++;
                            }
                            else if (field[santasRow + 1, santasCol] == 'C')
                            {
                                field[santasRow + 1, santasCol] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasRow++;
                                presents = CheckUp(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckUp(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                                presents = CheckDown(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckDown(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                                presents = CheckLeft(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckLeft(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                                presents = CheckRight(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckRight(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                            }
                            else
                            {
                                field[santasRow + 1, santasCol] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasRow++;
                            }

                            break;
                        }
                    case "left":
                        {
                            if (field[santasRow, santasCol - 1] == 'X')
                            {
                                field[santasRow, santasCol - 1] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasCol--;
                            }
                            else if (field[santasRow, santasCol - 1] == 'V')
                            {
                                field[santasRow, santasCol - 1] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasCol--;
                                presents--;
                                niceKidsWithPresents++;
                            }
                            else if (field[santasRow, santasCol - 1] == 'C')
                            {
                                field[santasRow, santasCol - 1] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasCol--;
                                presents = CheckUp(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckUp(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                                presents = CheckDown(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckDown(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                                presents = CheckLeft(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckLeft(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                                presents = CheckRight(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckRight(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                            }
                            else
                            {
                                field[santasRow, santasCol - 1] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasCol--;
                            }

                            break;
                        }
                    case "right":
                        {
                            if (field[santasRow, santasCol + 1] == 'X')
                            {
                                field[santasRow, santasCol + 1] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasCol++;
                            }
                            else if (field[santasRow, santasCol + 1] == 'V')
                            {
                                field[santasRow, santasCol + 1] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasCol++;
                                presents--;
                                niceKidsWithPresents++;
                            }
                            else if (field[santasRow, santasCol + 1] == 'C')
                            {
                                field[santasRow, santasCol + 1] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasCol++;
                                presents = CheckUp(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckUp(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                                presents = CheckDown(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckDown(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                                presents = CheckLeft(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckLeft(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                                presents = CheckRight(field, santasRow, santasCol, presents, niceKidsWithPresents)[0];
                                niceKidsWithPresents = CheckRight(field, santasRow, santasCol, presents, niceKidsWithPresents)[1];
                            }
                            else
                            {
                                field[santasRow, santasCol + 1] = 'S';
                                field[santasRow, santasCol] = '-';
                                santasCol++;
                            }

                            break;
                        }
                }

                if(presents == 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if(presents == 0)
            {
                Console.WriteLine("Santa ran out of presents!");
            }

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write(field[rows, cols] + " ");
                }
                Console.WriteLine();
            }

            if(countOfNiceKids - niceKidsWithPresents == 0)
            {
                Console.WriteLine($"Good job, Santa! {niceKidsWithPresents} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {countOfNiceKids - niceKidsWithPresents} nice kid/s.");
            }

            int[] CheckUp(char[,] field, int row, int col, int presents, int niceKids)
            {
                var presentsAndKids = new int[2];

                if (field[row - 1, col] == 'X')
                {
                    if (presents > 0)
                    {
                        field[row - 1, col] = '-';
                        presents--;
                    }
                }
                else if (field[row - 1, col] == 'V')
                {
                    if (presents > 0)
                    {
                        field[row - 1, col] = '-';
                        presents--;
                        niceKids++;
                    }
                }

                presentsAndKids[0] = presents;
                presentsAndKids[1] = niceKids;

                return presentsAndKids;
            }

            int[] CheckDown(char[,] field, int row, int col, int presents, int niceKids)
            {

                var presentsAndKids = new int[2];
                if (field[row + 1, col] == 'X')
                {
                    if (presents > 0)
                    {
                        field[row + 1, col] = '-';
                        presents--;
                    }
                }
                else if (field[row + 1, col] == 'V')
                {
                    if (presents > 0)
                    {
                        field[row + 1, col] = '-';
                        presents--;
                        niceKids++;
                    }
                }

                presentsAndKids[0] = presents;
                presentsAndKids[1] = niceKids;

                return presentsAndKids;
            }

            int[] CheckRight(char[,] field, int row, int col, int presents, int niceKids)
            {
                var presentsAndKids = new int[2];

                if (field[row, col + 1] == 'X')
                {
                    if (presents > 0)
                    {
                        field[row, col + 1] = '-';
                        presents--;
                    }
                }
                else if (field[row, col + 1] == 'V')
                {
                    if (presents > 0)
                    {
                        field[row, col + 1] = '-';
                        presents--;
                        niceKids++;
                    }
                }

                presentsAndKids[0] = presents;
                presentsAndKids[1] = niceKids;

                return presentsAndKids;
            }

            int[] CheckLeft(char[,] field, int row, int col, int presents, int niceKids)
            {
                var presentsAndKids = new int[2];

                if (field[row, col - 1] == 'X')
                {
                    if (presents > 0)
                    {
                        field[row, col - 1] = '-';
                        presents--;
                    }
                }
                else if (field[row, col - 1] == 'V')
                {
                    if (presents > 0)
                    {
                        field[row, col - 1] = '-';
                        presents--;
                        niceKids++;
                    }
                }

                presentsAndKids[0] = presents;
                presentsAndKids[1] = niceKids;

                return presentsAndKids;
            }
        }

    }
}

