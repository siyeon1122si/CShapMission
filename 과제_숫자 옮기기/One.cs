using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _230616
{
    public class One
    {
        public void TurnOne()
        {
            int[,] map = new int[10, 10];

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    map[i, j] = 0;
                }
            }
            int pointX = rand.Next(0, 9);
            int pointY = rand.Next(0, 9);

            bool pushKey = false;

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                for (int k = 0; k < 3; k++)
                {

                    pointX = rand.Next(0, 9);
                    pointY = rand.Next(0, 9);

                    map[pointY, pointX] = 1;


                }
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (map[i, j] != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("{0,2}   ", map[i, j]);
                            Console.ResetColor();
                        }
                        else if (i==9 && j == 9)
                        {
                            Console.Write("");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("♡   ");
                            Console.ResetColor();
                        }   
                    }

                    Console.WriteLine("\n");
                }

                ConsoleKeyInfo userKey = Console.ReadKey();

                switch (userKey.Key)
                {
                    case ConsoleKey.RightArrow:
                        pushKey = true;

                        for (int i = 0; i < 9; i++)
                        {
                            for (int j = 0; j < 9; j++)
                            {
                                if (map[i, j] == 1)
                                {
                                    int save = map[i, j];
                                    map[i, 9] = save + map[i, 9];
                                    map[i, j] = 0;

                                }
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        pushKey = true;

                        for (int i = 0; i < 9; i++)
                        {
                            for (int j = 0; j < 9; j++)
                            {
                                if (map[i, j] == 1)
                                {
                                    int save = map[i, j];
                                    map[9, j] = save + map[9, j];
                                    map[i, j] = 0;

                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

