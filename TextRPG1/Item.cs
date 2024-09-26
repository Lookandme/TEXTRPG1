using System.Reflection.Emit;

namespace TextRPG1
{
    public class Item
    {
        public string  Itemname { get; set; } // 아이템 이름
        public string ItemInform { get; set; } // 아이템 설명
        public string ItemStatus { get; set; } // 공격력 or 방어력
        public int     ItemStatusNum {  get; set; } // 공격력 or 방어력 수치
        public int     Itemprice { get; set; } // 가격
        public bool ItemBuy { get; set; } // 구매 여부
        public bool ItemEquip { get; set; } // 장착 여부
        public int ItemEquipStusNum { get; set; } // 장착 아이템의  능력 수치

        // 값 대입 생성자
        public Item(string itemname, string ItemInform, string itemStatus, int itemStatusNum, int itemprice,  bool itemBuy, bool itemEquip)
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

    }
}