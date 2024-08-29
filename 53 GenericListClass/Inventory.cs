using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_GenericListClass
{
    internal class Inventory
    {
        private List<Item> items; //필드에 리스트 변수를 정의
        public Inventory() 
        {
            this.items = new List<Item>(); //생성자에서 리스트 인스턴스를 생성해서 필드에 할당 
        }

        public void AddItem(Item item) // Additem의 매개변수에 Item 개체를 받고
        {
            this.items.Add(item); // 리스트에 추가
        }

        public Item GetItem(string name)
        {
            Item foundItem = null;
            //return null; //문자열로 가장 먼저 찾은 아이템을 반환
            foreach (var item in this.items)
            {
                if (item.Name == name) 
                {
                    foundItem = item; //찾은 아이템을 변수에 임시 할당
                    this.items.Remove(foundItem);
                    break;
                }
            }
            return foundItem;
        }
        public int GetCount()
        {
            return this.items.Count;
        }

        public void DisplayItem()
        {
            foreach (Item item in this.items)
            {
                Console.WriteLine(item.Name);
            }
    }
}
