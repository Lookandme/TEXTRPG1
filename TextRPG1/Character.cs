using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG1
{
    public class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Health { get; set; }
        public int Gold { get; set; }

        public Character(int level, int attack, int defense, int health, int gold)
        {
            Name = "void";
            Class = "void";
            Level = level;
            Attack = attack;
            Defense = defense;
            Health = health;
            Gold = gold;
        }

        // 상태창 메소드
        public void Parameter(Character character, Inventory inventory, List<Item> items)
        {
            while (true)
            {
                GameManager gameManager = new GameManager();
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("상태창을 표시");
                Console.WriteLine("\n");
                Console.WriteLine("캐릭터의 현재 상태를 표시합니다");
                Console.WriteLine("Lv " + character.Level);
                Console.WriteLine("이름: " + character.Name);
                Console.WriteLine("Chad: " + character.Class);
                Console.WriteLine("공격력: " + character.Attack);// + "(" + items.ItemEquipStusNum + ")"); // 장착 된 아이템 수치 를 받아서 적용
                Console.WriteLine("방어력: " + character.Defense);// + "(" + items.ItemEquipStusNum + ")");
                Console.WriteLine("체력: " + character.Health);
                Console.WriteLine("Gold: " + character.Gold);
                Console.WriteLine("\n\n");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("\n\n");
                Console.WriteLine("원하는 행동을 입력해 주세요.");
                Console.Write(">>> ");

                if (gameManager.InputManager(0, 0) == 0)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}