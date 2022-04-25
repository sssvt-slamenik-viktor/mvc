using System;
using System.Collections.Generic;

using PetEShopWebMVC.BusinessObjects;



namespace PetEShopWebMVC.Interfaces.Services.Shop
{



    public interface IProductService
    {



        ICollection<Pet> GetPets();

        Pet GetPet(int id);



    }



}
