using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using PetEShopWebMVC.BusinessObjects;
using PetEShopWebMVC.Data;
using PetEShopWebMVC.Interfaces.Repos.Test;



namespace PetEShopWebMVC.Repos.Test
{



    /// <summary>
    /// Exposes CRUD methods for the business object Person.
    /// </summary>
    public class PersonRepo : IPersonRepo
    {




        //private readonly DbContext context;
        private readonly ApplicationDbContext context;



        //public PersonRepo(DbContext context)
        public PersonRepo(ApplicationDbContext context)
        {
            this.context = context;
        }



        /// <summary>
        /// Gets a complete list of all persons.
        /// </summary>
        /// <returns>Returns the list of all persons.</returns>
        public IList<Person> GetList()
        {
            var query = from u in context.Persons
                        select u;
            var persons = query.ToList<Person>();

            return persons;
        }



        /// <summary>
        /// Finds all persons matching given criteria (their ID and/or name).
        /// </summary>
        /// <param name="person">Criteria that the found persons should match.</param>
        /// <returns>Returns a list of matching persons.</returns>
        public IList<Person> FindList(Person person)
        {
            var query = from u in context.Persons
                        where u.Name == person.Name
                        select u;

            //IQueryable<Person> query = BuildQuery(context.Persons, person);

            var persons = query.ToList<Person>();
            return persons;
        }



        /// <summary>
        /// Checks the repo for a given person (their ID and/or name).
        /// </summary>
        /// <param name="person">Person to check the repo for.</param>
        /// <returns>Returns true :-: the person exists, false :-: the person does not exist.</returns>
        public bool Exists(Person person)
        {
            var query = from u in context.Persons
                        where u.Name == person.Name
                        select u;

            //IQueryable<Person> query = BuildQuery(context.Persons, person);

            var exists = query.Any<Person>();
            return exists;
        }



        /// <summary>
        /// Tries to load data about a given person (according to their ID) and returns the information loaded.
        /// </summary>
        /// <param name="person">Information identifying the person to be loaded (their ID).</param>
        /// <returns>Returns the requested person. If no such person exists, the method should throw an exception.</returns>
        public Person Load(Person person)
        {
            //if (!Exists(person))
            //{
            //    throw new Exception($"There's no such person with ID: {person.ID}");
            //}

            return context.Persons.Find(person.ID);
        }



        /// <summary>
        /// Tries to store (persist) data about a given person.
        /// </summary>
        /// <param name="person">Person to be persisted in the repo.</param>
        public void Store(Person person)
        {
            context.Entry(person).State = ((person.ID == 0) ? (EntityState.Added) : (EntityState.Modified));

            context.SaveChanges();
        }



        /// <summary>
        /// Adds a new person to the repo.
        /// </summary>
        /// <param name="person">Person to add.</param>
        public void Add(Person person)
        {
            context.Persons.Add(person);

            context.SaveChanges();
        }



        /// <summary>
        /// Removes a given person from the repo.
        /// </summary>
        /// <param name="person">Person to remove.</param>
        public void Remove(Person person)
        {
            context.Entry(person).State = EntityState.Deleted;

            context.SaveChanges();
        }



        private IQueryable<Person> BuildQuery(IQueryable<Person> query, Person person)
        {

            if (person.ID != 0)
            {
                query = query.Where(u => u.ID == person.ID);
            }
            if (person.Name != null)
            {
                query = query.Where(u => u.Name == person.Name);
            }
            // ...

            return query;

        }



    }




}
