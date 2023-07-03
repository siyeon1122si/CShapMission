using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230613
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userInput2;
            int count = 0; // 코인 카운트
            int coinCount = 0;

            Random random = new Random();

            char coin = '$';

            int coinX;
            int coinY;


            coinX = random.Next(5 - 1);
            coinY = random.Next(5 - 1);

            while (true)
            {
                Console.Write(" \n 5 ~ 15 사이의 숫자를 입력하세요 : ");
                string userInput = Console.ReadLine();
                userInput2 = Convert.ToInt32(userInput);

                if (userInput2 < 5 || userInput2 > 15)
                {
                    Console.WriteLine(" \n 다시 입력하세요 ");
                    continue;
                }
                break;
            }
            int centerX = userInput2 / 2;
            int centerY = userInput2 / 2;

            char [,] map = new char[userInput2,userInput2];
            map[centerY, centerX] = '0';

            Console.Clear();

            while (true)
            {
                CursorPosition(0,0); // 화면 안깜빡이게 하는거

                // 출력
                for (int i = 0; i < userInput2; i++)
                {
                    for (int j = 0; j < userInput2; j++)
                    {
                        if (i == coinY && j == coinX)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("{0} ", map[i, j]);
                            Console.ResetColor();
                            continue;
                        }

                        Console.Write(map[i, j] == '\0' ? '*' : map[i, j]);

                        Console.Write(' ');
                    }
                    Console.WriteLine();
                } // 출력

                Console.WriteLine("[ w : 위 ] [ s : 아래 ] [ d : 오른쪽 ] [ a : 왼쪽 ]");
                ConsoleKeyInfo keyInfo = Console.ReadKey(); // 키 입력 받기

                int newCenterX = centerX;
                int newCenterY = centerY;   

                switch ( keyInfo.Key)
                {
                    case ConsoleKey.W:

                        if ( 0 < newCenterY )
                        {
                            newCenterY--;
                            count++;
                        }
                        break;

                    case ConsoleKey.A:

                        if (0 < newCenterX)
                        {
                            newCenterX--;
                            count++;    
                        }
                        break;

                    case ConsoleKey.S:

                        if ( newCenterY < userInput2-1)
                        {
                            newCenterY++;
                            count++;
                        }
                        break;

                    case ConsoleKey.D:

                        if ( newCenterX < userInput2-1)
                        {
                            newCenterX++;
                            count++;
                        }
                        break;

                    default:
                        continue;
                }


                // 코인 출력 {
                for ( int y = 0; y < userInput2; y++ )
                {
                    for ( int x = 0; x < userInput2; x++ )
                    {
                        if ( coinX == x && coinY == y )
                        {
                            map[y, x] = '$';
                        }

                        else
                        {
                            map[y, x] = '*';
                        }

                    }
                } // } 코인 출력

                if ( count > userInput2 )
                {
                    coinX = random.Next(userInput2 - 1);
                    coinY = random.Next(userInput2 - 1);
                    count = 0;
                }

                if ( newCenterX == coinX && newCenterY == coinY )
                {
                    coinX = random.Next(userInput2 - 1);
                    coinY = random.Next(userInput2 - 1);
                    count = 0;
                    coinCount++;
                }


                CursorPosition(0, 0);
                // 출력
                for (int i = 0; i < userInput2; i++)
                {
                    for (int j = 0; j < userInput2; j++)
                    {
                        Console.Write(map[i, j] == '\0' ? '*' : map[i, j]);
                        Console.Write(' ');

                        if ( i == coinY && j == coinX )
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("{0}", map[coinY, coinX]);
                            Console.ResetColor();
                        }

                    }
                    Console.WriteLine();
                } // 출력



                // 유저 출력 {
                if ( newCenterX >= 0 && newCenterY < userInput2 && newCenterY >= 0 && newCenterY < userInput2)
                {
                    map[centerY, centerX] = '*';
                    centerX = newCenterX;
                    centerY = newCenterY;
                    map[centerY, centerX] = '0';
                } // } 유저 출력


                // 현재 코인 및 승리 조건 {
                if ( coinCount < 10)
                {

                    CursorPosition(0, 0);
                    // 출력
                    for (int i = 0; i < userInput2; i++)
                    {
                        for (int j = 0; j < userInput2; j++)
                        {
                            Console.Write(map[i, j] == '\0' ? '*' : map[i, j]);
                            Console.Write(' ');

                            if (i == coinY && j == coinX)
                            {
                                Console.ForegroundColor= ConsoleColor.Yellow;
                                Console.Write("{0}", map[coinY, coinX]);
                                Console.ResetColor();
                                continue;
                            }

                        }
                        Console.WriteLine();
                    } // 출력

                    Console.WriteLine();
                    Console.Write(" 현재 코인 : {0} ",coinCount);
                }
                else if ( coinCount >= 10)
                {
                    Console.Clear();

                          CursorPosition(0, 0);
                // 출력
                for (int i = 0; i < userInput2; i++)
                {
                    for (int j = 0; j < userInput2; j++)
                    {
                        Console.Write(map[i, j] == '\0' ? '*' : map[i, j]);
                        Console.Write(' ');

                        if ( i == coinY && j == coinX )
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("{0}", map[coinY, coinX]);
                            Console.ResetColor();
                        }

                    }
                    Console.WriteLine();
                } // 출력
                    Console.WriteLine();
                    Console.WriteLine(" 승리 !");
                    break;
                } // } 현재 코인 및 승리 조건 


            }



        }

        static void CursorPosition( int x, int y ) // 화면 안깜빡이게 하는거
        {
            Console.SetCursorPosition( x, y );
        }
    }
}
