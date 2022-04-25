using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PetEShopWebMVC.BusinessObjects;
using PetEShopWebMVC.Interfaces.Repos.Test;
using PetEShopWebMVC.Interfaces.Services.Test;



namespace PetEShopWebMVC.Services.Test
{



    public class PersonService : IPersonService
    {



        private readonly IPersonRepo personRepo;



        public PersonService(IPersonRepo personRepo)
        {
            this.personRepo = personRepo;
        }



        public IList<Person> GetPersons()
        {
            return this.personRepo.GetList();
        }


        public Person GetPerson(int id)
        {
            Person emptyPerson = new Person();
            emptyPerson.ID = id;
            return this.personRepo.Load(emptyPerson);
        }



        public Person SavePerson(Person person)
        {
            if (person.ID != 0)
            {
                // Person already exists.
                // UPDATE
                this.personRepo.Store(person);
            }
            else
            {
                // Create a new person.
                // INSERT
                this.personRepo.Add(person);
            }
            return person;
        }



    }



}
