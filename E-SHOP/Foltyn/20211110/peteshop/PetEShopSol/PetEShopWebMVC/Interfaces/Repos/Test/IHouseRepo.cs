using System;
using System.Collections.Generic;

using PetEShopWebMVC.BusinessObjects;



namespace PetEShopWebMVC.Interfaces.Repos.Test
{



    public interface IHouseRepo
    {



        IList<House> GetList();

        IList<House> FindList(House house);

        bool Exists(House house);

        House Load(House house);

        void Store(House house);

        void Add(House house);

        void Remove(House house);



    }



}
