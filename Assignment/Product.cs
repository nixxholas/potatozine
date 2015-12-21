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
        public Product(string name, double price, int IDno, int type, string desc, string imglink) {
            this.name = name;
            this.price = price;
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
            get { return this.desc; }
            set { this.desc = value; }
        }

        public string Imglink
        {
            get { return this.imglink; }
            set { this.imglink = value; }
        }
    }
}
