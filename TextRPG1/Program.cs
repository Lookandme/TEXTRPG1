using System.Collections.Specialized;
using System.Reflection.Metadata;

namespace TextRPG1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // _______________________________

            GameManager gameManager = new GameManager();

            List<Item> items = new List<Item>();
            items.Add(new Item("수련자 갑옷", "수련에 도움을 주는 갑옷입니다.", "방어력", 5, 1000, false, false));
            items.Add(new Item("수련자 갑옷", "수련에 도움을 주는 갑옷입니다.", "방어력", 5, 1000, true, true));
            items.Add(new Item("무쇠갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", "방어력", 9, 2000, false, false));
            items.Add(new Item("스파르타의 갑옷", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", "방어력", 15, 3500, false, false));
            items.Add(new Item("낡은 검", "쉽게 볼 수 있는 낡은 검 입니다.", "공격력", 2, 600, true, true));
            items.Add(new Item("청동 도끼", "어디선가 사용됐던거 같은 도끼입니다.", "공격력", 5, 1500, false, false));
            items.Add(new Item("스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다. ", "공격력", 7, 3500, false, false));

            // 캐릭터 객체 생성
            Character character = new Character(1, 10, 5, 100, 3000); // 플레이어 객체 생성
            
            // 게임 시작
            gameManager.StartScreen(character, items);
        }
    }
}