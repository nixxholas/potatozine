using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Product
    {
        private double price;
        private string name;
        private int IDno;
        private string desc;

        //Default Constructor
        public Product() { }
        //Constructor
        public Product(double price, string name, int IDno, string desc) {
            this.price = price;
            this.name = name;
            this.IDno = IDno;
            this.desc = desc;
        }

        //Price property
        public double Price{
            get { return this.price; } //Returns the price amount
            set { this.price = value; } //Sets the price amount
        }

        //Name property
        public string Name {
            get { return this.name; }//Returns the name string
            set { this.name = value; }//Sets the name string
        }

        //ID Property
        public int ID {
            get { return this.IDno; }
            set { this.IDno = value; }
        }

        //Description Property
        public string Desc
        {
            get { return this.Desc; }
            set { this.Desc = value; }
        }
    }
}
