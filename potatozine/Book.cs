using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potatozine
{
    class Book : product
    {
        string publisher;
        string authors;
        string type;

        public Book() { } //Default Constructor

        //Constructor
        public Book(string id, string nam, string des, double pr, int cd, string img, string pub, string auth, string typ) : base(id, nam, des, pr,cd,img) {
            publisher = pub;
            authors = auth;
            type = typ;
        }

    }
}
