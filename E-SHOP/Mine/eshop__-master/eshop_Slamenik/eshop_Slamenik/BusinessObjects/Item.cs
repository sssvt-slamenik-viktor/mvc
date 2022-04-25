using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eshop_Slamenik.BusinessObjects
{
    [Table("items")]
    public class Item
    {

        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Picture")]
        public string Picture { get; set; }

        [Column("Popis")]
        public string Popis { get; set; }

        [Column("Availability")]
        public string Availability { get; set; }

        public Item(int iD, string name, string picture, string popis, string availability)
        {
            ID = iD;
            Name = name;
            Picture = picture;
            Popis = popis;
            Availability = availability;
        }
    }
}
