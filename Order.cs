using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Order
    {
        public string OrderDate = "";
        public Item item;
        public Order(string _OrderDate, Item _item)
        {
            OrderDate = _OrderDate;
            item = _item;
        }
    }
}
