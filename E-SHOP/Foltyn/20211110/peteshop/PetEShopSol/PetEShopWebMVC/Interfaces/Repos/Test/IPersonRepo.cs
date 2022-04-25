using System;
using System.Collections.Generic;

using PetEShopWebMVC.BusinessObjects;



namespace PetEShopWebMVC.Interfaces.Repos.Test
{



    public interface IPersonRepo
    {



        IList<Person> GetList();

        IList<Person> FindList(Person person);

        bool Exists(Person person);

        Person Load(Person person);

        void Store(Person person);

        void Add(Person person);

        void Remove(Person person);



    }



}
