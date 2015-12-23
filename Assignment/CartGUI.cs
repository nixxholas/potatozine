using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CartGUI : Form
    {
        public CartGUI()
        {
            InitializeComponent();
        }

        //Object for payment
        Payment chkout = new Payment();

        private void btnBackShop_Click(object sender, EventArgs e)
        {
            this.Hide();//Closes the cart page
        }

        private double total = 0.0;

        public static List<string> myItems = new List<string>();
        public static List<double> itemPrice = new List<double>();

        public void addItem(string item, double price)
        {
            myItems.Add(item);
            itemPrice.Add(price);
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            lstCart.DataSource = myItems;
            calTotal();
            txtTotal.Text = System.Convert.ToString(this.total);
        }

        private void btnCartRem_Click(object sender, EventArgs e)
        {
            myItems = null;
        }
        
        private double calTotal() {
            double price = 0.0;
            foreach (double i in itemPrice) {
                this.total += i;
            }
            return price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chkout.Show();
            chkout.Total = this.total;
        }
    }
}
