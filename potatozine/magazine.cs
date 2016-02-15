using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potatozine
{
    class magazine : product
    {
        private int pages; //Magazine pages

        public magazine () { }

        public magazine (string id, string nam, string des, double pr, int cd, string img, int pg) : base(id, nam, des, pr,cd,img)
        {
            pages = pg;
        }

        public int Pages {
            get { return this.pages; }
            set { this.pages = value; }
        }

        public string adddesc() {
            string basedesc = base.getDesc();
            basedesc += "\r\nPages: " + pages;
            return basedesc;
        }
    }
}
