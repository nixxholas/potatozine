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
using System.IO;

namespace potatozine
{
    public partial class catalogue : Form
    {
        ImageList productImages = new ImageList();
        dbengine database = new dbengine();
        List<PictureBox> picBoxes = new List<PictureBox>();
        int listnum = 1;
       
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
            loadImgList();
            t.Abort();
        }

        private void loadImgList()
        {
            DirectoryInfo dir = new DirectoryInfo(@"images");
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    this.productImages.Images.Add(Image.FromFile(file.FullName));
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
            this.prodView.View = View.LargeIcon;
            this.productImages.ImageSize = new Size(256, 256);
            this.prodView.LargeImageList = this.productImages;
            //or
            //this.listView1.View = View.SmallIcon;
            //this.listView1.SmallImageList = this.imageList1;

            for (int j = 0; j < this.productImages.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.prodView.Items.Add(item);
            }
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
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        SqlDataAdapter uta = new SqlDataAdapter(usertype, conn);
                        DataTable account = new DataTable();
                        uta.Fill(account);
                        foreach (DataRow row in account.Rows)
                        {
                            btnLogout.Visible = true;
                            memStatusBox.Text = (row["MemberType"].ToString());
                            lblGreet.Text = (row["Username"].ToString());
                            MessageBox.Show("Welcome to Potatozine, " + lblGreet.Text);
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
                if (mag.Catcd == catcd)
                {
                    createPicBox("none");
                }
            }
            foreach (Book bk in database.Bookobj)
            {
                if (bk.Catcd == catcd)
                {
                    //code to create picbox
                }
            }
        }

        public void createPicBox(string imglink)
        {
            PictureBox pic = new PictureBox
            {
                Name = "PicBx" + listnum,
                Size = new Size(221, 290),
                Location = new Point(listnum * 316, 1),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblGreet.Text = "Guest";
            memStatusBox.Text = "";
            btnLogout.Visible = false;
            MessageBox.Show("You have been logged out.");
        }

        private void prodView_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(prodView.SelectedItems.ToString());
        }
    }
    
}

