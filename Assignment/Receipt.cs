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
        }

        public static int receiptcount;
        public static String listReceipt;
        public static int count4me;

        public static void loadData()
        {
           //Perform a += for loop for each item
            foreach (string product in CartGUI.myItems)
            {
                listReceipt += product + "\t\t $" + CartGUI.itemPrice[count4me] + Environment.NewLine;
                count4me++;
            }
            count4me = 0;
            printer Printer = new printer(receiptcount, listReceipt);
            Printer.Export(receiptcount, listReceipt, CartGUI.viewtotal);
        }
    }
}
