using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        string selCat;
        public static int noofprods = 24; //Can be modified to add more

        //creation of object
        ItemInfo itemPage = new ItemInfo(); //ItemInfo page object
        CartGUI cartPage = new CartGUI();//Cart page object
        Product[] arrProducts = new Product[noofprods]; //Array of Product Objects

        //Start of program
        public Form1()
        {
            //Loads the splash screen
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            LoadDesc();
            //SoundPlayer simpleSound = new SoundPlayer(@"villager.wav");
            //simpleSound.Play();//If you don't want the annoyance, remove Looping
            Thread.Sleep(3000);

            InitializeComponent();

            t.Abort();
        }

        //Method to read the textfile
        public void LoadDesc()
        {
            System.IO.StreamReader theFile = new System.IO.StreamReader(@"loadprod.txt");
            String line;
            int counter = 0;

            while ((line = theFile.ReadLine()) != null)
            {
                string[] content = line.Split(',');
                arrProducts[counter] = new Product(content[0], double.Parse(content[1]), int.Parse(content[2]), content[3], content[4], content[5]);
                counter++;
            }

            theFile.Close();
        }

        //Method to run the splash screen
        public void splashStart()
        {
            Application.Run(new Splash());
        }

        //Automated Method for Product Category Detection
        private void ListItemBeta(String category)
        {
          for (int i = 0; i < noofprods; i++)
            {
                //wtf nullexception
               if (arrProducts[i].Catname == category)
                {
                    //Untested
                    setSinglePic(arrProducts[i].Imglink);
                } 
            }
        }

        //Code when the list items button is clicked
        private void btnLstItms_Click(object sender, EventArgs e)
        {
            try
            {
                //Takes category selected and puts into a string
                this.selCat = lstCatergory.SelectedItem.ToString(); //Qi xiang.. Category not Catergory.. REMOVE IT


                //Takes catergory selected and parses in URLs to load pictures
                switch (this.selCat)
                {
                    case "Fashion":
                        setPic(arrProducts[0].Imglink, arrProducts[1].Imglink, arrProducts[2].Imglink, arrProducts[3].Imglink, arrProducts[4].Imglink, arrProducts[5].Imglink);
                        break;
                    case "Technology":
                        setPic(arrProducts[6].Imglink, arrProducts[7].Imglink, arrProducts[8].Imglink, arrProducts[9].Imglink, arrProducts[9].Imglink, arrProducts[9].Imglink);
                        picItem3.Hide();
                        picItem4.Hide();
                        picItem5.Hide();
                        picItem6.Hide();
                        break;
                    case "Travel":
                        setPic(arrProducts[8].Imglink, arrProducts[9].Imglink, arrProducts[9].Imglink, arrProducts[9].Imglink, arrProducts[9].Imglink, arrProducts[9].Imglink);
                        picItem3.Hide();
                        picItem4.Hide();
                        picItem5.Hide();
                        picItem6.Hide();
                        break;
                }
            } catch (NullReferenceException)
            {

            }
        }

        //Method that takes in the string URL and sets in picitems 1-6
        public void setPic(string item1, string item2, string item3, string item4, string item5, string item6) {
            showAll();
            picItem1.Load(item1);
            picItem2.Load(item2);
            picItem3.Load(item3);
            picItem4.Load(item4);
            picItem5.Load(item5);
            picItem6.Load(item6);
        }

        //New Refined Method to initialize shit globally
        public void setSinglePic(string item1)
        {
            showAll();
            if (picItem1.Image != null)
            {
                picItem1.Load(item1);
            }
            else if (picItem2.Image != null)
            {
                picItem2.Load(item1);
            }
            else if (picItem3.Image != null)
            {
                picItem3.Load(item1);
            }
            else if (picItem4.Image != null)
            {
                picItem4.Load(item1);
            }
            else if (picItem5.Image != null)
            {
                picItem5.Load(item1);
            }
            else if (picItem6.Image != null)
            {
                picItem6.Load(item1);
            }
        }

        //On click events for picitems 1-6
        private void picItem1_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[0].Imglink,arrProducts[0].Name,arrProducts[0].Desc,arrProducts[0].Price, arrProducts[0].Catname);
                    itemPage.Show();
                    break;
                case "Technology":
                    itemPage.LoadInfo(arrProducts[6].Imglink, arrProducts[6].Name, arrProducts[6].Desc, arrProducts[6].Price, arrProducts[6].Catname);
                    itemPage.Show();
                    break;
                case "Travel":
                    itemPage.LoadInfo(arrProducts[8].Imglink, arrProducts[8].Name, arrProducts[8].Desc, arrProducts[8].Price, arrProducts[8].Catname);
                    itemPage.Show();
                    break;
            }
        }

        private void picItem2_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[1].Imglink, arrProducts[1].Name, arrProducts[1].Desc, arrProducts[1].Price, arrProducts[1].Catname);
                    itemPage.Show();
                    break;
                case "Technology":
                    itemPage.LoadInfo(arrProducts[7].Imglink, arrProducts[7].Name, arrProducts[7].Desc, arrProducts[7].Price, arrProducts[7].Catname);
                    itemPage.Show();
                    break;
                case "Travel":
                    itemPage.LoadInfo(arrProducts[9].Imglink, arrProducts[9].Name, arrProducts[9].Desc, arrProducts[9].Price, arrProducts[9].Catname);
                    itemPage.Show();
                    break;
            }
        }

        private void picItem3_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[2].Imglink, arrProducts[2].Name, arrProducts[2].Desc, arrProducts[2].Price, arrProducts[2].Catname);
                    itemPage.Show();
                    break;
                case "Technology":
                    break;
                case "Travel":
                    break;
            }
        }

        private void picItem4_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[3].Imglink, arrProducts[3].Name, arrProducts[3].Desc, arrProducts[3].Price, arrProducts[3].Catname);
                    itemPage.Show();
                    break;
                case "Technology":
                    break;
                case "Travel":
                    break;
            }
        }

        private void picItem5_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[4].Imglink, arrProducts[4].Name, arrProducts[4].Desc, arrProducts[4].Price, arrProducts[4].Catname);
                    itemPage.Show();
                    break;
                case "Technology":
                    break;
                case "Travel":
                    break;
            }
        }

        private void picItem6_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[5].Imglink, arrProducts[5].Name, arrProducts[5].Desc, arrProducts[5].Price, arrProducts[5].Catname);
                    itemPage.Show();
                    break;
                case "Technology":
                    break;
                case "Travel":
                    break;
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            cartPage.Show();
            cartPage.reloadcart();
        }

        public void showAll() {
            picItem1.Show();
            picItem2.Show();
            picItem3.Show();
            picItem4.Show();
            picItem5.Show();
            picItem6.Show();
        }

        private void lstCatergory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This is working 100%
            //MessageBox.Show(lstCatergory.SelectedItem.ToString());
            String selected = lstCatergory.SelectedItem.ToString();
            ListItemBeta(selected);
        }
        
    }
}
