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

        public product () { }

        public product (string id, string nam, string des, double pr, int cd, string img)
        {
            pid = id;
            name = nam;
            desc = des;
            price = pr;
            catcd = cd;
            imgLink = img;
        }

        public virtual void getDetails()
        {
            
        }
    }
}
