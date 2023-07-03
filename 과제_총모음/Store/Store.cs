using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_230619
{
    public class Store
    {
        Map map1 = new Map();

        private Dictionary<string, int> allItems = new Dictionary<string, int>()
        {
            { "HP물약      ", 10 },
            { "MP물약      ", 10 },
            { "망고의 가시  ", 500 }, 
            { "망고의 털    ", 300 }, 
            { "망고의 장난감 ", 600 } 
        };

        public void StoreOpen(ref int coin)
        {
            Console.WriteLine();
            Console.WriteLine("상점에 도착하였습니다.");

            while (coin > 0)
            {
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("가지고 있는 코인: " + coin);
                Console.WriteLine("구매 가능한 아이템:");

                List<string> availableItems = GetRandomItems(3);

                for (int i = 0; i < availableItems.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + availableItems[i] + " - " + allItems[availableItems[i]] + " 코인");
                }

                Console.WriteLine();
                Console.WriteLine("구매할 아이템 번호를 선택하세요 (N: 나가기):");
                Console.WriteLine();
                string input = Console.ReadLine();

                if (input.ToUpper() == "N")
                {
                    Console.WriteLine();
                    Console.WriteLine("아무키나 누르면 상점을 나갑니다.");
                    Console.ReadLine();


                    Console.Clear();
                    map1.MapOpen(ref coin);
                    break;
                }

                int itemNumber;
                if (int.TryParse(input, out itemNumber) && itemNumber >= 1 && itemNumber <= availableItems.Count)
                {
                    string selectedItem = availableItems[itemNumber - 1];
                    int itemPrice = allItems[selectedItem];

                    if (coin >= itemPrice)
                    {
                        coin -= itemPrice;
                        Console.WriteLine(selectedItem + "를 구매하였습니다.");
                        Console.Clear();
                        Console.WriteLine();
                        map1.MapOpen(ref coin);
                        // 구매한 아이템을 인벤토리에 추가
                        // AddToInventory(selectedItem);
                    }
                    else
                    {
                        Console.WriteLine("코인이 부족합니다.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("유효하지 않은 선택입니다.");
                    Console.WriteLine();
                }
            }
        }

        private List<string> GetRandomItems(int count)
        {
            List<string> availableItems = new List<string>(allItems.Keys);
            List<string> randomItems = new List<string>();

            Random random = new Random();
            while (randomItems.Count < count && availableItems.Count > 0)
            {
                int index = random.Next(availableItems.Count);
                randomItems.Add(availableItems[index]);
                availableItems.RemoveAt(index);
            }

            return randomItems;
        }
    }
}