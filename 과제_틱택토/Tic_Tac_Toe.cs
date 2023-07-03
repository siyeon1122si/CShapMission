using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Mission_230613
{
    public class Tic_Tac_Toe
    {
        int userWin = 0;
        int userLose = 0;
        int draw = 0;
        public void Bingo()
        {
            Random random = new Random();

            char[] number = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
           
                int user_X = 0; // 유저 
            while (true)
            {
                Map(ref number);

                int AI_O;              // 컴퓨터
                AI_O = random.Next(0, 9);
                String user1;
                char user2;

                user1 = Console.ReadLine();
                Console.Clear();
                int.TryParse(user1, out user_X); // 정수를 문자열로 ~

                if (number[user_X] == 'X' || number[user_X] == 'C')
                {

                    Console.WriteLine(" 이미 누군가가 둔 곳에 둘 수 없어용 ");
                    continue;
                }
                number[user_X] = 'X';

                
                Win(ref number);
                if (userWin > 0)
                {
                    Map(ref number);
                    Console.WriteLine();
                    Console.WriteLine(" 이겼어용 추카포카 !");
                    break;
                }
                Draw(ref number);
                if ( draw > 0 )
                {
                    Map(ref number);
                    Console.WriteLine();
                    Console.WriteLine(" 비겼네용 ㅋ");
                    break;
                }

                while (true)
                {


                    if (number[AI_O] == 'X' || number[AI_O] == 'C')
                    {
                        AI_O = random.Next(0, 9);

                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                number[AI_O] = 'C';

                Lose(ref number);
                if ( userLose > 0 )
                {
                    Map(ref number);
                    Console.WriteLine();
                    Console.WriteLine(" 졌네용 ㅋ");
                    break;
                }
               
                
            }
        }

        public void Map(ref char[] ptrchar)
        {
            Console.WriteLine("───────────────────────");
            Console.WriteLine("  Tic     Tac     Toe  ");
            Console.WriteLine("───────────────────────");

            Console.WriteLine("       │       │       ");
            Console.WriteLine("   {0}   │   {1}   │    {2}  ", ptrchar[0], ptrchar[1], ptrchar[2]);
            Console.WriteLine("       │       │       ");
            Console.WriteLine("───────┼───────┼───────");
            Console.WriteLine("       │       │       ");
            Console.WriteLine("   {0}   │   {1}   │    {2}  ", ptrchar[3], ptrchar[4], ptrchar[5]);
            Console.WriteLine("       │       │       ");
            Console.WriteLine("───────┼───────┼───────");
            Console.WriteLine("       │       │       ");
            Console.WriteLine("   {0}   │   {1}   │    {2}  ", ptrchar[6], ptrchar[7], ptrchar[8]);
            Console.WriteLine("       │       │       ");
        } // 맵

        public void Win(ref char[] ptrchar)
        {
            int winCount = 0;
            for (int x = 0; x < 3; x++)
            { 
                winCount =0 ;
                for (int y = 0; y < 3; y++)
                {
                   if (ptrchar[y+3*x] == 'X')
                    {
                        winCount++;
                    }
                   if ( winCount == 3)
                    {
                        userWin += 1;
                    }
                }      
            }

            for ( int y = 0; y < 3;y++)
            {
                winCount = 0;

                for (int x = 0;x < 3;x++)
                {
                    if ( ptrchar[x*3+y] == 'X')
                    {
                        winCount++;
                    }
                    if( winCount == 3)
                    {
                        userWin += 1;
                    }
                }
            }


            // 대각선

            winCount = 0;
            if (ptrchar[0] == ptrchar[4] && ptrchar[4] ==  ptrchar[8])
            {
                winCount++;
            }
            if (winCount == 1)
            {
                userWin += 1;
            }

            winCount = 0;


            if (ptrchar[2] == ptrchar[4] && ptrchar[4] == ptrchar[6])
            {
                winCount++;
            }
            if (winCount == 1)
            {
                userWin += 1;
            }


        }

        public void Lose( ref char[] ptrchar)
        {
            int loseCount = 0;

            for (int x = 0; x < 3; x++)
            {
                loseCount = 0;
                for (int y = 0; y < 3; y++)
                {
                    if (ptrchar[y + 3 * x] == 'C')
                    {
                        loseCount++;
                    }
                    if (loseCount == 3)
                    {
                        userLose += 1;
                    }
                }
            }

            for (int y = 0; y < 3; y++)
            {
                loseCount = 0;

                for (int x = 0; x < 3; x++)
                {
                    if (ptrchar[x * 3 + y] == 'C')
                    {
                        loseCount++;
                    }
                    if (loseCount == 3)
                    {
                        userLose += 1;
                    }
                }
            }


            // 대각선

            loseCount = 0;
            if (ptrchar[0] == ptrchar[4] && ptrchar[4] == ptrchar[8])
            {
                loseCount++;
            }
            if (loseCount == 1)
            {
                userLose += 1;
            }

            loseCount = 0;


            if (ptrchar[2] == ptrchar[4] && ptrchar[4] == ptrchar[6])
            {
                loseCount++;
            }
            if (loseCount == 1)
            {
                userLose += 1;
            }
        }

        public void Draw(ref char[] ptrchar)
        {
            int drawCount = 0;

            for ( int i = 0; i < 9; i++)
            {
                if (ptrchar[i] == 'X' || ptrchar[i] == 'C')
                {
                    drawCount++;
                }
                if ( drawCount == 9 )
                {
                    draw += 1;
                }
            }
        }
    }
}
