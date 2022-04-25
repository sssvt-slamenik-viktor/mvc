using System;
using System.Collections.Generic;

using PetEShopWebMVC.BusinessObjects;



namespace PetEShopWebMVC.Interfaces.Services.Test
{



    public interface IPersonService
    {


        IList<Person> GetPersons();

        Person GetPerson(int id);

        Person SavePerson(Person person);



    }



}
