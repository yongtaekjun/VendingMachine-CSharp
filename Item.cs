using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Item
    {
        public string code = "";
        public string title = "";
        public double price = 0.0;
        public Item ( string code, string title, double price)
        {
            this.code = code;
            this.title = title;
            this.price = price;
        }
        //Item( Item &item)
        //{
        //    this.code = item.code;
        //    this.title = item.title;
        //    this.price = item.price;
        //}

    }
}
