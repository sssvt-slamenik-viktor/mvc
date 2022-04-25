using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using eshop_Slamenik.BusinessObjects;

namespace eshop_Slamenik.Models
{
    public class ItemModel
    {
        public ICollection<Item> Items { get; set; }
    }
}
