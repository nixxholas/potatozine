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

        /**
            type 1 = Fashion
            type 2 = ???
        **/
        private int type;


        private string desc;
        private string imglink;

        //Default Constructor
        public Product() { }
        //Constructor
        public Product(double price, string name, int IDno, int type, string desc, string imglink) {
            this.price = price;
            this.name = name;
            this.IDno = IDno;
            this.type = type;
            this.desc = desc;
            this.imglink = imglink;
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

        public int Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        //Description Property
        public string Desc
        {
            get { return this.Desc; }
            set { this.Desc = value; }
        }

        public string Imglink
        {
            get { return this.imglink; }
            set { this.imglink = value; }
        }
    }
}
