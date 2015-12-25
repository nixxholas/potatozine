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

        public static String[] itemArr = new String[50];
        public static List<string> myItems = new List<string>();
        public static List<double> itemPrice = new List<double>();
        

        public void refresherorb()
        {
            lstCart.DataSource = myItems;
            
        }

        public void remfList(int index)
        {
            //code to remove from listbox as well
            myItems.RemoveAt(index);
            lstCart.DataSource = itemArr;
            
        }

        public void addItem(string item, double price)
        {
            myItems.Add(item);
            itemPrice.Add(price);
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            lstCart.DataSource = itemArr;
            calTotal();
            txtTotal.Text = System.Convert.ToString(this.total);
        }

        private void btnCartRem_Click(object sender, EventArgs e)
        {
            Array.Clear(itemArr, 0, itemArr.Length);
            myItems = null;
            txtTotal.Text = "0";
            lstCart.DataSource = itemArr;
            itemPrice = null;
        }
        
        private double calTotal() {
            double price = 0.0;
            this.total = 0;
            if (itemPrice != null)
            {
                foreach (double i in itemPrice)
                {
                    this.total += i;
                }
            }
            return price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text == "0")
            {
                MessageBox.Show("There is nothing to checkout with.");
            } else
            {
                chkout.Show();
                chkout.Total = this.total;
                this.Hide();
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach (ListViewItem i in lstViewCart.SelectedItems)
            //  lstViewCart.Items.Remove(i);
            
            /**

            **/
            if (this.lstCart.SelectedIndex > -1)
            {
                int index = this.lstCart.SelectedIndex;
                MessageBox.Show(index.ToString());
                myItems.RemoveAt(index);
                //String selected = lstCart.SelectedValue.ToString();
                //MessageBox.Show(myItems.ToString());
                //myItems.Remove(selected);
                lstCart.DataSource = myItems;
                //MessageBox.Show(myItems.ToString());
            }

        }
    }
}
