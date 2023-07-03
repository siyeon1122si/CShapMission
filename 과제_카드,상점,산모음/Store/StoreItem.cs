using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_230619
{
    public class StoreItem
    {
        public string itemName;
        public int itemPrice;

        public void InitItem(string name, int price)

        {
            itemName = name;
            itemPrice = price;
        }
    }
}
