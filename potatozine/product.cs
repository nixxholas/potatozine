using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potatozine
{
    class product
    {
        private int pid; //Product ID
        private string name; //Product 
        private string desc; //Product description
        private double price; //Product Price

        public product () { }

        public product (int a, string b, string c, double d)
        {
            pid = a;
            name = b;
            desc = c;
            price = d;
        }

        public virtual void getDetails()
        {
            
        }
    }
}
