﻿using System;
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

        public void addItem(string item)
        {
            myItems.Add(item);
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            lstCart.DataSource = myItems;
        }

        private void btnCartRem_Click(object sender, EventArgs e)
        {
            myItems = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chkout.Show();
            chkout.Total = this.total;
        }
    }
}
