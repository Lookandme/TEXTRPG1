using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG1
{
    public class Store
    {
        // 상점 입장 메소드
        public void UsingStore(List<Item> items, Character character)
        {
            GameManager gameManager = new GameManager();
            Inventory inventory = new Inventory();
            Store store = new Store();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("상점");
                Console.WriteLine("\n\n");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine("\n");
                Console.WriteLine($"[ 골드 ] : {character.Gold}");
                Console.WriteLine("\n");
                Console.WriteLine("[ 아이템 목록 ]");
                Console.WriteLine("\n");

                foreach(Item item in items)
                {
                    Console.Write($"- {item.Itemname} \t| {item.ItemStatus} + {item.ItemStatusNum} | {item.ItemInform}\n");
                }

                Console.WriteLine("\n\n");
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("\n\n");
                Console.WriteLine("원하는 행동을 입력해 주세요.");
                Console.Write(">>> ");

                switch (gameManager.InputManager(0, 1))
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        // 구매 관리창 열기
                        store.UsingStore_BuyItem(items, character);
                        break;
                }
            }
        }

        public void UsingStore_BuyItem(List<Item> items, Character character)
        {
            GameManager gameManager = new GameManager();

            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                int count = 0;
                Console.WriteLine("상점 - 구매");
                Console.WriteLine("\n\n");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine("\n");
                Console.WriteLine($"[ 골드 ] : {character.Gold}");
                Console.WriteLine("\n");
                Console.WriteLine("[ 아이템 목록 ]");
                Console.WriteLine("\n");

                foreach (Item item in items)
                {
                    count++;
                    Console.Write($"- {count} ");
                    Console.WriteLine($"- {item.Itemname} \t| {item.ItemStatus} + {item.ItemStatusNum} | {item.ItemInform}");

                    if (item.ItemBuy == true)
                    {
                        Console.WriteLine(" 구매완료");
                    }
                    else
                    {
                        Console.WriteLine(item.Itemprice);
                    }
                }

                Console.WriteLine("\n\n");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("\n\n");
                Console.WriteLine("원하는 행동을 입력해 주세요.");
                Console.Write(">>> ");

                int num = gameManager.InputManager(0, count);

                if (num == 0)
                {
                    exit = true;
                }
                else
                {
                    if (items[num-1].ItemBuy == false)
                    {
                        if (character.Gold >= items[num-1].Itemprice)
                        {
                            items[num-1].ItemBuy = true;
                            character.Gold -= items[num-1].Itemprice;
                        }
                        else
                        {
                            Console.Write($"{items[num-1].Itemprice - character.Gold} ");
                            Console.WriteLine("Gold 만큼 부족합니다.");
                            Thread.Sleep(1000);
                        }
                    }
                    else
                    {
                        Console.WriteLine("이미 구매한 아이템입니다.");
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
