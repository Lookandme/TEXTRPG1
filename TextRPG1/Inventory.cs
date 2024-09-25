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
        public void Inven(Item item, Character character)
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

                for (int i = 1; item.itemList[i] != null; i++)
                {
                    if (item.itemList[i].ItemBuy == true)
                    {
                        Console.Write($"-");

                        if (item.itemList[i].ItemEquip == true)
                        {
                            Console.Write("[E]");
                            
                            
                        }
                        Console.Write($"{item.itemList[i].Itemname} \t| {item.itemList[i].ItemStatus} +{item.itemList[i].ItemStatusNum} | {item.itemList[i].ItemInform}\n");
                    }
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
                        inventory.ItemManage(item, character);
                        break;
                }
            }
        }

        // 장착 관리 메소드
        public void ItemManage(Item item, Character character)
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
                for (int i = 1; (item.itemList[i] != null); i++)
                {
                    count++;
                    if (item.itemList[i].ItemBuy == true)
                    {
                        Console.Write($"- {i} ");

                        if (item.itemList[i].ItemEquip == true)
                        {
                            Console.Write("[E]");

                            
                        }
                        Console.Write($"{item.itemList[i].Itemname} \t| {item.itemList[i].ItemStatus} +{item.itemList[i].ItemStatusNum} | {item.itemList[i].ItemInform}\n");
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
                    gameManager.Village(character, item);
                }
                else
                {
                    // 장착되어있으면 -> 해제
                    if (item.itemList[num].ItemEquip == true)
                    {
                        item.itemList[num].ItemEquip = false;

                        if (item.itemList[num].ItemStatus == "공격력")
                        {
                            character.ItemEquipStusNumat = 0;
                        }
                        else if (item.itemList[num].ItemStatus == "방어력")
                        {
                            character.ItemEquipStusNumdf = 0;
                        }
                    }
                    else  // 없으면 장착으로
                    { 
                        item.itemList[num].ItemEquip = true;

                        if (item.itemList[num].ItemStatus == "공격력")
                        {
                            character.ItemEquipStusNumat = item.itemList[num].ItemStatusNum;
                        }
                        else if (item.itemList[num].ItemStatus == "방어력")
                        {
                            character.ItemEquipStusNumdf = item.itemList[num].ItemStatusNum;
                        }
                    }
                }
            }
        }
    }

}


