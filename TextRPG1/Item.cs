using System.Reflection.Emit;

namespace TextRPG1
{

    public class Item
    {
        
        public string Itemname { get; set; } // 아이템 이름
        public string ItemInform { get; set; } // 아이템 설명
        public string ItemStatus { get; set; } // 공격력 or 방어력
        public int ItemStatusNum { get; set; } // 공격력 or 방어력 수치
        public int Itemprice { get; set; } // 가격
        public bool ItemBuy { get; set; } // 구매 여부
        public bool ItemEquip { get; set; } // 장착 여부


        public Item[] itemList;



        // 값 대입 생성자
        public Item(string itemname, string ItemInform, string itemStatus, int itemStatusNum, int itemprice, bool itemBuy, bool itemEquip)
        {
            this.Itemname = itemname;
            this.ItemInform = ItemInform;
            this.ItemStatus = itemStatus;
            this.ItemStatusNum = itemStatusNum;
            this.Itemprice = itemprice;
            this.ItemBuy = itemBuy;
            this.ItemEquip = itemEquip;

        }

        // 기본 생성자
        public Item()
        {
            this.Itemname = "void";
            this.ItemInform = "void";
            this.ItemStatus = "void";
            this.ItemStatusNum = 0;
            this.Itemprice = 100;
            this.ItemBuy = false;
            this.ItemEquip = false;

        }

        


        public void Itemview()
        {
            Console.WriteLine("아이템 명: " + Itemname);
            Console.WriteLine("아이템 가격: " + Itemprice);
        }

        public void AddItem()
        {
            // 아이템 목록 객체 생성
            itemList = new Item[100]; // 아이템 클래스 배열
            //itemList[0] = new Item("수련자 갑옷", "수련에 도움을 주는 갑옷입니다.", "방어력", 5, 1000, false, false);
            itemList[1] = new Item("수련자 갑옷", "수련에 도움을 주는 갑옷입니다.", "방어력", 5, 1000, true, false);
            itemList[2] = new Item("무쇠갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", "방어력", 9, 2000, false, false);
            itemList[3] = new Item("스파르타의 갑옷", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", "방어력", 15, 3500, false, false);
            itemList[4] = new Item("낡은 검", "쉽게 볼 수 있는 낡은 검 입니다.", "공격력", 2, 600, true, false);
            itemList[5] = new Item("청동 도끼", "어디선가 사용됐던거 같은 도끼입니다.", "공격력", 5, 1500, false, false);
            itemList[6] = new Item("스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다. ", "공격력", 7, 3500, false, false);
            itemList[7] = new Item("스파르타의 망토", "스파르타의 전사들의 피로 물든 망토입니다.", "공격력",0,2000, false, false);

        }
    }
}