using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop_Slamenik.BusinessObjects
{
    public class Itemy
    {
        public int id { get; set; }

        public int ks { get; set; }

        public Itemy(int id, int ks)
        {
            this.id = id;
            this.ks = ks;
        }
    }
}
