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
            int bumpcheck = 0;
                for (int count = 0; count < quantity; count++) {
                    CartGUI.myItems.Add(lblProdNam.Text);
                for (int checker = 0; checker < CartGUI.itemArr.Length; checker++)
                {
                    if (CartGUI.itemArr[checker] == null || CartGUI.itemArr[checker] == "0")
                    {
                        if (bumpcheck < quantity)
                        {
                            CartGUI.itemArr[checker] = lblProdNam.Text;
                        }
                            bumpcheck++;
                    }
                }
                    CartGUI.itemPrice.Add(double.Parse(txtPrice.Text));
                }
                MessageBox.Show("Added to cart");
            this.Hide();
        }


    }
}
