using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potatozine
{
    class addons : product
    {
        private double weight;

        public addons () { }

        public addons (int a, string b, string c, double d, double e) : base(a, b, c, d)
        {
            weight = e;
        }

        public override void getDetails()
        {
            base.getDetails();
        }
    }
}
