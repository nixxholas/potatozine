using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class printer : Receipt
    {
        /**
        * Printer Constuctor.
        *   Made to allow simple addition of new variables for the receipt
        *   before printing
        **/
        private int receiptid;
        private string info;

        public printer(int receiptid, string info)
        {
            this.receiptid = receiptid;
            this.info = info;
        }

        public int Receiptid
        {
            get { return this.receiptid; }
            set { this.receiptid = value; }
        }

        public string Info
        {
            get { return this.info; }
            set { this.info = value; }
        }

        public void Export(int number, string data, double total)
        {
            string[] lines = { "PotatoZine", "", "", "", "Total: "};
            lines[2] = number.ToString();
            lines[3] = data;
            lines[4] += total.ToString();
            System.IO.File.WriteAllLines(@"C:\receipt.txt", lines);
        }
    }
} 
