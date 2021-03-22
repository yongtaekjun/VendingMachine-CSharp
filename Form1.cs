using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        public double dBalance = 0.0;
        public string sOrderCode = "";
        private List<Item> item_list = new List<Item>();
        private List<Order> order_list = new List<Order>();
        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void update_balance()
        {
            //dBalance += 2.0;
            lbBalance.Text = dBalance.ToString("n2");
        }
        private void InitializeData()
        {
            item_list.Add(new Item("A1", "CocaCola 0 ", 1.25));
            item_list.Add(new Item("A2", "CocaCola 1 ", 1.50));
            item_list.Add(new Item("A3", "CocaCola 2 ", 1.75));
            item_list.Add(new Item("A4", "CocaCola 3 ", 2.25));

            item_list.Add(new Item("B1", "Poweraid 0 ", 1.25));
            item_list.Add(new Item("B2", "Poweraid 1 ", 1.50));
            item_list.Add(new Item("B3", "Poweraid 2 ", 1.75));
            item_list.Add(new Item("B4", "Poweraid 3 ", 2.25));

            item_list.Add(new Item("C1", "Sprite 0 ", 1.25));
            item_list.Add(new Item("C2", "Sprite 1 ", 1.50));
            item_list.Add(new Item("C3", "Sprite 2 ", 1.75));
            item_list.Add(new Item("C4", "Sprite 3 ", 2.25));

            item_list.Add(new Item("D1", "Mountain Due 0 ", 1.25));
            item_list.Add(new Item("D2", "Mountain Due 1 ", 1.50));
            item_list.Add(new Item("D3", "Mountain Due 2 ", 1.75));
            item_list.Add(new Item("D4", "Mountain Due 3 ", 2.25));

            // for testing
            //foreach (Item item in item_list) {
            //    tbMessage.Text += item.code + "\r\n";
            //}
        }

        private void bReturn_Click(object sender, EventArgs e)
        {
            int count_of_coin = 0;
            count_of_coin = (int) ( Math.Round (dBalance,2)  / 2.0) ;
            if (count_of_coin > 0 )
            {
                tbMessage.Text += "Tooney : \t" + count_of_coin + "\r\n";
            }
            dBalance -= count_of_coin * 2.0;

            count_of_coin = (int)(Math.Round(dBalance, 2) / 1.0);
            if (count_of_coin > 0)
            {
                tbMessage.Text += "Looney : \t" + count_of_coin + "\r\n";
            }
            dBalance -= count_of_coin * 1.0;

            count_of_coin = (int)(Math.Round(dBalance, 2) / 0.25);
            if (count_of_coin > 0)
            {
                tbMessage.Text += "Quater : \t" + count_of_coin + "\r\n";
            }
            dBalance -= count_of_coin * 0.25;
            count_of_coin = (int)(Math.Round(dBalance, 2) / 0.1);
            if (count_of_coin > 0)
            {
                tbMessage.Text += "Dime : \t" + count_of_coin + "\r\n";
            }
            dBalance -= count_of_coin * 0.1;

            count_of_coin = (int)(Math.Round(dBalance, 2) / 0.05);
            if (count_of_coin > 0)
            {
                tbMessage.Text += "Nickle : \t" + count_of_coin + "\r\n";
            }
            dBalance -= count_of_coin * 0.05;

            count_of_coin = (int)(Math.Round(dBalance, 2) / 0.01);
            if (count_of_coin > 0)
            {
                tbMessage.Text += "Penny : \t" + count_of_coin + "\r\n";
            }
            dBalance -= count_of_coin * 0.01;
            update_balance();
        }
        private void pbTooney_Click(object sender, EventArgs e)
        {
            dBalance += 2.0;
            update_balance();
        }

        private void pbLooney_Click(object sender, EventArgs e)
        {
            dBalance += 1.0;
            update_balance();

        }

        private void pbQuater_Click(object sender, EventArgs e)
        {
            dBalance += 0.25;
            update_balance();

        }

        private void pbDime_Click(object sender, EventArgs e)
        {
            dBalance += 0.1;
            update_balance();

        }

        private void pbNickle_Click(object sender, EventArgs e)
        {
            dBalance += 0.05;
            update_balance();

        }

        private void pbPenny_Click(object sender, EventArgs e)
        {
            dBalance += 0.01;
            update_balance();

        }
        private void get_order_code(char code)
        {
            //sOrderCode.Append<char>( code );
            sOrderCode += code;

            // sOrderCode is consist of 2 charactors
            if ( sOrderCode.Length < 2 )
            {
                return;
            }

            foreach (Item item in item_list)
            {
                // find the item code matched
                //if (String.Compare( sOrderCode, item.code, true) !=0 ) continue;
                if ( sOrderCode != item.code) continue;

                // balance check
                if (dBalance < item.price)
                {
                    tbMessage.Text += item.title + "\t : " + item.price + "\t The Balance is not enough!\r\n";
                    sOrderCode = "";
                    return;
                }
                // if the balance is enough and code is matched
                dBalance -= item.price;
                update_balance(); // display updated balance
                order_list.Add(new Order( (DateTimeOffset.Now).ToString("M/d/yyyy h:mm:ss"), item));
                tbMessage.Text += item.title + "\t : " + item.price + "\r\n";
                // found matched code
                sOrderCode = "";

                return;
            }
            // Incorrect button pressed = incorrect order
            tbMessage.Text += sOrderCode + ": Wrong Button Pressed \t : \r\n";
            sOrderCode = "";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            get_order_code('A');
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            get_order_code('1');
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            get_order_code('B');
        }
    }
}
