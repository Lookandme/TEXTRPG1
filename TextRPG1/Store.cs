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
        public void UsingStore(Item item, Character character)
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

                for (int i = 1; item.itemList[i] != null; i++)
                {
                    Console.Write($"- {item.itemList[i].Itemname} \t| {item.itemList[i].ItemStatus} +{item.itemList[i].ItemStatusNum} | {item.itemList[i].ItemInform}\n");
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
                        store.UsingStore_BuyItem(item, character);
                        break;
                }
            }
        }

        public void UsingStore_BuyItem(Item item, Character character)
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
                for (int i = 1; item.itemList[i] != null; i++)
                {
                    count++;
                    Console.Write($"- {i} ");
                    Console.Write($"{item.itemList[i].Itemname} \t| {item.itemList[i].ItemStatus} +{item.itemList[i].ItemStatusNum} | {item.itemList[i].ItemInform} | ");

                    if (item.itemList[i].ItemBuy == true)
                    {
                        Console.WriteLine(" 구매완료");
                    }
                    else
                    {
                        Console.WriteLine(item.itemList[i].Itemprice);
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
                    if (item.itemList[num].ItemBuy == false)
                    {
                        if (character.Gold >= item.itemList[num].Itemprice)
                        {
                            item.itemList[num].ItemBuy = true;
                            character.Gold -= item.itemList[num].Itemprice;
                        }
                        else
                        {
                            Console.Write($"{item.itemList[num].Itemprice - character.Gold} ");
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
