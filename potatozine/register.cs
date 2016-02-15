using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace potatozine
{
    public partial class register : Form
    {
        char[] letters = { '.', '@' };
        string type;
        public register()
        {
            InitializeComponent();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    if (premiumCheck.Checked == true)
                    {
                        type = "Premium";
                    }
                    else
                    {
                        type = "Regular";
                    }
                    //set up the connection string
                    conn.ConnectionString = DBPOS.uniConnectionStr;
                    cmd.Connection = conn;
                    cmd.CommandText = "Insert into accountinfo(Name,Username,Password,Email,MemberType)"
                        + "Values(@Name,@Username,@Password,@Email,@MemberType)";

                    cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@Username", UsernameBox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordBox.Text);
                    cmd.Parameters.AddWithValue("@Email", emailBox.Text);
                    cmd.Parameters.AddWithValue("@MemberType", type);

                    try
                    {
                        //open connection
                        conn.Open();
                        //execute command
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User created");
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        //close connection
                        conn.Close();
                    }
                }
            }
            //} else
            //{
            //    MessageBox.Show("Your input/s are invalid. Please try again.");
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
