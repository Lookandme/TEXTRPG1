using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG1
{
    public class GameManager
    {
     

        public int InputManager(int start, int end)
        {
            while (true)
            {
                int select = int.Parse(Console.ReadLine());

                if ((start <= select) && (select <= end))
                {
                    return select;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.Write(">>> ");
                    continue;
                    
                }
            }
        }

        // 시작 화면 메소드
        public void StartScreen(Character character, Item item)
        {
           

            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("\n");
            Console.WriteLine("당신의 이름을 말해주세요.");
            Console.WriteLine("\n");
            Console.Write(">>> ");
            character.Name = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            // 이름 적기
            ChoiceClass(character, item);
        }

        // 캐릭터 선택창 메소드
        public void ChoiceClass(Character character, Item item)
        {
            

            while (true)
            { 
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("직업을 선택해주세요.");
            Console.WriteLine("\n");
            Console.WriteLine("[1] 전사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 도적");
            Console.WriteLine("[4] 사제");
            Console.WriteLine("\n");
            Console.Write(">>> ");

                // 직업선택
                switch (InputManager(1, 4))
                {
                    case 1:
                        {
                            character.Class = "전사";
                            break;
                        }
                    case 2:
                        {
                            character.Class = "궁수";
                            break;
                        }
                    case 3:
                        {
                            character.Class = "도적";
                            break;
                        }
                    case 4:
                        {
                            character.Class = "사제";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("잘못된 입력입니다");
                            break;
                        }

                }

                Console.WriteLine(" ");
                Console.WriteLine(character.Class + " 를 선택하셨습니다\n");
                Thread.Sleep(2000);

                Village(character, item);
            }
        }

        // 마을 화면 메소드
        public void Village(Character character, Item item)
        {
            Inventory inventory = new Inventory();
            Store store = new Store();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("어서오세요 스파르타마을에 오신 여러분들을 환영합니다");
                Console.WriteLine("\n");
                Console.WriteLine("이곳에서는 던전에 들어가기 전 행동을 할 수 있습니다");
                Console.WriteLine("\n");
                Console.WriteLine("\n");
                Console.WriteLine("1. 상태창 열기");
                Console.WriteLine("\n");
                Console.WriteLine("2. 인벤토리 열기");
                Console.WriteLine("\n");
                Console.WriteLine("3. 상점으로 가기");
                Console.WriteLine("\n\n\n");
                Console.WriteLine("원하는 행동을 결정해주세요");
                Console.Write(">> ");


                switch (InputManager(1, 3))
                {
                    case 1:
                        // 상태창열기
                        character.Parameter(character, inventory, item);
                        break;
                    case 2:
                        // 인벤열기
                        inventory.Inven(item, character);
                        break;
                    case 3:
                        // 상점열기
                        store.UsingStore(item, character);
                        break;

                }
            }
        }
    }
}