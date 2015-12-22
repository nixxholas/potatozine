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

        private void btnBackShop_Click(object sender, EventArgs e)
        {
            this.Hide();//Closes the cart page
        }

        private double total = 0.0;

        List<string> cart = new List<string>();
        List<double> price = new List<double>();

        //Method to add item
        public void addItem(string name)
        {
            cart.Add(name);
        }

        //Method to remove item
        public void removeItem(string name)
        {
            cart.Remove(name);
        }

        /**
        //Add items to the listbox
        public void listCart()
        {
            lstCart.DataSource = cart;
        }
    **/

        //Method to get total
        public void updatetotal(double price)
        {
            total += price;
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            lstCart.Items.Clear();
            lstCart.DataSource = cart;
        }
    }
}
