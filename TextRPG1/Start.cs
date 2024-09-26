using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG1
{
    static public class Start
    {
        // 마을 행동 선택 메서드
        public static void Startmap()
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

            int selec = int.Parse(Console.ReadLine()!);

        }
    }
}