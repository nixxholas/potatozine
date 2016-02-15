using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potatozine
{
    class userloader
    {
        private string username; //Unique Identifier
        private string name;
        private string email;
        private string memtype;

        public userloader(string u, string n, string e, string m)
        {
            this.username = u;
            this.name = n;
            this.email = e;
            this.memtype = m;
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Memtype
        {
            get { return this.memtype; }
            set { this.memtype = value; }
        }
    }
}
