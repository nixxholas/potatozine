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
        int counter = 0;
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
            LoadDescBeta();
            //SoundPlayer simpleSound = new SoundPlayer(@"villager.wav");
            //simpleSound.Play();//If you don't want the annoyance, remove Looping
            Thread.Sleep(3000);

            InitializeComponent();

            t.Abort();
        }

        //Method to read the textfile
        public void LoadDescBeta()
        {
            System.IO.StreamReader theFile = new System.IO.StreamReader(@"loadprod.txt");
            String line;


            while ((line = theFile.ReadLine()) != null)
            {
                string[] content = line.Split(',');
                arrProducts[counter] = new Product(content[0], double.Parse(content[1]), int.Parse(content[2]), int.Parse(content[3]), content[4], content[5]);
                counter++;
            }

            theFile.Close();
        }

        //Method to run the splash screen
        public void splashStart()
        {
            Application.Run(new Splash());
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
                        setPic(arrProducts[6].Imglink, arrProducts[7].Imglink, arrProducts[8].Imglink, arrProducts[9].Imglink, arrProducts[10].Imglink, arrProducts[11].Imglink);
                        break;
                    case "Travel":
                        setPic(arrProducts[12].Imglink, arrProducts[13].Imglink, arrProducts[14].Imglink, arrProducts[15].Imglink, arrProducts[16].Imglink, arrProducts[17].Imglink);
                        break;
                    case "Architecture":
                        setPic(arrProducts[18].Imglink, arrProducts[19].Imglink, arrProducts[20].Imglink, arrProducts[21].Imglink, arrProducts[22].Imglink, arrProducts[23].Imglink);
                        break;
                }
            } catch (NullReferenceException)
            {

            }
        }

        //Method that takes in the string URL and sets in picitems 1-6
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
                    itemPage.LoadInfo(arrProducts[0].Imglink,arrProducts[0].Name,arrProducts[0].Desc,arrProducts[0].Price);
                    itemPage.Show();
                    break;
                case "Technology":
                    itemPage.LoadInfo(arrProducts[6].Imglink, arrProducts[6].Name, arrProducts[6].Desc, arrProducts[6].Price);
                    itemPage.Show();
                    break;
                case "Travel":
                    itemPage.LoadInfo(arrProducts[12].Imglink, arrProducts[12].Name, arrProducts[12].Desc, arrProducts[12].Price);
                    itemPage.Show();
                    break;
                case "Architecture":
                    itemPage.LoadInfo(arrProducts[18].Imglink, arrProducts[18].Name, arrProducts[18].Desc, arrProducts[18].Price);
                    itemPage.Show();
                    break;
            }
        }

        private void picItem2_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[1].Imglink, arrProducts[1].Name, arrProducts[1].Desc, arrProducts[1].Price);
                    itemPage.Show();
                    break;
                case "Technology":
                    itemPage.LoadInfo(arrProducts[7].Imglink, arrProducts[7].Name, arrProducts[7].Desc, arrProducts[7].Price);
                    itemPage.Show();
                    break;
                case "Travel":
                    itemPage.LoadInfo(arrProducts[13].Imglink, arrProducts[13].Name, arrProducts[13].Desc, arrProducts[13].Price);
                    itemPage.Show();
                    break;
                case "Architecture":
                    itemPage.LoadInfo(arrProducts[19].Imglink, arrProducts[19].Name, arrProducts[19].Desc, arrProducts[19].Price);
                    itemPage.Show();
                    break;
            }
        }

        private void picItem3_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[2].Imglink, arrProducts[2].Name, arrProducts[2].Desc, arrProducts[2].Price);
                    itemPage.Show();
                    break;
                case "Technology":
                    itemPage.LoadInfo(arrProducts[8].Imglink, arrProducts[8].Name, arrProducts[8].Desc, arrProducts[8].Price);
                    itemPage.Show();
                    break;
                case "Travel":
                    itemPage.LoadInfo(arrProducts[14].Imglink, arrProducts[14].Name, arrProducts[14].Desc, arrProducts[14].Price);
                    itemPage.Show();
                    break;
                case "Architecture":
                    itemPage.LoadInfo(arrProducts[20].Imglink, arrProducts[20].Name, arrProducts[20].Desc, arrProducts[20].Price);
                    itemPage.Show();
                    break;
            }
        }

        private void picItem4_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[3].Imglink, arrProducts[3].Name, arrProducts[3].Desc, arrProducts[3].Price);
                    itemPage.Show();
                    break;
                case "Technology":
                    itemPage.LoadInfo(arrProducts[9].Imglink, arrProducts[9].Name, arrProducts[9].Desc, arrProducts[9].Price);
                    itemPage.Show();
                    break;
                case "Travel":
                    itemPage.LoadInfo(arrProducts[15].Imglink, arrProducts[15].Name, arrProducts[15].Desc, arrProducts[15].Price);
                    itemPage.Show();
                    break;
                case "Architecture":
                    itemPage.LoadInfo(arrProducts[21].Imglink, arrProducts[21].Name, arrProducts[21].Desc, arrProducts[21].Price);
                    itemPage.Show();
                    break;
            }
        }

        private void picItem5_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[4].Imglink, arrProducts[4].Name, arrProducts[4].Desc, arrProducts[4].Price);
                    itemPage.Show();
                    break;
                case "Technology":
                    itemPage.LoadInfo(arrProducts[10].Imglink, arrProducts[10].Name, arrProducts[10].Desc, arrProducts[10].Price);
                    itemPage.Show();
                    break;
                case "Travel":
                    itemPage.LoadInfo(arrProducts[16].Imglink, arrProducts[16].Name, arrProducts[16].Desc, arrProducts[16].Price);
                    itemPage.Show();
                    break;
                case "Architecture":
                    itemPage.LoadInfo(arrProducts[22].Imglink, arrProducts[22].Name, arrProducts[22].Desc, arrProducts[22].Price);
                    itemPage.Show();
                    break;
            }
        }

        private void picItem6_Click(object sender, EventArgs e)
        {
            switch (this.selCat)
            {
                case "Fashion":
                    itemPage.LoadInfo(arrProducts[5].Imglink, arrProducts[5].Name, arrProducts[5].Desc, arrProducts[5].Price);
                    itemPage.Show();
                    break;
                case "Technology":
                    itemPage.LoadInfo(arrProducts[11].Imglink, arrProducts[11].Name, arrProducts[11].Desc, arrProducts[11].Price);
                    itemPage.Show();
                    break;
                case "Travel":
                    itemPage.LoadInfo(arrProducts[17].Imglink, arrProducts[17].Name, arrProducts[17].Desc, arrProducts[17].Price);
                    itemPage.Show();
                    break;
                case "Architecture":
                    itemPage.LoadInfo(arrProducts[23].Imglink, arrProducts[23].Name, arrProducts[23].Desc, arrProducts[23].Price);
                    itemPage.Show();
                    break;
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            cartPage.Show();
        }


    }
}
