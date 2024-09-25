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
            Item item = new Item();
            item.AddItem();

            // 캐릭터 객체 생성
            Character character = new Character(1, 10, 5, 100, 3000); // 플레이어 객체 생성
            
            // 게임 시작
            gameManager.StartScreen(character, item);


        }
    }
}