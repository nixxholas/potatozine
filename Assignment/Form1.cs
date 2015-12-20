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
        string selCat;

        //creation of object
        ItemInfo itemPage = new ItemInfo(); //ItemInfo page object


        //Start of program
        public Form1()
        {
            //Loads the splash screen
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }

        //Method to run the splash screen
        public void splashStart()
        {
            Application.Run(new Splash());
        }

        //Code when the list items button is clicked
        private void btnLstItms_Click(object sender, EventArgs e)
        {
            //Takes category selected and puts into a string
            this.selCat = lstCatergory.SelectedItem.ToString();

            //Insert code here to make all boxes transparent

            //Takes catergory selected and parses in URLs to load pictures
            switch (this.selCat) {
                case "Fashion":
                    //Code to make fashion items visible
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

        //Method that takes in the string URL and
        public void setPic(string item1, string item2, string item3, string item4, string item5, string item6) {
            picItem1.Load(item1);
            picItem2.Load(item2);
            picItem3.Load(item3);
            picItem4.Load(item4);
            picItem5.Load(item5);
            picItem6.Load(item6);
        }

        //On click events for picitems 1-6
        private void picItem1_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
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

        private void picItem2_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    //Code to make fashion items visible
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

        private void picItem3_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    //Code to make fashion items visible
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

        private void picItem4_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    //Code to make fashion items visible
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

        private void picItem5_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    //Code to make fashion items visible
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

        private void picItem6_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    //Code to make fashion items visible
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
    }
}
