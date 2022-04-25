using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PetEShopWebMVC.BusinessObjects;



namespace PetEShopWebMVC.Interfaces.Services.Test
{
    public interface IBookService
    {

        Book SaveBook(Book book);

    }
}
