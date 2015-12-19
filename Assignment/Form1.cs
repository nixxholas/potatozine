using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            t.Abort();
        }

        public void splashStart()
        {
            Application.Run(new Splash());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnLstItms_Click(object sender, EventArgs e)
        {

        }
    }
}
