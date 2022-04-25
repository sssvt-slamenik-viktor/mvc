using System;
using System.Collections.Generic;

using PetEShopWebMVC.BusinessObjects;



namespace PetEShopWebMVC.Interfaces.Repos.Test
{



    public interface IBookRepo
    {



        IList<Book> GetList();

        IList<Book> FindList(Book book);

        bool Exists(Book book);

        Book Load(Book book);

        void Store(Book book);

        void Add(Book book);

        void Remove(Book book);



    }



}
