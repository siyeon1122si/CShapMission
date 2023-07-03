using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230619
{
    public class CardGame
    {
        List<Card> cardAll = new List<Card>();
        int isStraight = 0;
        int isRoyalStraight = 0;
        int isStraightFlush = 0;
        int isFourCard = 0;
        int isFullHouse = 0;
        int isFlush = 0;
        int isTriple = 0;
        int isTwoPair = 0;
        int isOnePair = 0;
        public void Game()
        {
            

            Random airandom = new Random();

            string[] aiNumber = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K","A" };
            string[] aiPattern = { "♧", "♡", "◇", "♤" };
            int[] cardLevel = new int[52];
            for(int i = 0; i < 52; i++)
            {
                cardLevel[i] = i;
            }

            List<string> aiCard = new List<string>();

            for (int i = 0; i < 10000; i++)
            {
                int number = airandom.Next(51);
                int temp = cardLevel[number + 1];
                cardLevel[number + 1] = cardLevel[number];
                cardLevel[number] = temp;
            }

            for ( int i = 0; i < 17; i++ )
            {
                // 51 % 13 : number
                // 51 / 13 : pattern

                string cardAdd = aiPattern[cardLevel[i]/13] + aiNumber[cardLevel[i]%13];

                Card tempCard = new Card();
                tempCard.cardPT = cardAdd;
                tempCard.cardNum = cardLevel[i];
                cardAll.Add(tempCard);
            }

            Console.WriteLine();
            Console.WriteLine(" [ 컴퓨터의 카드 7장 ]");
            Console.WriteLine(" ┌────────────┐┌────────────┐┌────────────┐┌────────────┐┌────────────┐┌────────────┐┌────────────┐");
            Console.WriteLine(" │ {0}        ││ {1}        ││ {2}        ││ {3}        ││ {4}        ││ {5}        ││ {6}        │",
                cardAll[0].cardPT, cardAll[1].cardPT, cardAll[2].cardPT, cardAll[3].cardPT, cardAll[4].cardPT, cardAll[5].cardPT, cardAll[6].cardPT);
            Console.WriteLine(" │            ││            ││            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            ││            ││            │");
            Console.WriteLine(" │        {0} ││        {1} ││        {2} ││        {3} ││        {4} ││        {5} ││        {6} │",
                cardAll[0].cardPT, cardAll[1].cardPT, cardAll[2].cardPT, cardAll[3].cardPT, cardAll[4].cardPT, cardAll[5].cardPT, cardAll[6].cardPT);
            Console.WriteLine(" └────────────┘└────────────┘└────────────┘└────────────┘└────────────┘└────────────┘└────────────┘");

            Console.ReadLine();

            Console.WriteLine(" [ 유저의 카드 5장 ]");
            Console.WriteLine();
            Console.WriteLine(" ┌────────────┐┌────────────┐┌────────────┐┌────────────┐┌────────────┐");
            Console.WriteLine(" │ {0}        ││ {1}        ││ {2}        ││ {3}        ││ {4}        │",
                cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
            Console.WriteLine(" │            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            │");
            Console.WriteLine(" │            ││            ││            ││            ││            │");
            Console.WriteLine(" │        {0} ││        {1} ││        {2} ││        {3} ││        {4} │",
                cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
            Console.WriteLine(" └────────────┘└────────────┘└────────────┘└────────────┘└────────────┘");

            Console.ReadLine();


            Console.WriteLine(" 유저의 카드중 교체할 2장을 골라주세요");
            Console.Write(" [ 1 ] [ 2 ] [ 3 ] [ 4 ] [ 5 ]");
            int count = 0;

            while (count < 2)
            {

                if (count == 1)
                {
                    Console.WriteLine(" 교체할 카드 1장을 더 골라주세요 ");
                }
                ConsoleKeyInfo userKey = Console.ReadKey();
                Console.Clear();

                switch (userKey.Key)
                {
                    case ConsoleKey.D1:
                        cardAll[7] = cardAll[12];

                        Console.WriteLine(" ┌────────────┐┌────────────┐┌────────────┐┌────────────┐┌────────────┐");
                        Console.WriteLine(" │ {0}        ││ {1}        ││ {2}        ││ {3}        ││ {4}        │",
                            cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │        {0} ││        {1} ││        {2} ││        {3} ││        {4} │",
                            cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
                        Console.WriteLine(" └────────────┘└────────────┘└────────────┘└────────────┘└────────────┘");
                        break;
                    case ConsoleKey.D2:
                        cardAll[8] = cardAll[13];
                        Console.WriteLine(" ┌────────────┐┌────────────┐┌────────────┐┌────────────┐┌────────────┐");
                        Console.WriteLine(" │ {0}        ││ {1}        ││ {2}        ││ {3}        ││ {4}        │",
                           cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │        {0} ││        {1} ││        {2} ││        {3} ││        {4} │",
                            cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
                        Console.WriteLine(" └────────────┘└────────────┘└────────────┘└────────────┘└────────────┘");
                        break;
                    case ConsoleKey.D3:
                       cardAll[9] = cardAll[14];
                        Console.WriteLine(" ┌────────────┐┌────────────┐┌────────────┐┌────────────┐┌────────────┐");
                        Console.WriteLine(" │ {0}        ││ {1}        ││ {2}        ││ {3}        ││ {4}        │",
                           cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │        {0} ││        {1} ││        {2} ││        {3} ││        {4} │",
                           cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
                        Console.WriteLine(" └────────────┘└────────────┘└────────────┘└────────────┘└────────────┘");
                        break;
                    case ConsoleKey.D4:
                        cardAll[10] = cardAll[15];
                        Console.WriteLine(" ┌────────────┐┌────────────┐┌────────────┐┌────────────┐┌────────────┐");
                        Console.WriteLine(" │ {0}        ││ {1}        ││ {2}        ││ {3}        ││ {4}        │",
                           cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │        {0} ││        {1} ││        {2} ││        {3} ││        {4} │",
                            cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
                        Console.WriteLine(" └────────────┘└────────────┘└────────────┘└────────────┘└────────────┘");
                        break;
                    case ConsoleKey.D5:
                        cardAll[11] = cardAll[16];
                        Console.WriteLine(" ┌────────────┐┌────────────┐┌────────────┐┌────────────┐┌────────────┐");
                        Console.WriteLine(" │ {0}        ││ {1}        ││ {2}        ││ {3}        ││ {4}        │",
                            cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │            ││            ││            ││            ││            │");
                        Console.WriteLine(" │        {0} ││        {1} ││        {2} ││        {3} ││        {4} │",
                            cardAll[7].cardPT, cardAll[8].cardPT, cardAll[9].cardPT, cardAll[10].cardPT, cardAll[11].cardPT);
                        Console.WriteLine(" └────────────┘└────────────┘└────────────┘└────────────┘└────────────┘");
                        break;


                } // switch
                count++;
            } // while
        }

        // 배열
        void Sort()
        {
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 6 - j; i++)
                {
                    if (cardAll[i].cardNum % 13 > cardAll[i + 1].cardNum % 13)
                    {
                        Card temp = cardAll[i + 1];
                        cardAll[i + 1] = cardAll[i];
                        cardAll[i] = temp;
                    }
                }
            }

            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 6 - j; i++)
                {
                    if (cardAll[i].cardNum % 13 == cardAll[i + 1].cardNum % 13)
                    {
                        if (cardAll[i].cardNum / 13 > cardAll[i + 1].cardNum / 13)
                        {
                            Card temp = cardAll[i + 1];
                            cardAll[i + 1] = cardAll[i];
                            cardAll[i] = temp;
                        }
                    }
                }
            }

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4 - j; i++)
                {
                    if (cardAll[i + 7].cardNum % 13 > cardAll[i + 8].cardNum % 13)
                    {
                        Card temp = cardAll[i + 8];
                        cardAll[i + 8] = cardAll[i + 7];
                        cardAll[i + 7] = temp;
                    }
                }
            }

            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4 - j; i++)
                {
                    if (cardAll[i + 7].cardNum % 13 == cardAll[i + 8].cardNum % 13)
                    {
                        if (cardAll[i + 7].cardNum / 13 > cardAll[i + 8].cardNum / 13)
                        {
                            Card temp = cardAll[i + 8];
                            cardAll[i + 8] = cardAll[i + 7];
                            cardAll[i + 7] = temp;
                        }
                    }
                }
            }
        }
        // 배열


        // 컴퓨터  
        void Level()
        {
            Sort();
            // 로티플 체크
            for(int i = 0; i < 3; i++)
            {
                if (cardAll[i].cardNum % 13 == 8 
                    && cardAll[i+1].cardNum % 13 == 9 
                    && cardAll[i+2].cardNum % 13 == 10 
                    && cardAll[i + 3].cardNum % 13 == 11 
                    && cardAll[i + 4].cardNum % 13 == 12)
                {
                    if ((cardAll[i].cardNum / 13 == cardAll[i+1].cardNum / 13) 
                        && (cardAll[i+1].cardNum / 13 == cardAll[i+2].cardNum / 13)
                        && (cardAll[i+2].cardNum / 13 == cardAll[i+3].cardNum / 13)
                        && (cardAll[i+3].cardNum / 13 == cardAll[i+4].cardNum / 13 ))
                    {
                        isRoyalStraight += 1;
                        return;
                    }
                    else
                    {
                        isStraight += 1;
                    }
                }
            }

            // 스티플 체크
            for (int i = 0; i < 3; i++)
            {
                if ((cardAll[i].cardNum % 13 + 1 == cardAll[i + 1].cardNum % 13)
                        && (cardAll[i + 1].cardNum % 13 +1 == cardAll[i + 2].cardNum % 13)
                        && (cardAll[i + 2].cardNum % 13 +1 == cardAll[i + 3].cardNum % 13)
                        && (cardAll[i + 3].cardNum % 13 +1 == cardAll[i + 4].cardNum % 13))
                {
                    if ((cardAll[i].cardNum / 13 == cardAll[i + 1].cardNum / 13)
                        && (cardAll[i + 1].cardNum / 13 == cardAll[i + 2].cardNum / 13)
                        && (cardAll[i + 2].cardNum / 13 == cardAll[i + 3].cardNum / 13)
                        && (cardAll[i + 3].cardNum / 13 == cardAll[i + 4].cardNum / 13))
                    {
                        isStraightFlush += 1;
                        return;
                    }
                    else
                    {
                        isStraight += 1;
                    }
                }
            }

            // 포카드 체크
            for ( int i = 0; i < 4;  i++ )
            {
                if (cardAll[i].cardNum % 13 == cardAll[i+3].cardNum % 13)
                {
                    isFourCard += 1;
                    return;
                }
            }

            // 풀하우스 체크
            for ( int i =0; i < 5;i++ )
            {
                if (cardAll[i].cardNum % 13 == cardAll[i+2].cardNum % 13)
                {
                    for ( int j = i+3; j < 4; j++ )
                    {
                        if (cardAll[j].cardNum % 13 == cardAll[j+1].cardNum % 13)
                        {
                            isFullHouse += 1;
                            return;
                        }
                        else
                        {
                            isTriple += 1;
                        }
                    }
                }
            }

            // 풀하우스 체크 2
            for ( int i = 0;i < 3;i++ )
            {
                if (cardAll[i].cardNum % 13 == cardAll[i+1].cardNum % 13)
                {
                    for ( int j = i+2; j < 3; j++ )
                    {
                        if (cardAll[j].cardNum % 13 == cardAll[j+2].cardNum % 13)
                        {
                            isFullHouse += 1;
                            return;
                        }
                    }
                }
            }


            int clover = 0;
            int heart = 0;
            int diamond = 0;
            int spade = 0;
            // 플러쉬 체크
            for ( int i = 0; i < 7;i++ ) // 클로버
            {
                if (cardAll[i].cardNum / 13 == 0 )
                {
                    clover++;
                }
                if ( clover >= 5)
                {
                    isFlush += 1;
                    return;
                }
            }

            for ( int i = 0; i < 7 ;i++ ) // 하트
            {
                if (cardAll[i].cardNum / 13 == 1)
                {
                    heart++;
                }
                if ( heart >= 5)
                {
                    isFlush += 1;
                    return;
                }
            }

            for (int i = 0; i < 7; i++) // 다이아
            {
                if (cardAll[i].cardNum / 13 == 2)
                {
                    diamond++;
                }
                if (diamond >= 5)
                {
                    isFlush += 1;
                    return;
                }
            }

            for (int i = 0; i < 7; i++) // 스페이드
            {
                if (cardAll[i].cardNum / 13 == 3)
                {
                    spade++;
                }
                if (spade >= 5)
                {
                    isFlush += 1;
                    return;
                }
            }


            // 투페어 원페어 체크
            for ( int i = 0; i < 6; i++)
            {
                if (cardAll[i].cardNum % 13 == cardAll[i+1].cardNum % 13)
                {
                    for ( int j = i+2; j < 4; j++ )
                    {
                        if (cardAll[j].cardNum % 13 == cardAll[j+1].cardNum % 13)
                        {
                            isTwoPair += 1;
                            return;
                        }
                        else
                        {
                            isOnePair += 1;
                            return;
                        }
                    }
                }
            }

        }
        // 컴퓨터


        // 유저
        void UserLevel ()
        {
            Sort();
            // 로티플 체크
            for (int i = 0; i < 3; i++)
            {
                if (cardAll[i].cardNum % 13 == 8
                    && cardAll[i + 1].cardNum % 13 == 9
                    && cardAll[i + 2].cardNum % 13 == 10
                    && cardAll[i + 3].cardNum % 13 == 11
                    && cardAll[i + 4].cardNum % 13 == 12)
                {
                    if ((cardAll[i].cardNum / 13 == cardAll[i + 1].cardNum / 13)
                        && (cardAll[i + 1].cardNum / 13 == cardAll[i + 2].cardNum / 13)
                        && (cardAll[i + 2].cardNum / 13 == cardAll[i + 3].cardNum / 13)
                        && (cardAll[i + 3].cardNum / 13 == cardAll[i + 4].cardNum / 13))
                    {
                        isRoyalStraight += 1;
                        return;
                    }
                    else
                    {
                        isStraight += 1;
                    }
                }
            }

            // 스티플 체크
            for (int i = 0; i < 3; i++)
            {
                if ((cardAll[i].cardNum % 13 + 1 == cardAll[i + 1].cardNum % 13)
                        && (cardAll[i + 1].cardNum % 13 + 1 == cardAll[i + 2].cardNum % 13)
                        && (cardAll[i + 2].cardNum % 13 + 1 == cardAll[i + 3].cardNum % 13)
                        && (cardAll[i + 3].cardNum % 13 + 1 == cardAll[i + 4].cardNum % 13))
                {
                    if ((cardAll[i].cardNum / 13 == cardAll[i + 1].cardNum / 13)
                        && (cardAll[i + 1].cardNum / 13 == cardAll[i + 2].cardNum / 13)
                        && (cardAll[i + 2].cardNum / 13 == cardAll[i + 3].cardNum / 13)
                        && (cardAll[i + 3].cardNum / 13 == cardAll[i + 4].cardNum / 13))
                    {
                        isStraightFlush += 1;
                        return;
                    }
                    else
                    {
                        isStraight += 1;
                    }
                }
            }

            // 포카드 체크
            for (int i = 0; i < 4; i++)
            {
                if (cardAll[i].cardNum % 13 == cardAll[i + 3].cardNum % 13)
                {
                    isFourCard += 1;
                    return;
                }
            }

            // 풀하우스 체크
            for (int i = 0; i < 5; i++)
            {
                if (cardAll[i].cardNum % 13 == cardAll[i + 2].cardNum % 13)
                {
                    for (int j = i + 3; j < 4; j++)
                    {
                        if (cardAll[j].cardNum % 13 == cardAll[j + 1].cardNum % 13)
                        {
                            isFullHouse += 1;
                            return;
                        }
                        else
                        {
                            isTriple += 1;
                        }
                    }
                }
            }

            // 풀하우스 체크 2
            for (int i = 0; i < 3; i++)
            {
                if (cardAll[i].cardNum % 13 == cardAll[i + 1].cardNum % 13)
                {
                    for (int j = i + 2; j < 3; j++)
                    {
                        if (cardAll[j].cardNum % 13 == cardAll[j + 2].cardNum % 13)
                        {
                            isFullHouse += 1;
                            return;
                        }
                    }
                }
            }


            int clover = 0;
            int heart = 0;
            int diamond = 0;
            int spade = 0;
            // 플러쉬 체크
            for (int i = 0; i < 7; i++) // 클로버
            {
                if (cardAll[i].cardNum / 13 == 0)
                {
                    clover++;
                }
                if (clover >= 5)
                {
                    isFlush += 1;
                    return;
                }
            }

            for (int i = 0; i < 7; i++) // 하트
            {
                if (cardAll[i].cardNum / 13 == 1)
                {
                    heart++;
                }
                if (heart >= 5)
                {
                    isFlush += 1;
                    return;
                }
            }

            for (int i = 0; i < 7; i++) // 다이아
            {
                if (cardAll[i].cardNum / 13 == 2)
                {
                    diamond++;
                }
                if (diamond >= 5)
                {
                    isFlush += 1;
                    return;
                }
            }

            for (int i = 0; i < 7; i++) // 스페이드
            {
                if (cardAll[i].cardNum / 13 == 3)
                {
                    spade++;
                }
                if (spade >= 5)
                {
                    isFlush += 1;
                    return;
                }
            }


            // 투페어 원페어 체크
            for (int i = 0; i < 6; i++)
            {
                if (cardAll[i].cardNum % 13 == cardAll[i + 1].cardNum % 13)
                {
                    for (int j = i + 2; j < 4; j++)
                    {
                        if (cardAll[j].cardNum % 13 == cardAll[j + 1].cardNum % 13)
                        {
                            isTwoPair += 1;
                            return;
                        }
                        else
                        {
                            isOnePair += 1;
                            return;
                        }
                    }
                }
            }

        }
        // 유저
    
    }
}    
