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
        String memType;
        dbengine database = new dbengine();
        List<PictureBox> picBoxes = new List<PictureBox>();
        List<magazine> displayedMags = new List<magazine>();
        List<Book> displayedBooks = new List<Book>();

        int listnum = 0;

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
            if (usernameBox.Text != "" & passwordBox.Text != "")
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    //set up the connection string
                    string command = "Select Count(*) from accountinfo where username = '" + usernameBox.Text
                        + "' and password = '" + passwordBox.Text + "'";
                    string usertype = "Select * from accountinfo where username = '" + usernameBox.Text
                        + "' and password = '" + passwordBox.Text + "'";
                    conn.ConnectionString = dbengine.uniConnectionStr;
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(command, conn);
                    DataTable dt = new DataTable(); //Data table verifying table
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        //Data table for storing current account
                        SqlDataAdapter uta = new SqlDataAdapter(usertype, conn); 
                        DataTable account = new DataTable();
                        uta.Fill(account);
                        foreach (DataRow row in account.Rows)
                        {
                            memStatusBox.Text = (row["MemberType"].ToString());
                            lblGreet.Text = (row["Username"].ToString());
                            MessageBox.Show("Welcome to Potatozine, " + lblGreet.Text);
                            userControl(1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check your username and password");
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter your credentials.");
            }
        }

        private void userControl(int control)
        {
            if (control == 1) // When user logs in
            {
                loginBtn.Visible = false;
                registerBtn.Visible = false;
                usernameBox.Enabled = false;
                passwordBox.Enabled = false;
                btnLogout.Visible = true;
            } else if (control == 2) // When user logs out
            {
                lblGreet.Text = "Guest";
                memStatusBox.Text = "";
                btnLogout.Visible = false;
                usernameBox.Enabled = true;
                passwordBox.Enabled = true;
                loginBtn.Visible = true;
                registerBtn.Visible = true;
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
            if (tabs.SelectedTab == tabs.TabPages["Cart"])
            {

            }
        }

        private void catalogue_Load(object sender, EventArgs e)
        {
            database.loadProducts("magazine");
            database.loadProducts("Book");
            database.createobjects();
        }

        public void listobj(int catcd)
        {
            picBoxes.Clear();
            foreach (magazine mag in database.Magazineobj)
            {
                if (mag.Catcd == catcd + 1)
                {
                    createPicBox(mag.ImgLink);
                    displayedMags.Add(mag);
                }
            }
            foreach (Book bk in database.Bookobj)
            {
                if (bk.Catcd == catcd + 1)
                {
                    createPicBox(bk.ImgLink);
                    displayedBooks.Add(bk);
                }
            }
        }

        public void createPicBox(string imglink)
        {
            string picboxName = string.Empty;
            PictureBox pic = new PictureBox
            {
                Name = "PicBx" + listnum,
                Size = new Size(221, 290),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pic.Load(imglink);
            picboxName = pic.Name.ToString();
            pic.Click += new System.EventHandler(picBox_OnClick);
            picBoxes.Add(pic);
            listnum++;
        }

        private void displayboxes() {
            foreach (PictureBox pic in picBoxes)
            {
                FlwPanel.Controls.Add(pic);
            }
        }

        private void picBox_OnClick(object sender, EventArgs e)
        {
            int index = 0;
            string name = string.Empty;
            //debugging
            if (sender is PictureBox)
            {
                MessageBox.Show("clicked on: " + ((PictureBox)sender).Name);
            }
            name = ((PictureBox)sender).Name;
            index = int.Parse(name.Substring(5));
            try {
                setinfo(displayedMags[index + 1].Name, displayedMags[index + 1].adddesc(), displayedMags[index + 1].Price.ToString(), displayedMags[index + 1].ImgLink);
            } catch (Exception ex)
            {
                MessageBox.Show(index.ToString());
                MessageBox.Show(ex.ToString());
            }
            }


        private void setinfo(string name, string desc, string price, string img) {
            lblSelProdNam.Text = name;
            PicSelProd.Load(img);
            txtSelDesc.Text = desc;
            lblPrice.Text = "Price: " + price;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            userControl(2);
            MessageBox.Show("You have been logged out.");
        }

        private void lstCatergory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FlwPanel.Controls.Clear();
            displayedBooks.Clear();
            displayedMags.Clear();
            listobj(lstCatergory.SelectedIndex);
            displayboxes();
            listnum = 0;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

