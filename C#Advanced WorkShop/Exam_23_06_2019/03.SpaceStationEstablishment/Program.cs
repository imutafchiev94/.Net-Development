using System;

namespace _03.SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];

            int shipsRow = 0;

            int shipsCol = 0;

            int firstBlackHoleRow = -1;

            int firstdBlackHoleCol = -1;

            int secondBlackHoleRow = -1;

            int secondBlackHoleCol = -1;

            bool isShipInVoid = false;

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    if(row[j] == 'S')
                    {
                        shipsRow = i;
                        shipsCol = j;
                    }
                    if(row[j] == 'O')
                    {
                        if(firstBlackHoleRow < 0)
                        {
                            firstBlackHoleRow = i;
                            firstdBlackHoleCol = j;
                        }
                        else
                        {
                            secondBlackHoleRow = i;
                            secondBlackHoleCol = j;
                        }
                    }
                    field[i, j] = row[j];
                }
            }

            int starPower = 0;

            

            while(!isShipInVoid && starPower < 50)
            {
                var commands = Console.ReadLine();

                switch(commands)
                {
                    case "up":
                        {
                            if(shipsRow == 0)   
                            {
                                field[shipsRow, shipsCol] = '-';

                                isShipInVoid = true;
                            }
                            else
                            {
                                if(shipsRow - 1 == firstBlackHoleRow && shipsCol == firstdBlackHoleCol)
                                {
                                    field[shipsRow - 1, shipsCol] = '-';
                                    field[shipsRow, shipsCol] = '-';
                                    field[secondBlackHoleRow, secondBlackHoleCol] = 'S';
                                    shipsRow = secondBlackHoleRow;
                                    shipsCol = secondBlackHoleCol;
                                }
                                else if (shipsRow - 1 == secondBlackHoleRow && shipsCol == secondBlackHoleCol)
                                {
                                    field[shipsRow - 1, shipsCol] = '-';
                                    field[shipsRow, shipsCol] = '-';
                                    field[firstBlackHoleRow, firstdBlackHoleCol] = 'S';
                                    shipsRow = firstBlackHoleRow;
                                    shipsCol = firstdBlackHoleCol;
                                }

                                else if (field[shipsRow - 1, shipsCol] != '-' && field[shipsRow - 1, shipsCol] != 'O')
                                {
                                    starPower += (field[shipsRow - 1, shipsCol] - '0');
                                    field[shipsRow, shipsCol] = '-';
                                    field[shipsRow - 1, shipsCol] = 'S';
                                    shipsRow--;
                                }

                                else if (field[shipsRow - 1, shipsCol] == '-')
                                {
                                    field[shipsRow, shipsCol] = '-';
                                    field[shipsRow - 1, shipsCol] = 'S';
                                    shipsRow--;
                                }
                            }

                            break;
                        }
                    case "down":
                        {
                            if (shipsRow == n - 1)
                            {
                                field[shipsRow, shipsCol] = '-';

                                isShipInVoid = true;
                            }
                            else
                            {
                                if (shipsRow + 1 == firstBlackHoleRow && shipsCol == firstdBlackHoleCol)
                                {
                                    field[shipsRow + 1, shipsCol] = '-';
                                    field[shipsRow, shipsCol] = '-';
                                    field[secondBlackHoleRow, secondBlackHoleCol] = 'S';
                                    shipsRow = secondBlackHoleRow;
                                    shipsCol = secondBlackHoleCol;
                                }
                                else if (shipsRow + 1 == secondBlackHoleRow && shipsCol == secondBlackHoleCol)
                                {
                                    field[shipsRow + 1, shipsCol] = '-';
                                    field[shipsRow, shipsCol] = '-';
                                    field[firstBlackHoleRow, firstdBlackHoleCol] = 'S';
                                    shipsRow = firstBlackHoleRow;
                                    shipsCol = firstdBlackHoleCol;
                                }

                                else if (field[shipsRow + 1, shipsCol] != '-' && field[shipsRow + 1, shipsCol] != 'O')
                                {
                                    starPower += (field[shipsRow + 1, shipsCol] - '0');
                                    field[shipsRow, shipsCol] = '-';
                                    field[shipsRow + 1, shipsCol] = 'S';
                                    shipsRow++;
                                }

                                else if (field[shipsRow + 1, shipsCol] == '-')
                                {
                                    field[shipsRow, shipsCol] = '-';
                                    field[shipsRow + 1, shipsCol] = 'S';
                                    shipsRow++;
                                }
                            }


                            break;
                        }
                    case "right":
                        {
                            if (shipsCol == n - 1)
                            {
                                field[shipsRow, shipsCol] = '-';

                                isShipInVoid = true;
                            }
                            else
                            {
                                if (shipsRow == firstBlackHoleRow && shipsCol + 1 == firstdBlackHoleCol)
                                {
                                    field[shipsRow, shipsCol + 1] = '-';
                                    field[shipsRow, shipsCol] = '-';
                                    field[secondBlackHoleRow, secondBlackHoleCol] = 'S';
                                    shipsRow = secondBlackHoleRow;
                                    shipsCol = secondBlackHoleCol;
                                }
                                else if (shipsRow == secondBlackHoleRow && shipsCol + 1 == secondBlackHoleCol)
                                {
                                    field[shipsRow, shipsCol + 1] = '-';
                                    field[shipsRow, shipsCol] = '-';
                                    field[firstBlackHoleRow, firstdBlackHoleCol] = 'S';
                                    shipsRow = firstBlackHoleRow;
                                    shipsCol = firstdBlackHoleCol;
                                }

                                else if (field[shipsRow, shipsCol + 1] != '-' && field[shipsRow, shipsCol + 1] != 'O')
                                {
                                    starPower += (field[shipsRow, shipsCol + 1] - '0');
                                    field[shipsRow, shipsCol] = '-';
                                    field[shipsRow, shipsCol + 1] = 'S';
                                    shipsCol++;
                                }

                                else if (field[shipsRow, shipsCol + 1] == '-')
                                {
                                    field[shipsRow, shipsCol] = '-';
                                    field[shipsRow, shipsCol + 1] = 'S';
                                    shipsCol++;
                                }
                            }


                            break;
                        }
                    case "left":
                        {
                            if (shipsCol == 0)
                            {
                                field[shipsRow, shipsCol] = '-';

                                isShipInVoid = true;
                            }
                            else
                            {
                                if (shipsRow == firstBlackHoleRow && shipsCol - 1 == firstdBlackHoleCol)
                                {
                                    field[shipsRow, shipsCol - 1] = '-';
                                    field[shipsRow, shipsCol] = '-';
                                    field[secondBlackHoleRow, secondBlackHoleCol] = 'S';
                                    shipsRow = secondBlackHoleRow;
                                    shipsCol = secondBlackHoleCol;
                                }
                                else if (shipsRow == secondBlackHoleRow && shipsCol - 1 == secondBlackHoleCol)
                                {
                                    field[shipsRow, shipsCol - 1] = '-';
                                    field[shipsRow, shipsCol] = '-';
                                    field[firstBlackHoleRow, firstdBlackHoleCol] = 'S';
                                    shipsRow = firstBlackHoleRow;
                                    shipsCol = firstdBlackHoleCol;
                                }

                                else if (field[shipsRow, shipsCol - 1] != '-' && field[shipsRow, shipsCol - 1] != 'O')
                                {
                                    starPower += (field[shipsRow, shipsCol - 1] - '0');
                                    field[shipsRow, shipsCol] = '-';
                                    field[shipsRow, shipsCol - 1] = 'S';
                                    shipsCol--;
                                }

                                else if (field[shipsRow, shipsCol - 1] == '-')
                                {
                                    field[shipsRow, shipsCol] = '-';
                                    field[shipsRow, shipsCol - 1] = 'S';
                                    shipsCol--;
                                }
                            }

                            break;
                        }
                }

            }

            if(!isShipInVoid)
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }
            else
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }

            Console.WriteLine($"Star power collected: {starPower}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
