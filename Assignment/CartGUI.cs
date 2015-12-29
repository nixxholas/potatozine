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
        public static double viewtotal = 0.0;
        public static List<string> myItems = new List<string>();
        public static List<double> itemPrice = new List<double>();

        //Code to additem
        public void addItem(string item, double price)
        {
            myItems.Add(item);
            itemPrice.Add(price);
        }

        //Code to referesh
        private void refBtn_Click(object sender, EventArgs e)
        {
            lstCart.DataSource = null;
            lstCart.DataSource = myItems;
            calTotal();
            txtTotal.Text = System.Convert.ToString(this.total);
        }

        //Code to empty cart
        private void btnCartRem_Click(object sender, EventArgs e)
        {
            myItems = null;
            txtTotal.Text = "0";
            lstCart.DataSource = myItems;
            itemPrice = null;
        }

        //Code to calculate total
        private double calTotal()
        {
            double price = 0.0;
            this.total = 0;
            if (itemPrice != null)
            {
                foreach (double i in itemPrice)
                {
                    this.total += i;
                }
            }
            viewtotal = price;
            return price;
        }

        //Code check if there is things to checkout
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                MessageBox.Show("There is nothing to checkout with.");
            }
            else
            {
                chkout.Show();
                chkout.Total = this.total;
                this.Hide();
                Receipt.loadData();
            }

        }

        //Code for removing item.
        private void button2_Click(object sender, EventArgs e)
        {
            int index = this.lstCart.SelectedIndex;
            string selected = lstCart.SelectedValue.ToString();
            myItems.Remove(selected);
            itemPrice.RemoveAt(index);
            calTotal();
        }
    }
}