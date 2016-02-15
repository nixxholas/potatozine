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
    public partial class Form1 : Form
    {
        private const string connectionString = "Data Source=DIT-NB1530560\\SQLEXPRESS;" +
                    "database=AppDAssignment;" + "integrated security=true";
        string type;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
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
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from UserDetails where username = '" + txtUser.Text
                        + "' and password = '" + txtPass.Text + "'" + "and MemberType = '"+type+"'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        this.Hide();
                    MessageBox.Show("Username and Password is correct");
                    Form2 f2 = new Form2();
                        f2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please check your username and password");
                    }
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register r1 = new Register();
            r1.Show();
            this.Hide();
        }
    }
}
