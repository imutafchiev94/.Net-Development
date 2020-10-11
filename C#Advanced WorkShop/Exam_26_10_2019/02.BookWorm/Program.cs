using System;

namespace _02.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];

            int playersRow = 0;

            int playersCol = 0;

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    field[i, j] = row[j];
                    if(row[j] == 'P')
                    {
                        playersCol = j;
                        playersRow = i;
                    }
                }
            }

            var command = Console.ReadLine();

            while(command != "end")
            {
                switch(command)
                {
                    case "up":
                        {
                            if(playersRow == 0)
                            {
                                if(word.Length != 0)
                                {
                                   word = word.Remove(word.Length - 1, 1);
                                }
                            }
                            else
                            {
                                if (field[playersRow - 1, playersCol] != '-')
                                {
                                    word += field[playersRow - 1, playersCol].ToString();
                                    field[playersRow - 1, playersCol] = 'P';
                                    field[playersRow, playersCol] = '-';
                                    playersRow--;
                                }
                                else
                                {
                                    field[playersRow - 1, playersCol] = 'P';
                                    field[playersRow, playersCol] = '-';
                                    playersRow--;
                                }
                            }

                            break;
                        }
                    case "down":
                        {
                            if (playersRow == n - 1)
                            {
                                if (word.Length != 0)
                                {
                                   word = word.Remove(word.Length - 1, 1);
                                }
                            }
                            else
                            {
                                if (field[playersRow + 1, playersCol] != '-')
                                {
                                    word += field[playersRow + 1, playersCol].ToString();
                                    field[playersRow + 1, playersCol] = 'P';
                                    field[playersRow, playersCol] = '-';
                                    playersRow++;
                                }
                                else
                                {
                                    field[playersRow + 1, playersCol] = 'P';
                                    field[playersRow, playersCol] = '-';
                                    playersRow++;
                                }
                            }

                            break;
                        }
                    case "right":
                        {
                            if (playersCol == n - 1)
                            {
                                if (word.Length != 0)
                                {
                                   word = word.Remove(word.Length - 1, 1);
                                }
                            }
                            else
                            {
                                if (field[playersRow, playersCol + 1] != '-')
                                {
                                    word += field[playersRow, playersCol + 1].ToString();
                                    field[playersRow, playersCol + 1] = 'P';
                                    field[playersRow, playersCol] = '-';
                                    playersCol++;
                                }
                                else
                                {
                                    field[playersRow, playersCol + 1] = 'P';
                                    field[playersRow, playersCol] = '-';
                                    playersCol++;
                                }
                            }

                            break;
                        }
                    case "left":
                        {
                            if (playersCol == 0)
                            {
                                if (word.Length != 0)
                                {
                                    word = word.Remove(word.Length - 1, 1);
                                }
                            }
                            else
                            {
                                if (field[playersRow, playersCol - 1] != '-')
                                {
                                    word += field[playersRow, playersCol - 1].ToString();
                                    field[playersRow, playersCol - 1] = 'P';
                                    field[playersRow, playersCol] = '-';
                                    playersCol --;
                                }
                                else
                                {
                                    field[playersRow, playersCol - 1] = 'P';
                                    field[playersRow, playersCol] = '-';
                                    playersCol--;
                                }
                            }

                            break;
                        }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(word);

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
