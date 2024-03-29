﻿using System;
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
        public bool dscCd; //True or false whether discount code is given
        public int discount; //Discount code percentage
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

        private void resetCart()
        {
            cart.Columns.Remove("ID");
            cart.Columns.Remove("Name");
            cart.Columns.Remove("Qty");
            cart.Columns.Remove("Price");
            launchCart();
        }

        private void loadCat()
        {
            DataTable CatLoad = database.SQLQuery("Select * from category");
            List<string> catnames = new List<string>();
            foreach (DataRow row in CatLoad.Rows)
            {
                catnames.Add(row["catname"].ToString());
            }
            lstCatergory.DataSource = catnames;
        }

        private void loadreport() {
            DataTable tempstore = new DataTable();
            DGVrep.DataSource = database.getsales();
            tempstore = database.getSalesAvgTot();
            foreach (DataRow row in tempstore.Rows) {
                lblAvgSales.Text = "Average Sales: $" + row["Avg"].ToString();
                lblTotSale.Text = "Total Sales: $" + row["Sum"].ToString();
            }
        }

        private void printReceipt()
        {
            printDocument.Print();
        }
        private void printDocument_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            //this prints the reciept
            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];

            graphic.DrawString(" Potatozine", new Font("Courier New", 21), new SolidBrush(Color.Black), startX, startY);

            offset = offset + 30;
            graphic.DrawString(time + "   " + date, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30;
            string top = "Item Name".PadRight(30) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            foreach (DataRow item in checkoutCart.Rows)
            {
                //create the string to print on the reciept
                string productDescription = item.ItemArray[1].ToString().PadRight(30) + Convert.ToDouble(item.ItemArray[3]).ToString("c");
                string productTotal = item.ItemArray[3].ToString();
                float productPrice = float.Parse((double.Parse(item.ItemArray[3].ToString()) / double.Parse(item.ItemArray[2].ToString())).ToString());

                //MessageBox.Show(item.Substring(item.Length - 5, 5) + "PROD TOTAL: " + productTotal);

                if (productDescription.Contains("  -"))
                {
                    string productLine = productDescription.Substring(0, 24);

                    graphic.DrawString(productLine, new Font("Courier New", 12, FontStyle.Italic), new SolidBrush(Color.Red), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }
                else
                {
                    string productLine = productDescription;

                    graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                    offset = offset + (int)fontHeight + 5; //make the spacing consistent
                }

            }

            offset = offset + 20; //make some room so that the total stands out.

            //if (dscCd == true)
            //{
            //    graphic.DrawString("Discount ".PadRight(30) + discount.ToString("00%"), font, new SolidBrush(Color.Black), startX, startY + offset);
            //    offset = offset + 20;
            //}


            if (memStatusBox.Text == "Premium")
            {
                graphic.DrawString("Member Discount ".PadRight(30) + "20%", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 20;
            }
            graphic.DrawString("Total to pay ".PadRight(30) + String.Format("{0:c}", totalcartBox.Text), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.

            graphic.DrawString("     Thank you for your purchase.", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       Please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);

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
            btnCheckout.Enabled = false;
            printReceipt();
            cart.Rows.Clear();
            resetCart();
            checkoutCart.Clear();
            btnCheckout.Enabled = true;
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
            else if (tabs.SelectedTab == tabs.TabPages["Report"]) {
                loadreport();
            }
        }

        private void catalogue_Load(object sender, EventArgs e)
        {
            database.loadProducts();
            database.createobjects();
            loadCat();
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
                    sum *= 0.8;
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

        ////Still Buggy
        //public void RemoveDupes(DataGridView grv)
        //{
        //    for (int currentRow = 0; currentRow < grv.Rows.Count - 1; currentRow++)
        //    {
        //        DataGridViewRow rowToCompare = grv.Rows[currentRow];

        //        for (int otherRow = currentRow + 1; otherRow < grv.Rows.Count; otherRow++)
        //        {
        //            DataGridViewRow row = grv.Rows[otherRow];

        //            bool duplicateRow = true;

        //            for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
        //            {
        //                if (!rowToCompare.Cells[cellIndex].Value.Equals(row.Cells[cellIndex].Value))
        //                {
        //                    duplicateRow = false;
        //                    break;
        //                }
        //            }

        //            if (duplicateRow)
        //            {
        //                rowToCompare.Cells["Qty"].Value = int.Parse(rowToCompare.Cells["Qty"].Value.ToString()) + int.Parse(row.Cells["Qty"].Value.ToString());
        //                rowToCompare.Cells["Price"].Value = double.Parse(rowToCompare.Cells["Qty"].Value.ToString()) * int.Parse(row.Cells["Qty"].Value.ToString());
        //                //MessageBox.Show(rowToCompare.Cells["Qty"].Value.ToString() + row.Cells["Qty"].Value.ToString());
        //                grv.Rows.Remove(row);
        //                otherRow--;
        //            }
        //        }
        //    }
        //}

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
                dscCd = true;
                discount = 50;
            }
        }
    }
}

