using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potatozine
{
    class product
    {
        private string pid; //Product ID
        private string name; //Product 
        private string desc; //Product description
        private double price; //Product Price
        private int catcd; //Category ID
        private string imgLink; //Image Link

        public product() { }

        public product(string id, string nam, string des, double pr, int cd, string img)
        {
            pid = id;
            name = nam;
            desc = des;
            price = pr;
            catcd = cd;
            imgLink = img;
        }

        public string Pid
        {
            get { return this.pid; }
            set { this.pid = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Desc
        {
            get { return this.desc; }
            set { this.desc = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int Catcd
        {
            get { return this.catcd; }
            set { this.catcd = value; }
        }

        public string ImgLink {
            get { return this.imgLink; }
            set { this.imgLink = value; }
        }
    }
}
