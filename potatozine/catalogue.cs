using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace potatozine
{
    public partial class catalogue : Form
    {
        public catalogue()
        {
            //Loads the splash screen
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();

            //LoadDesc();
            InitializeComponent();

            //SoundPlayer simpleSound = new SoundPlayer(@"villager.wav");
            //simpleSound.Play();//If you don't want the annoyance, remove Looping
            Thread.Sleep(3000);
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
                //arrProducts[counter] = new Product(content[0], double.Parse(content[1]), int.Parse(content[2]), content[3], content[4], content[5]);
                counter++;
            }

            theFile.Close();
        }
        
        
        public void splashStart()
        {
            Application.Run(new splash());
        }

        private void maintab_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //using (SqlConnection cn = new SqlConnection("Data Source=NIXH\\SQLEXPRESS;" +
            //        "database=login;" +
            //        "integrated security=true"))
                if (usernameBox.Text != "" & passwordBox.Text != "")
            {
                //Perform the login attempt
            }   else
            {
                MessageBox.Show("Please enter your credentials.");
            } 
                    
            }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            register regForm = new register(); // New instance for the Register Form
            regForm.Show(); //Show the Form
        }

        //Anti-Ms Choo System for Procastinating about Hard Coding.
        public void UpdateTabs()
        {

        }

        private void tabs_Selected(object sender, TabControlEventArgs e)
        {

        }


    }
}

