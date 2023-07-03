using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace study
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();  // 랜덤 생성
            int[] autoCard = new int[2];   // 컴퓨터 
            int[] userCard = new int[2];   // 유저

            int[] autoPattern = { 1, 2, 3, 4 };
            int[] userPattern = { 1, 2, 3, 4 };


           

            Console.WriteLine();

            // 컴퓨터의 카드 2장 및 합
            Console.WriteLine(" 상대방이 뽑은 카드 2장 ");
            Console.WriteLine();
            for (int i = 0; i < 2; i++) // 컴퓨터 카드 계산
            {
                Task.Delay(1000).Wait();    // 1초뒤 나오도록 설정

                autoCard[i] = random.Next(1, 13);
            }

            for (int j = 0; j < 2; j++) // 모양
            {
                int b; b = random.Next(4);

                Console.Write("");
                switch (autoPattern[b])
                {
                    case 1:
                        Console.WriteLine(" ┌──────────────┐ ");
                        Console.WriteLine(" │ ♠ {0}        │ ", autoCard[j]);
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │        ♠ {0} │ ", autoCard[j]);
                        Console.WriteLine(" └──────────────┘ ");
                        break;
                    case 2:
                        Console.WriteLine(" ┌──────────────┐ ");
                        Console.WriteLine(" │ ◆ {0}        │ ", autoCard[j]);
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │        ◆ {0} │ ", autoCard[j]);
                        Console.WriteLine(" └──────────────┘ ");
                        break;
                    case 3:
                        Console.WriteLine(" ┌──────────────┐ ");
                        Console.WriteLine(" │ ♥ {0}        │ ", autoCard[j]);
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │        ♥ {0} │ ", autoCard[j]);
                        Console.WriteLine(" └──────────────┘ ");
                        break;
                    case 4:
                        Console.WriteLine(" ┌──────────────┐ ");
                        Console.WriteLine(" │ ♣ {0}        │ ", autoCard[j]);
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │        ♣ {0} │ ", autoCard[j]);
                        Console.WriteLine(" └──────────────┘ ");
                        break;
                    default:
                        break;
                        
                }
                Console.ReadKey();
            }

            int autoadd = autoCard[0] + autoCard[1];  // 컴퓨터 카드 2장의 합

            Console.WriteLine(" 두 수의 합은 : {0}", autoadd);



            for (int i = 0; i < 2; i++) // 유저 카드 계산
            {
                Task.Delay(1000).Wait();    // 1초뒤 나오도록 설정

                userCard[i] = random.Next(1, 13);
            }

            // 유저의 카드 2장 및 합
            Console.WriteLine();
            Console.WriteLine(" 유저가 뽑은 카드 2장 ");
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                int a; a = random.Next(4);

                switch (userPattern[a])
                {

                    case 1:
                        Console.WriteLine(" ┌──────────────┐ ");
                        Console.WriteLine(" │ ♠ {0}        │ ", userCard[i]);
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │        ♠ {0} │ ", userCard[i]);
                        Console.WriteLine(" └──────────────┘ ");
                        break;
                    case 2:
                        Console.WriteLine(" ┌──────────────┐ ");
                        Console.WriteLine(" │ ◆ {0}        │ ", userCard[i]);
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │        ◆ {0} │ ", userCard[i]);
                        Console.WriteLine(" └──────────────┘ ");
                        break;
                    case 3:
                        Console.WriteLine(" ┌──────────────┐ ");
                        Console.WriteLine(" │ ♥ {0}        │ ", userCard[i]);
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │        ♥ {0} │ ", userCard[i]);
                        Console.WriteLine(" └──────────────┘ ");
                        break;
                    case 4:
                        Console.WriteLine(" ┌──────────────┐ ");
                        Console.WriteLine(" │ ♣ {0}        │ ", userCard[i]);
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │              │ ");
                        Console.WriteLine(" │        ♣ {0} │ ", userCard[i]);
                        Console.WriteLine(" └──────────────┘ ");
                        break;
                    default:
                        break;

                }
                Console.ReadKey();
            }

            int useradd = userCard[0] + userCard[1];  // 유저 카드 2장의 합

            
            Console.WriteLine(" 두 수의 합은 : {0}", useradd);

            // 승리 패배 조건
            if (useradd < autoadd)
            {
                Console.WriteLine(" 패배 ! ");
            }
            else if (useradd > autoadd)
            {
                Console.WriteLine(" 승리 ! ");
            }
        }
    }
}
