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
        public static double total4Receipt;

        public Payment()
        {
            InitializeComponent();
        }

        public void setupPay(double total)
        {
            txtSubTot.Text = total.ToString();
            total4Receipt = Convert.ToDouble(txtSubTot.Text);
        }

        //Back button to hide the checkout form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Check if empty
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            bool go = checkInput(true);
            if (go == true)
            {
                if (discount.Text == "lolurekt")
                {
                    double payable = CartGUI.viewtotal;
                    payable *= 1/2;
                    MessageBox.Show("Your discount code is usable and is now used.");
                } else if (discount.Text != null) {
                    MessageBox.Show("You have entered an invalid discount code. No discount will be given.");
                }
                Receipt receiptPage = new Receipt();
                this.Hide();
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
