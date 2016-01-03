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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
            ReceiptBox.Text = listReceipt;
            lblTotal.Text += Payment.total4Receipt;
        }

        public static int receiptcount;
        public static String listReceipt;
        public static int count4me;

        public static void loadData()
        {
           //Perform a += for loop for each item
            foreach (string product in CartGUI.myItems)
            {
                listReceipt += product + Environment.NewLine;
                count4me++;
            }
            count4me = 0; //Reset the counter
            printer Printer = new printer(receiptcount, listReceipt);
            Printer.Export(receiptcount, listReceipt, Payment.total4Receipt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            Application.Exit();
        }
    }
}
