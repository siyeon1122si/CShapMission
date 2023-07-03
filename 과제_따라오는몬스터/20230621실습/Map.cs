using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mission_230619
{
    public class Map
    {
        int count = 0;
        int pointX = 9;
        int pointY = 6;

        public void MapOpen()
        {

            int enemycount = 0;
            int[] enemyrandX = new int[50];
            int[] enemyrandY = new int[50];
            Console.CursorVisible = false;
            char[,] map = new char[13, 19];

            Random random = new Random();

            for (int k = 0; k < 30; k++)
            {
                int randX = random.Next(0, 18);
                int randY = random.Next(0, 12);

                map[randY, randX] = '□';

                if (map[randY, randX] == map[6, 9])
                {
                    k = 0;
                }

            }


            while (true)
            {

                Console.SetCursorPosition(0, 0);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("                              ☆ SCORE : {0} ☆", count);
                Console.WriteLine();
                Console.WriteLine();
                Console.ResetColor();

                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 19; j++)
                    {
                        if (i == pointY && j == pointX) // 유저 하트 출력
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" ♡ ");
                            Console.ResetColor();
                        }

                        else if (i == 0)  // 외부 벽 출력1 
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
                            Console.ResetColor();
                        }

                        else if (i == 12) // 외부 벽 출력2
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
                            Console.ResetColor();
                        }

                        else if (j == 0 && i > 0 && i < 12) // 외부 벽 출력3
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
                            Console.ResetColor();
                        }

                        else if (j == 18 && i > 0 && i < 12) // 외부 벽 출력4
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
                            Console.ResetColor();
                        }

                        else if (map[i, j] == '●')
                        {
                            map[i, j] = '●';
                            Console.Write(" ● ", map);
                        }

                        else if (map[i, j] == '□') // 내부 랜덤 벽 출력
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(" □ ");
                            Console.ResetColor();
                        }

                        else
                        {
                            map[i, j] = ' ';
                            Console.Write("    ", map[i, j]);
                        }

                    }
                    Console.WriteLine("\n");
                }


                if (count % 30 == 0)
                {
                    enemyrandX[enemycount] = random.Next(0, 18);
                    enemyrandY[enemycount] = random.Next(0, 12);

                    while (map[enemyrandY[enemycount], enemyrandX[enemycount]] == '♡' || map[enemyrandY[enemycount], enemyrandX[enemycount]] == '□')
                    {
                        enemyrandX[enemycount] = random.Next(0, 18);
                        enemyrandY[enemycount] = random.Next(0, 12);
                    }

                    map[enemyrandY[enemycount], enemyrandX[enemycount]] = '●';
                    enemycount++;
                }

                // 방향키로 이동 시 ♡ 
                map[pointY, pointX] = '♡';

                ConsoleKeyInfo userKey = Console.ReadKey(true);

                switch (userKey.Key)
                {
                    case ConsoleKey.D:

                        if (map[pointY, pointX + 1] == '●')
                        {
                            Console.WriteLine(" 죽었어용 아무거나 눌러서 나가세용 ㅋ");
                            Console.ReadLine();
                            Environment.Exit(0);
                            continue;
                        }
                        if (map[pointY, pointX + 1] != '□')
                        {
                            pointX++;
                            count++;
                        }

                            break;
                    case ConsoleKey.A:

                        if (map[pointY, pointX - 1] == '●')
                        {
                            Console.WriteLine(" 죽었어용 아무거나 눌러서 나가세용 ㅋ");
                            Console.ReadLine();
                            Environment.Exit(0);
                            continue;
                        }
                        if (map[pointY, pointX - 1] != '□')
                        {
                            pointX--;
                            count++;
                        }

                        break;
                    case ConsoleKey.W:

                        if (map[pointY - 1, pointX] == '●')
                        {
                            Console.WriteLine(" 죽었어용 아무거나 눌러서 나가세용 ㅋ");
                            Console.ReadLine();
                            Environment.Exit(0);
                            continue;
                        }
                        if (map[pointY - 1, pointX] != '□')
                        {
                            pointY--;
                            count++;
                        }

                        break;
                    case ConsoleKey.S:

                        if (map[pointY + 1, pointX] == '●')
                        {
                            Console.WriteLine(" 죽었어용 아무거나 눌러서 나가세용 ㅋ");
                            Console.ReadLine();
                            Environment.Exit(0);
                            continue;
                        }
                        if (map[pointY + 1, pointX] != '□')
                        {
                            pointY++;
                            count++;
                        }

                        break;
                    default:
                        break;
                }

                for (int i = 0; i < enemycount; i++)
                {
                    map[enemyrandY[i], enemyrandX[i]] = ' ';

                    if (enemyrandX[i] > pointX) // 적X > 내X
                    {
                        if (enemyrandY[i] > pointY) // 적Y > 내Y
                        {
                            if (map[enemyrandY[i], enemyrandX[i] - 1] == ' ')
                            {
                                enemyrandX[i]--; // 더 긴 쪽을 먼저 가겠다
                            }
                            if (map[enemyrandY[i] - 1, enemyrandX[i]] == ' ')
                            {
                                enemyrandY[i]--; // 더 긴 쪽을 먼저 가겠다
                            }
                        }

                        else if (enemyrandY[i] < pointY) // 적Y < 내Y
                        {
                            if (enemyrandX[i] - pointX > pointY - enemyrandY[i]) // 적X - 내X > 내Y - 적Y
                            {
                                if (map[enemyrandY[i], enemyrandX[i] - 1] == ' ')
                                {
                                    enemyrandX[i]--; // 더 긴 쪽을 먼저 가겠다
                                }
                            }
                            else if (enemyrandX[i] - pointX < pointY - enemyrandY[i]) // 적X - 내X < 내Y - 적Y
                            {
                                if (map[enemyrandY[i] + 1, enemyrandX[i]] == ' ')
                                {
                                    enemyrandY[i]++; // 더 긴 쪽을 먼저 가겠다
                                }
                            }
                        }
                    }

                    else if (enemyrandX[i] < pointX) // 적X < 내X
                    {

                        if (enemyrandY[i] > pointY) // 적Y > 내Y
                        {
                            if (pointX - enemyrandX[i] > enemyrandY[i] - pointY) // 내X - 적X > 적Y - 내Y
                            {
                                if (map[enemyrandY[i], enemyrandX[i] + 1] == ' ')
                                {
                                    enemyrandX[i]++; // 더 긴 쪽을 먼저 가겠다
                                }
                            }
                            else if (pointX - enemyrandX[i] < enemyrandY[i] - pointY) // 내X - 적X < 적Y - 내Y
                            {
                                if (map[enemyrandY[i] - 1, enemyrandX[i]] == ' ')
                                {
                                    enemyrandY[i]--; // 더 긴 쪽을 먼저 가겠다
                                }
                            }

                        }
                        else if (enemyrandY[i] < pointY) // 적Y < 내Y
                        {
                            if (pointX - enemyrandX[i] > pointY - enemyrandY[i]) // 적X - 내X > 내Y - 적Y
                            {
                                if (map[enemyrandY[i], enemyrandX[i] + 1] == ' ')
                                {
                                    enemyrandX[i]++; // 더 긴 쪽을 먼저 가겠다
                                }
                            }
                            else if (pointX - enemyrandX[i] < pointY - enemyrandY[i]) // 적X - 내X < 내Y - 적Y
                            {
                                if (map[enemyrandY[i] + 1, enemyrandX[i]] == ' ')
                                {
                                    enemyrandY[i]++; // 더 긴 쪽을 먼저 가겠다
                                }
                            }
                        }
                    }

                    else if(enemyrandX[i] == pointX)
                    {
                        if (enemyrandY[i] > pointY) // 적Y > 내Y
                        {
                            if (map[enemyrandY[i] - 1, enemyrandX[i]] == ' ')
                            {
                                enemyrandY[i]--; // 더 긴 쪽을 먼저 가겠다
                            }
                        }
                        else if (enemyrandY[i] < pointY) // 적Y < 내Y
                        {
                            if (map[enemyrandY[i] + 1, enemyrandX[i]] == ' ')
                            {
                                enemyrandY[i]++; // 더 긴 쪽을 먼저 가겠다
                            }
                        }
                    }
                    else if(enemyrandX[i] == pointY)
                    {
                        if (enemyrandX[i] > pointX)
                        {
                            if (map[enemyrandY[i], enemyrandX[i] - 1] == ' ')
                            {
                                enemyrandX[i]--; // 더 긴 쪽을 먼저 가겠다
                            }
                        }
                        else if (enemyrandX[i] < pointX)
                        {
                            if (map[enemyrandY[i],enemyrandX[i] + 1] == ' ')
                            {
                                enemyrandX[i]++; // 더 긴 쪽을 먼저 가겠다
                            }
                        }
                    }

                    map[enemyrandY[i], enemyrandX[i]] = '●';
                }

            } // while
        }
    }
}
