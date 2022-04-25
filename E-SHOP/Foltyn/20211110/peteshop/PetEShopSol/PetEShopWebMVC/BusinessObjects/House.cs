using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PetEShopWebMVC.BusinessObjects
{


    [Table("PE_HOUSE")]
    public class House
    {



        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("WIDTH")]
        public double Width { get; set; }

        [Column("LENGTH")]
        public double Length { get; set; }



        public House()
        {
        }



        public House(string description, double width, double length)
        {
            this.Description = description;
            this.Width = width;
            this.Length = length;
        }



    }


}
