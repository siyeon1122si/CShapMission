using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_230614
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int coin = 100000; // 현재 코인

                // 입장 {
                while (true)
                {
                Console.WriteLine();
                Console.Write("아이템은 총 5개가 있습니다. 그 이상 사려고 누르면 당신은 함정에 빠집니다 그래도 상점에 입장하시겠습니까? [Y/N] ");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(); // 키 입력 받기
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.N: // N 선택 시 건너뛰고 다시 while 반복
                            continue;
                        case ConsoleKey.Y: // Y 선택 시 break 로 while 빠져나가기
                            break;
                        default:
                            break;
                    }
                    break;
                }// 입장 }
                CursorPosition(0, 0);

            List<string> buyList = new List<string>(); // 구매한 아이템을 저장하기 위한 문자열 리스트
            while (coin > 0)
            {


                // 딕셔너리로 아이템 이름 및 가격 지정 {
                Dictionary<string, int> allItem = new Dictionary<string, int>();
                allItem.Add("HP물약      ", 10);
                allItem.Add("MP물약      ", 10);
                allItem.Add("망고의 가시  ", 500); // 무기
                allItem.Add("망고의 털    ", 300); // 방어구
                allItem.Add("망고의 장난감 ", 600); // MP증가
                // } 딕셔너리로 아이템 이름 및 가격 지정 



                // 구매 가능 여부 {
                Random rand = new Random(); // 랜덤 생성


                for (int i = 0; i < 3; i++)
                {

                    var buyableItems = allItem.Keys.Except(buyList).ToList(); // 이미 구매한 아이템을 제외한 구매 가능한 아이템의 리스트

                    if (buyableItems.Count == 0) // 구매 가능한 아이템이 없다면 출력 후 break
                    {
                        if ( count == 1 )
                        {
                            Console.WriteLine();
                            Console.WriteLine(" 진짜로 더 살건가요? [ Y / Y ]");
                            Console.ReadLine();
                            count += 1;
                        }
                        Console.WriteLine();
                        Console.WriteLine("더 이상 구매할 수 있는 아이템이 없습니다. 욕심 많은 당신은 무한 루프에 빠졌습니다. ");
                        break;
                    }


                    int index = rand.Next(buyableItems.Count);

                    string itemName = buyableItems[index]; // 선택된 인덱스를 사용하여 buyableItems에서 아이템의 이름 가져오기
                    int itemPrice = allItem[itemName]; // 선택된 아이템의 이름을 사용하여 allItem 딕셔너리에서 해당 아이템의 가격 불러오기

                    if (buyList.Contains(itemName)) // 현재 루프에서 선택된 아이템이 buyList에 이미 포함되어 있는지 확인
                    {
                        i--; // 이미 구매한 아이템이라면 다시 루프를 실행하도록 i 감소
                        continue;
                    }
                    // } 구매 가능 여부

                        Console.WriteLine(" ┌───인벤토리────────────────────────────────────────────────────────────────");
                        Console.WriteLine(" │                                                                          ");
                        Console.WriteLine(" │                                                                          ");
                        Console.WriteLine(" │                                                                          ");
                        Console.WriteLine(" └──────────────────────────────────────────────────────────────────────────");


                    // 아이템 구매 및 코인 표시
                    for (int j = 0; j < buyList.Count; j++)
                    {
                        if (j < 4)
                        {
                            var inventory = buyList[j];
                            CursorPosition(2 + (16 * j), 2);
                            Console.WriteLine("   {0}                      ", buyList[j]);
                        }

                    }
                    CursorPosition(0,8);

                    Console.WriteLine();
                    Console.WriteLine(" ┌───────────────────┐");
                    Console.WriteLine(" │    {0}   ", itemName);
                    Console.WriteLine(" │                   │");
                    Console.WriteLine(" │       {0}         │", itemPrice);
                    Console.WriteLine(" └───────────────────┘");
                    Console.WriteLine();

                    Console.Write("구매하시겠습니까? [Y/N] ");

                    ConsoleKeyInfo buyListKeyInfo = Console.ReadKey(); // 유저의 키 입력을 받아오기

                    Console.WriteLine();
                    switch (buyListKeyInfo.Key)
                    {
                        case ConsoleKey.Y: // Y 선택 시 아이템 구매
                            if (coin >= itemPrice)
                            {
                                coin -= itemPrice;
                                buyList.Add(itemName); // 유저가 아이템을 구매했을 때, 해당 아이템을 buyList에 추가
                                Console.WriteLine(itemName + "을(를) 구매했습니다.");
                            }
                            else
                            {
                                Console.WriteLine("코인이 부족합니다.");
                            }
                            break;
                        case ConsoleKey.N: // N 선택  시 break
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("남은 코인: " + coin);
                    Console.ReadLine();
                    Console.Clear();
                }
                
            }
        }

        static void CursorPosition(int x, int y) // 화면 안깜빡이게 하는거
        {
            Console.SetCursorPosition(x, y);
        }
    }
}