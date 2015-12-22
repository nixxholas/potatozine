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
            //Problem is that the cartGUI does not inherit from the cart class. So i cannot run it here. mmh. I need it to run when I open the cart.
            listCart();

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
            foreach (string item in cart) {
                MessageBox.Show(item);
            }
        }

        //Method to remove item
        public void removeItem(string name)
        {
            cart.Remove(name);
        }

        //Add items to the listbox
        public void listCart()
        {
            lstCart.DataSource = cart;
        }

        private void BindData()
        {
            lstCart.DataSource = null;
            lstCart.DataSource = cart;
            lstCart.DisplayMember = "Name";
        }

        //Method to get total
        public void updatetotal(double price)
        {
            total += price;
        }

        public double priceLooper()
        {
            double finaltotal = 0;

            /**
            Wait for Qi to have a box for showing the subtotal
            **/

            return finaltotal;
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            lstCart.DataSource = cart;
        }
    }
}
