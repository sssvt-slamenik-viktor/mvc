using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace PetEShopWebMVC.BusinessObjects
{


    [Table("PE_BOOK")]
    public class Book
    {

        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("PUBLISHED_IN")]
        public int PublishedIn { get; set; }

        public Book(string title, int publishedIn)
        {
            this.Title = title;
            this.PublishedIn = publishedIn;
        }

        public Book()
        {
        }

    }
}
