using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



using PetEShopWebMVC.BusinessObjects;



namespace PetEShopWebMVC.Models
{


    public class BookModel
    {
        public ICollection<Book> Books { get; set; }
    }


}
