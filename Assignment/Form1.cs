using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }

        public void splashStart()
        {
            Application.Run(new Splash());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnLstItms_Click(object sender, EventArgs e)
        {
            //Reset the catalogue. Hides all items
            hideall();

            //Takes catergory selected and starts selection based on selected category.
            switch (lstCatergory.SelectedItem.ToString()) {
                case "Fashion":
                    //Code to make fashion items visible
                    picItem1.Visible = true;
                    picItem2.Visible = true;
                    picItem3.Visible = true;
                    picItem4.Visible = true;
                    picItem5.Visible = true;
                    picItem6.Visible = true;
                    break;
                case "Technology":
                    //code to make technology stuff visible
                    break;
                case "Travel":
                    //code to make teavel stuff visible
                    break;
                case "Architecture":
                    //code to make archi stuff visible
                    break;
            }
        }

        //Hides all items
        public void hideall() {
            picItem1.Visible = false;
            picItem2.Visible = false;
            picItem3.Visible = false;
            picItem4.Visible = false;
            picItem5.Visible = false;
            picItem6.Visible = false;
        }
    }
}
