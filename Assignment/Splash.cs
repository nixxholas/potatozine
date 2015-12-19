using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashBar.Increment(1);
            if (splashBar.Value == 100)
                splashTimer.Stop();
        }
    }
}
