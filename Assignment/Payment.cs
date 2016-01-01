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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            displayTotal(this.total);
        }

        private double total;

        //Subtotal Property
        public double Total
        {
            get { return this.total; }
            set { this.total = value; }
        }

        //Back button to hide the checkout form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Method to set the subtotal textbox
        public void displayTotal(double total)
        {
            txtSubTot.Text = System.Convert.ToString(total);
        }

        //Check if empty
        /**
         * This is broken
         * 
         **/

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            bool go = checkInput(true);
            if (go == true)
            {
                if (discount.Text == "lolurekt")
                {
                    double payable = CartGUI.viewtotal;
                    payable *= 1/2;
                }
                Receipt receiptPage = new Receipt();
                receiptPage.Show();
            }
        }

        public bool checkInput(bool noerror)
        {
            int temp = 0;
            float tempfloat = 0;
            noerror = float.TryParse(txtCardNo.Text, out tempfloat);
            if (noerror == true)
                noerror = int.TryParse(txtExpMnth.Text, out temp);
            if (noerror == true)
                noerror = int.TryParse(txtExpYr.Text, out temp);
            if (noerror == true)
                noerror = int.TryParse(txtCVV.Text, out temp);
            if (noerror == true)
                noerror = (txtCardHolderNam.Text != "");
            if (noerror == true)
                noerror = (txtAdd1.Text != "");
            if (noerror == true)
                noerror = (txtCity.Text != "");
            if (noerror == true)
                noerror = (txtCountry.Text != "");
            if (noerror == true)
                noerror = (txtState.Text != "");
            if (noerror == true)
                noerror = (txtPostal.Text != "");
            if (noerror == true)
                noerror = (txtHP.Text != "");
            if (noerror == false)
            {
                MessageBox.Show("You have entered invalid information. Please try again.");
                return noerror;
            }
            else
            {
                return noerror;
            }
        }
    }
}
