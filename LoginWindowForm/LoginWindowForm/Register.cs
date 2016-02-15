using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginWindowForm
{
    public partial class Register : Form
    {
        private const string connectionString = "Data Source=DIT-NB1530560\\SQLEXPRESS;" +
                   "database=AppDAssignment;" + "integrated security=true";
        string type;
        Form1 f1 = new Form1();
        public Register()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    if (chkRegular.Checked)
                    {
                        type = "Regular";
                    }
                    else if (chkPremium.Checked)
                    {
                        type = "Premium";
                    }
                    //set up the connection string
                    conn.ConnectionString = connectionString;
                    cmd.Connection = conn;
                    cmd.CommandText = "Insert into UserDetails(Username,Password,MemberType)"
                        + "Values(@Username,@Password,@MemberType)";

                    cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@MemberType", type);
                    
                    try
                    {
                        //open connection
                        conn.Open();
                        //execute command
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User created");                       
                        f1.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                         MessageBox.Show("Invalid");
                    }
                    finally
                    {
                        //close connection
                        conn.Close();
                    }
                }
            }
            }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }
    }
}
