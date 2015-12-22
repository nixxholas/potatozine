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
    public partial class ItemInfo : Form
    {
        public ItemInfo()
        {
            InitializeComponent();

        }

        public string curname;

        //cart object
        CartGUI myCart = new CartGUI();

        //Method to load/insert picture, name, description, price etc. into the page
        public void LoadInfo(string imgURL, string name, string desc, double price) {
            PicItemInfo.Load(imgURL); //Sets the picture in the iteminfo
            lblProdNam.Text = name; //Changes the text for product name
            txtProdDesc.Text = desc; //Changes the text in the textbox for product description
            txtPrice.Text = System.Convert.ToString(price);//Changes the text for pricing
        }


        //Back to catalogue button click
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();//Closes the iteminfo form
        }

        //Code to run when add to cart is clicked
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            int quantity = (int)numQuantity.Value;
            if (quantity != 0) {
                for (int count = 0; count < quantity; count++) {
                    CartGUI.myItems.Add(lblProdNam.Text);
                    //myCart.updatetotal(Convert.ToDouble(txtPrice.Text));
                    MessageBox.Show("Added to cart");
                }
            } else
            {
                MessageBox.Show("ERROR FUCK OFF");
            }
        }


    }
}
