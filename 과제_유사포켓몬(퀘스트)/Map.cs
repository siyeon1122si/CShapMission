using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mission_230619
{
    public class Map
    {
        const int MaxHp = 100;
        int count = 0;
        int pointX = 9;
        int pointY = 6;
        int userHp = 100;
        int battleCount = 0;
        int questCount = 0;
        int coin = 1000;

        Random random = new Random();
        public void MapOpen()
        {
            Console.WindowWidth = 140;
            char[,] map = new char[13, 19];
            Console.CursorVisible = false;

            map[6, 1] = '▶';
            map[2, 7] = '◎';

            while (true)
            {
                Console.SetCursorPosition(0, 0);

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("             ▶ : 퀘스트");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("        ☆ 마을 ☆");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("          ◎ : 치유의 샘물 ");
                Console.WriteLine();
                Console.WriteLine();
                Console.ResetColor();

                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 19; j++)
                    {
                        if ((i == 0) || (i == 12) || (j == 0 && i > 0 && i < 12) || (j == 18 && i > 0 && i < 12))  // 외부 벽 출력
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            map[i, j] = '□';
                            Console.Write(" □ ", map);
                            Console.ResetColor();
                        }

                        else if (i == pointY && j == pointX) // 유저 하트 출력
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" ♡ ");
                            Console.ResetColor();
                        }

                        else if ((j - i > 11 && map[i, j] != '□') || (i == 3 && j == 14) || (i == 2 && j == 13) ||// 오른쪽 위
                            ((i + j < 7 && map[i, j] != '□') && (i != 3 || j != 3) && (i != 4 || j != 2) && (i != 5 || j != 1)) || // 왼쪽 위
                            ((j + i > 23 && map[i, j] != '□') && (i != 9 || j != 15)) || // 오른쪽 아래
                            (i == 6 && j == 17) ||
                            ((i - j > 5 && map[i, j] != '□') && (i != 7 || j != 1) && (i != 8 || j != 2) && (i != 9 || j != 3)) || // 왼쪽 아래
                            (i == 1 && map[i, j] != '□') || (i == 11 && map[i, j] != '□') ||
                            (i == 10 && j == 10) || (i == 10 && j == 11) || (i == 10 && j == 12) || (i == 9 && j == 11) ||
                            (i == 2 && j == 5) || (i == 2 && j == 6) || (i == 3 && j == 6) || (i == 2 && j == 8))

                        {
                            map[i, j] = '♧';
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write(" ♧ ");
                            Console.ResetColor();
                        }

                        else if (i == 6 && j == 1)
                        {
                            map[6, 1] = '▶';
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(" ▶ ");
                            Console.ResetColor();
                        }

                        else if (i == 2 && j == 7)
                        {
                            map[2, 7] = '◎';
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Write(" ◎ ");
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
                    case ConsoleKey.RightArrow:

                        if (map[pointY, pointX + 1] == '♧')
                        {
                            Battle();
                        }
                        if (map[pointY, pointX + 1] != '□')
                        {
                            pointX++;
                            count++;
                        }

                        break;
                    case ConsoleKey.LeftArrow:

                        if (map[pointY, pointX - 1] == '♧')
                        {
                            Battle();
                        }
                        if (map[pointY, pointX - 1] != '□')
                        {
                            pointX--;
                            count++;
                        }

                        break;
                    case ConsoleKey.UpArrow:

                        if (map[pointY - 1, pointX] == '♧')
                        {
                            Battle();
                        }
                        if (map[pointY - 1, pointX] != '□')
                        {
                            pointY--;
                            count++;
                        }

                        break;
                    case ConsoleKey.DownArrow:

                        if (map[pointY + 1, pointX] == '♧')
                        {
                            Battle();
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

                // 보유 코인
                Console.SetCursorPosition(90, 3);
                Console.WriteLine(" 보유 코인 : {0,4}  |  현재 HP : {1}", coin,userHp);


                if (map[pointY, pointX] == map[6, 1]) // 퀘스트 문구
                {
                    Quest();

                    if (questCount > 0)
                    {
                        Console.SetCursorPosition(98, 5);
                        Console.WriteLine(" 퀘스트 진행 중");
                    }
                }

                if (battleCount >= 1 && battleCount < 5) // 퀘스트 진행도
                {
                    Console.SetCursorPosition(101, 7);
                    Console.WriteLine(" [ {0} / 5 ]", battleCount);
                }
                else if (battleCount == 5)
                {
                    ClearBattle();
                    Console.SetCursorPosition(77, 7);
                    Console.WriteLine(" 퀘스트를 클리어 하셨습니다 !");
                    questCount = 0;
                    coin += 500;
                }

                if (map[pointY, pointX] == map[2, 7]) // 힐 함수 실행
                {
                    Heal();
                }
            } // while
        }


        // 몬스터와의 배틀
        void Battle()
        {
            int battle = random.Next(0, 100);
            int monsterHp = 100;
            int monsterDamage = 10;
            int userDamage = 30;

            if (battle <= 36)
            {
                Console.SetCursorPosition(77, 10);
                Console.WriteLine(" 몬스터를 만났습니다 !");

                while (monsterHp > 0 || userHp > 0)
                {


                    if (monsterHp > 0)
                    {
                        Console.SetCursorPosition(77, 12);
                        Console.WriteLine(" 몬스터의 체력 : {0} | 유저의 체력 : {1} ", monsterHp, userHp);
                        Console.SetCursorPosition(77, 14);
                        monsterHp -= userDamage;
                        Console.WriteLine(" 유저의  공격 [ 대미지 : 30 ]");
                        Thread.Sleep(1000);
                    }

                    if (monsterHp <= 0)
                    {
                        Console.SetCursorPosition(77, 12);
                        Console.WriteLine(" 몬스터의 체력 :  0  | 유저의 체력 : {0} ", userHp);
                        Console.SetCursorPosition(77, 16);
                        Console.WriteLine(" ! 몬스터 처치 ! ");
                        ClearBattle();
                        if (questCount != 0)
                        {
                            battleCount++;
                        }
                        Thread.Sleep(1000);
                        break;
                    }

                    if (userHp > 0)
                    {
                        Console.SetCursorPosition(77, 12);
                        Console.WriteLine(" 몬스터의 체력 : {0} | 유저의 체력 : {1} ", monsterHp, userHp);
                        Console.SetCursorPosition(77, 14);
                        Console.WriteLine(" 몬스터의 공격 [ 대미지 : 10 ]");
                        userHp -= monsterDamage;
                        Thread.Sleep(1000);
                    }

                    if (userHp <= 0)
                    {
                        Console.SetCursorPosition(77, 12);
                        Console.WriteLine(" 몬스터의 체력 : {0} | 유저의 체력 :  0 ", monsterHp);
                        Console.SetCursorPosition(77, 16);
                        Console.WriteLine(" 사망 ㅋ");
                        Environment.Exit(0);
                        break;
                    }
                }

            }
        }
        // 몬스터와의 배틀


        // 퀘스트 
        public void Quest()
        {
            while (true)
            {

                Console.SetCursorPosition(77, 5);
                Console.WriteLine(" 퀘스트를 받으시겠습니까? [ Y / N ] ");

                Console.SetCursorPosition(80, 7);
                ConsoleKeyInfo user = Console.ReadKey();


                switch (user.Key)
                {
                    case ConsoleKey.Y:
                        Console.SetCursorPosition(77, 7);
                        Console.WriteLine(" 퀘스트를 수락하였습니다 ");
                        Console.WriteLine();
                        questCount++;
                        Console.SetCursorPosition(77, 9);
                        Console.WriteLine(" 몬스터를 5번 처치하세요 [ 0 / 5 ] ");
                        Thread.Sleep(2000);
                        ClearMap();
                        break;
                    case ConsoleKey.N:
                        Console.SetCursorPosition(77, 7);
                        Console.WriteLine(" 받아주세용 ");
                        ClearMap();
                        break;
                    default:
                        break;

                }
                break;

            }
        }
        // 퀘스트

        // 힐
        public void Heal()
        {
            int heal = 50;
            Console.SetCursorPosition(77, 7);
            Console.WriteLine(" 치유의 샘물에서 힐을 하시겠습니까 ? [ Y / N ] ");
            Console.SetCursorPosition(80, 9);
            Console.WriteLine(" 비용 : 500원 ");

            Console.SetCursorPosition(80, 11);
            ConsoleKeyInfo user = Console.ReadKey();

            switch (user.Key)
            {
                case ConsoleKey.Y:
                    if (coin <= 0)
                    {
                        Console.SetCursorPosition(77, 11);
                        Console.WriteLine(" 돈이 부족합니다 ");
                        coin = 0;
                    }

                    else
                    {
                        coin -= 500;
                        Console.SetCursorPosition(77, 11);
                        Console.WriteLine(" [ 50 ] 만큼의 힐을 받았습니다");
                        userHp += heal;

                    }
                    if (userHp > MaxHp)
                    {
                        userHp = MaxHp;
                    }
                    Console.SetCursorPosition(77, 13);
                    Console.WriteLine(" 현재 HP : {0} ", userHp);
                    Thread.Sleep(2000);
                    ClearHeal();
                    break;
                case ConsoleKey.N:
                    Console.SetCursorPosition(77, 11);
                    Console.WriteLine(" 취소하였습니다 ");
                    Thread.Sleep(1000);
                    ClearHeal();
                    break;
                default:
                    break;

            }

        }
        // 힐


        public void ClearBattle()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(77, 10 + i * 2);
                Console.Write("                                                  ");
            }
        }
        public void ClearMap()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(77, 5 + i * 2);
                Console.Write("                                                  ");
            }
        }
        public void ClearHeal()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.SetCursorPosition(77, 7 + i * 2);
                Console.Write("                                                  ");
            }
        }
    }
}
