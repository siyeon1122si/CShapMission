using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mission_230615
{
    public class StoneMoveGame
    {
        Random rand = new Random();
        int userInput = 0;

        public void Map()
        {

            while (true)
            {
                Console.WriteLine(" 맵의 크기를 적어주세요 5 - 15 : ");
                userInput = Convert.ToInt32(Console.ReadLine());     // 문자열을 정수로 출력한다. ReadKey는 하나의 키 값만 받지만 ( 1자리수 ) ,
                                                                     // ReadLine은 여러개의 문자열을 정수로 변환해준다.
                Console.Clear();
                if (userInput >= 5 && userInput <= 15)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(" 올바른 값을 적어주세요");

                }
            }

            //Console.SetWindowSize(75, 20); // 콘솔창 크기
            char[,] star = new char[17, 17];
            int pointX = userInput / 2;         
            int pointY = userInput / 2;         


            for (int i = 0; i < userInput + 2; i++)
            {
                for (int j = 0; j < userInput + 2; j++)
                {
                    star[i, j] = '　';

                    if (i == 0 || j == 0)
                    {
                        star[i, j] = '□';
                    }

                    else if (i == userInput + 1 || userInput + 1 == j)
                    {
                        star[i, j] = '□';
                    }

                    if (i == userInput / 2 && j == userInput / 2)    
                    {
                        star[i, j] = '♡';
                    }
                }
            }

            // 맵 , 유저 출력 부분 {
            while (true)
            {
                for (int y = 0; y < userInput + 2; y++)
                {
                    for (int x = 0; x < userInput + 2; x++)
                    {
                        if (star[y, x] == '□')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" {0} ", star[y, x]);
                            Console.ResetColor();
                        }
                        else if (star[y, x] == '♡')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" {0} ", star[y, x]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(" {0} ", star[y, x]);

                        }
                    }
                    Console.WriteLine("\n");
                } // } 맵 , 유저 출력 부분

                ConsoleKey userMove = Console.ReadKey(true).Key;  // w , a , s , d 로 유저 움직이기 {
                switch (userMove)
                {

                    case ConsoleKey.A:
                        if (pointX > 1)
                        {
                            star[pointY, pointX] = '　';
                            star[pointY, pointX - 1] = '♡';
                            pointX--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (userInput > pointX)
                        {
                            star[pointY, pointX] = '　';
                            star[pointY, pointX + 1] = '♡';
                            pointX++;
                        }
                        break;
                    case ConsoleKey.W:
                        if (pointY > 1)
                        {
                            star[pointY, pointX] = '　';
                            star[pointY - 1, pointX] = '♡';
                            pointY--;
                        }
                        break;
                    case ConsoleKey.S:
                        if (userInput > pointY)
                        {
                            star[pointY, pointX] = '　';
                            star[pointY + 1, pointX] = '♡';
                            pointY++;
                        }
                        break;
                    default:
                        break;
                }  // } w , a , s , d 로 유저 움직이기 
                Console.SetCursorPosition(0,0);
            }

        }

    }
}

