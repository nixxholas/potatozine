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
using System.Drawing.Printing;

namespace potatozine
{
    public partial class catalogue : Form
    {
        String memType;
        public double rprice; //Current Product Price
        public double cprice; //Current Calculated Price
        DBPOS database = new DBPOS();
        List<PictureBox> picBoxes = new List<PictureBox>();
        List<magazine> displayedMags = new List<magazine>();
        List<Book> displayedBooks = new List<Book>();
        DataTable cart = new DataTable();
        DataTable checkoutCart = new DataTable();

        private void launchCart()
        {
            cart.Columns.Add("ID", typeof(string));
            cart.Columns.Add("Name", typeof(string));
            cart.Columns.Add("Description", typeof(string));
            cart.Columns.Add("Qty", typeof(int));
            cart.Columns.Add("Price", typeof(double));
            cartView.DataSource = cart;
        }

        private void printReceipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Segou UI", 24);
            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 50;

            graphic.DrawString("Welcome to Potatozine", new Font("Segou UI", 30), new SolidBrush(Color.Black), startX, startY);
            
        }

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
            launchCart();            
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
            database.AddSales(cart,lblGreet.Text);
            checkoutCart = (DataTable)(cartView.DataSource);
            checkoutCart.Columns.Remove("Description");
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
                    conn.ConnectionString = DBPOS.uniConnectionStr;
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
                            userloader user = new userloader((row["Username"].ToString()), (row["Name"].ToString()), (row["Email"].ToString()), (row["MemberType"].ToString()));
                            memStatusBox.Text = user.Memtype;
                            lblGreet.Text = user.Name;
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
            name = ((PictureBox)sender).Name;
            index = int.Parse(name.Substring(5));
            if (index >= displayedMags.Count) {
                try
                {
                    index = index - displayedMags.Count();
                    setinfo(displayedBooks[index].Pid, displayedBooks[index].Name, displayedBooks[index].adddesc(), displayedBooks[index].Price.ToString(), displayedBooks[index].ImgLink);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    setinfo(displayedMags[index].Pid, displayedMags[index].Name, displayedMags[index].adddesc(), displayedMags[index].Price.ToString(), displayedMags[index].ImgLink);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void setinfo(string pid, string name, string desc, string price, string img) {
            lblSelProdNam.Text = name;
            PicSelProd.Load(img);
            txtSelDesc.Text = desc;
            lblPrice.Text = "Price: " + price;
            rprice = double.Parse(price);
            lblPID.Text = pid;
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

        private void refTotal()
        {
            double sum;
            if (cartView.Rows.Count == 0) //When no rows are present
            {
                sum = 0.00;
                totalcartBox.Text = String.Format("{0:C}", sum);
                totalcartBox.Refresh();
            } else {
                sum = Convert.ToDouble(cart.Compute("SUM(Price)", string.Empty));
                if (memStatusBox.Text == "Premium")
                {
                    sum *= 0.75;
                }
                if (couponBox.Text == "CNY50")
                {
                    sum *= 0.5;
                }
                totalcartBox.Text = sum.ToString("c");
                totalcartBox.Refresh();
                //RemoveDupes(cartView);
            }
        }

        public void RemoveDupes(DataGridView grv)
        {
            for (int currentRow = 0; currentRow < grv.Rows.Count - 1; currentRow++)
            {
                DataGridViewRow rowToCompare = grv.Rows[currentRow];

                for (int otherRow = currentRow + 1; otherRow < grv.Rows.Count; otherRow++)
                {
                    DataGridViewRow row = grv.Rows[otherRow];

                    bool duplicateRow = true;

                    for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                    {
                        if (!rowToCompare.Cells[cellIndex].Value.Equals(row.Cells[cellIndex].Value))
                        {
                            duplicateRow = false;
                            break;
                        }
                    }

                    if (duplicateRow)
                    {
                        rowToCompare.Cells["Qty"].Value = int.Parse(rowToCompare.Cells["Qty"].Value.ToString()) + int.Parse(row.Cells["Qty"].Value.ToString());
                        MessageBox.Show(rowToCompare.Cells["Qty"].Value.ToString() + row.Cells["Qty"].Value.ToString());
                        grv.Rows.Remove(row);
                        otherRow--;
                    }
                }
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (lblSelProdNam.Text != "") {
            cprice = rprice * double.Parse(numQty.Text);
            cart.Rows.Add(lblPID.Text, lblSelProdNam.Text, txtSelDesc.Text, int.Parse(numQty.Text), cprice);
            cprice = 0;
            }
        }

        private void cartView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            refTotal();
        }

        private void cartView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            refTotal();
        }

        private void couponBox_TextChanged(object sender, EventArgs e)
        {
            if (couponBox.Text == "CNY50")
            {
                refTotal();
                MessageBox.Show("You have just activated a 50% discount!");
            }
        }
    }
}

