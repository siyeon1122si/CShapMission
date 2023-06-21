using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_230619
{
    public class Map
    {
        int count = 1;
        int pointX = 6;
        int pointY = 6;

        public void MapOpen()
        {
            Console.CursorVisible = false;
            char[,] map = new char[13, 13];

            while (true)
            {
                Console.SetCursorPosition(0, 0);

                map[1, 6] = '◇';
                map[6, 1] = '◇';
                map[6, 11] = '◇';
                map[11, 6] = '◇';

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("                   ☆ {0} 번째 맵 ☆", count);
                Console.WriteLine();
                Console.WriteLine();
                Console.ResetColor();

                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 13; j++)
                    {
                        if (i == pointY && j == pointX) // 유저 하트 출력
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" ♡ ");
                            Console.ResetColor();
                        }

                        else if (map[i, j] == '◇')
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(" ◇ ");
                            Console.ResetColor();
                        }

                        else if (i == 0)  // 벽 출력1
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
                            Console.ResetColor();
                        }

                        else if (i == 12) // 벽 출력2
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
                            Console.ResetColor();
                        }

                        else if (j == 0 && i > 0 && i < 12) // 벽 출력3
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
                            Console.ResetColor();
                        }

                        else if (j == 12 && i > 0 && i < 12) // 벽 출력4
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
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

                // 방향키로 이동 시 ♡ 
                map[pointY, pointX] = '♡';

                ConsoleKeyInfo userKey = Console.ReadKey(true);

                switch (userKey.Key)
                {
                    case ConsoleKey.D:

                        if (map[pointY, pointX + 1] != '□')
                        {
                            pointX++;

                            if (map[pointY, pointX] == map[6, 11]) // 오른쪽 -> 왼쪽
                            {
                                pointY = 6;
                                pointX = 1;
                                count++;
                            }

                        }

                        break;
                    case ConsoleKey.A:

                        if (map[pointY, pointX - 1] != '□')
                        {
                            pointX--;

                            if (map[pointY, pointX] == map[6, 1]) // 왼쪽 -> 오른쪽
                            {
                                pointY = 6;
                                pointX = 11;
                                count++;
                            }
                        }

                        break;
                    case ConsoleKey.W:

                        if (map[pointY - 1, pointX] != '□')
                        {
                            pointY--;

                            if (map[pointY, pointX] == map[1, 6]) // 위 -> 아래
                            {
                                pointY = 11;
                                pointX = 6;
                                count++;
                            }
                        }

                        break;
                    case ConsoleKey.S:

                        if (map[pointY + 1, pointX] != '□')
                        {
                            pointY++;

                            if (map[pointY, pointX] == map[11, 6]) // 아래 -> 위
                            {
                                pointY = 1;
                                pointX = 6;
                                count++;
                            }
                        }

                        break;
                    default:
                        break;


                        /////이거 업ㄷ[ㅇ;트
                }
            }
        }
    }
}

