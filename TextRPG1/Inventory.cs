using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TextRPG1
{
    public class Inventory
    {
        public Inventory()
        {

        }


        // 인벤 기능 추가 예정
        public void Inven(List<Item> items, Character character)
        {
            GameManager gameManager = new GameManager();
            Inventory inventory = new Inventory();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                // 코드 삭제

                // 코드 이동
                Console.WriteLine("인벤토리");
                Console.WriteLine("\n\n");
                Console.WriteLine("인벤토리를 관리할 수 있습니다");
                Console.WriteLine("\n");
                Console.WriteLine("[ 아이템 목록 ]");
                Console.WriteLine("\n");

                foreach (Item item in items)
                {
                    Console.Write($"- {item.Itemname} \t| {item.ItemStatus} + {item.ItemStatusNum} | {item.ItemInform}\n");
                }

                Console.WriteLine("\n\n");
                Console.WriteLine("1. 장착 관리");
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
                        // 아이템 관리창 열기
                        inventory.ItemManage(items, character);
                        break;
                }
            }
        }

        // 장착 관리 메소드
        public void ItemManage(List<Item> items, Character character)
        {
            GameManager gameManager = new GameManager();

            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                int count = 0;
                Console.WriteLine("인벤토리 - 장착관리");
                Console.WriteLine("\n\n");
                Console.WriteLine("인벤토리를 관리할 수 있습니다");
                Console.WriteLine("\n");
                Console.WriteLine("[ 아이템 목록 ]");
                Console.WriteLine("\n");
                foreach (Item item in items)
                {
                    count++;
                    if (item.ItemBuy == true)
                    {
                        Console.Write($"- {count} ");

                        if (item.ItemEquip == true)
                        {
                            Console.Write("[E]");

                            Console.WriteLine($"{item.Itemname} \t| {item.ItemStatus} +{item.ItemStatusNum} | {item.ItemInform}");


                            item.ItemStatusNum = item.ItemEquipStusNum;
                        }

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
                    // 장착되어있으면 -> 장착으로
                    if (items[num-1].ItemEquip == true)
                        items[num-1].ItemEquip = false;
                    else
                        items[num-1].ItemEquip = true;
                }
            }
        }
    }

}


