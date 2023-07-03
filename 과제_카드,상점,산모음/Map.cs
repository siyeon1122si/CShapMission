using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_230619
{
    public class Map
    {
        int pointX = 6;
        int pointY = 6;

        public void MapOpen(ref int coin)
        {
            char[,] map = new char[13, 13];
            while (true)
            {


                if (coin <= 0)
                {
                    Console.WriteLine("\n\n\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                           □□□□□□ □         □      □      □□□□");
                    Console.WriteLine("                             □   □    □       □  □    □            □");
                    Console.WriteLine("                             □   □    □□   □     □   □□          □");
                    Console.WriteLine("                             □   □    □                 □     □□□□□");
                    Console.WriteLine("                           □□□□□□ □         □      □            □");
                    Console.WriteLine("                                                   □                    □");
                    Console.WriteLine("                                                   □□□□              □ ");
                    Console.ResetColor();
                    Environment.Exit(0);
                }

                Console.SetCursorPosition(0, 0);

                map[2, 6] = '☆';
                map[9, 2] = '◇';
                map[9, 10] = '♧';

                Store store = new Store();
                Card card = new Card();
                Battle battle = new Battle();
                Map map1 = new Map();
                


                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("    ☆ = 상점");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("       ◇ = 카드게임");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("        ♧ = 숲 ");
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

                        else if (map[i, j] == '☆')  // 상점
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(" ☆ ");
                            Console.ResetColor();

                        }

                        else if (map[i, j] == '◇') // 카드
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(" ◇ ");
                            Console.ResetColor();
                        }

                        else if (map[i, j] == '♧') // 숲
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(" ♧ ");
                            Console.ResetColor();
                        }

                        else if ( i == 0)  // 벽 출력1
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
                            Console.ResetColor();
                        }

                        else if ( i == 12) // 벽 출력2
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
                            Console.ResetColor();
                        }

                        else if ( j == 0 && i > 0 && i < 12) // 벽 출력3
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

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" 마을에 도착하여 모든 HP가 회복되었습니다 ");
                Console.ResetColor();

                if (map[pointY,pointX] == map[2, 6])
                {
                    Console.WriteLine(" 상점에 입장하시겠습니까? [ Y / N ] ");

                    ConsoleKeyInfo user = Console.ReadKey();

                    switch ( user.Key )
                    {
                        case ConsoleKey.Y:
                            Console.Clear();
                            store.StoreOpen(ref coin);
                            break;
                        case ConsoleKey.N:
                            Console.Clear();
                            map1.MapOpen(ref coin);
                            break;
                        default:
                            break;

                    }
                }
                
                else if(map[pointY, pointX] == map[9, 2])
                {
                    Console.WriteLine(" 카드게임에 입장하시겠습니까? [ Y / N ] ");

                    ConsoleKeyInfo user = Console.ReadKey();

                    switch (user.Key)
                    {
                        case ConsoleKey.Y:
                            Console.Clear();
                            card.CardOpen(ref coin);
                            break;
                        case ConsoleKey.N:
                            Console.Clear();
                            map1.MapOpen(ref coin);
                            break;
                        default:
                            break;

                    }
                }

                else if (map[pointY, pointX] == map[9, 10])
                {
                    Console.WriteLine(" 숲에 입장하시겠습니까? [ Y / N ] ");

                    ConsoleKeyInfo user = Console.ReadKey();

                    switch (user.Key)
                    {
                        case ConsoleKey.Y:
                            Console.Clear();
                            battle.Mountain(ref coin);
                            break;
                        case ConsoleKey.N:
                            Console.Clear();
                            map1.MapOpen(ref coin);
                            break;
                        default:
                            break;

                    }
                }


                // 방향키로 이동 시 ♡ 
                map[pointY, pointX] = '♡';

                ConsoleKeyInfo userKey = Console.ReadKey(true);

                switch (userKey.Key)
                {
                    case ConsoleKey.RightArrow:

                        if (map[pointY, pointX + 1] != '□')
                        {
                            pointX++;
                        }

                        break;
                    case ConsoleKey.LeftArrow:

                        if (map[pointY, pointX - 1] != '□')
                        {
                            pointX--;
                        }

                        break;
                    case ConsoleKey.UpArrow:

                        if (map[pointY - 1, pointX] != '□')
                        {
                            pointY--;
                        }

                        break;
                    case ConsoleKey.DownArrow:

                        if (map[pointY + 1, pointX] != '□')
                        {
                            pointY++;
                        }

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
