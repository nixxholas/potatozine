using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    class backend
    {

        public double priceLooper()
        {
            double finaltotal = 0;

            /**
            Wait for Qi to have a box for showing the subtotal
            **/

            return finaltotal;
        }

        public void LoadDesc()
        {

            /**
            Custom File Loader
            Displays all contents

            private double price;
            private string name;
            private int IDno;
            private string desc;
            **/

            System.IO.StreamReader theFile = new System.IO.StreamReader("C:\\loadprod.txt");
            String line;
            while ((line = theFile.ReadLine()) != null)
            {
                string[] content = line.Split(',');
                new Product(double.Parse(content[0]), content[1], int.Parse(content[2]), content[3]);
            }

            theFile.Close();
        }
    }
}
