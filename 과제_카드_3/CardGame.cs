using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230619_Card_Ver3
{
    public class CardGame
    {
        public void Game()
        {
            Random random = new Random();

            string[] aiCardNumber = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };  // 컴퓨터 숫자
            string[] aiPattern = { "♤", "◆", "♥", "♧" };  // 컴퓨터 패턴

            List<string> aiChoice = new List<string>();
            List<string> userChoice = new List<string>();

            while (aiChoice.Count < 7)
            {
                int aiCardRand = random.Next(1, 13);    // 컴퓨터 카드 ( 숫자 ) 랜덤

                int aiCardPatternRand = random.Next(1, 4);  // 컴퓨터 카드 ( 패턴 ) 랜덤

                if (aiCardPatternRand == 0)
                {
                    aiChoice.Add(aiCardNumber[aiCardRand] + aiPattern[aiCardPatternRand]);
                }
                for (int i = 0; i < aiChoice.Count; i++)
                {
                    if (aiCardNumber[aiCardRand] + aiPattern[aiCardPatternRand] == aiChoice[i])
                    {
                        break;
                    }
                    Console.WriteLine(" ┌──────────────┐         ┌──────────────┐ ");
                    Console.WriteLine(" │ {0,2}{1,2}          │         │ {2,2}{3,2}          │ ", aiPattern[i/4], aiCardNumber[i/13], aiPattern[i/4], aiCardNumber[i/13]);
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │              │         │              │ ");
                    Console.WriteLine(" │          {0,2}{1,2} │         │          {2,2}{3,2} │ ", aiPattern, aiCardNumber, aiPattern, aiCardNumber);
                    Console.WriteLine(" └──────────────┘         └──────────────┘ ");
                }
                 aiChoice.Add(aiCardNumber[aiCardRand] + aiPattern[aiCardPatternRand]);

            }



        }
    }
}
