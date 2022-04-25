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
    /// Exposes CRUD methods for the business object House.
    /// </summary>
    public class HouseRepo : IHouseRepo
    {




        //private readonly DbContext context;
        private readonly ApplicationDbContext context;



        //public HouseRepo(DbContext context)
        public HouseRepo(ApplicationDbContext context)
        {
            this.context = context;
        }



        /// <summary>
        /// Gets a complete list of all houses.
        /// </summary>
        /// <returns>Returns the list of all houses.</returns>
        public IList<House> GetList()
        {
            var query = from u in context.Houses
                        select u;
            var houses = query.ToList<House>();

            return houses;
        }



        /// <summary>
        /// Finds all houses matching given criteria (their ID and/or name).
        /// </summary>
        /// <param name="house">Criteria that the found houses should match.</param>
        /// <returns>Returns a list of matching houses.</returns>
        public IList<House> FindList(House house)
        {
            var query = from u in context.Houses
                        where u.Description == house.Description
                        select u;

            //IQueryable<House> query = BuildQuery(context.Houses, house);

            var houses = query.ToList<House>();
            return houses;
        }



        /// <summary>
        /// Checks the repo for a given house (their ID and/or name).
        /// </summary>
        /// <param name="house">House to check the repo for.</param>
        /// <returns>Returns true :-: the house exists, false :-: the house does not exist.</returns>
        public bool Exists(House house)
        {
            var query = from u in context.Houses
                        where u.Description == house.Description
                        select u;

            //IQueryable<House> query = BuildQuery(context.Houses, house);

            var exists = query.Any<House>();
            return exists;
        }



        /// <summary>
        /// Tries to load data about a given house (according to their ID) and returns the information loaded.
        /// </summary>
        /// <param name="house">Information identifying the house to be loaded (their ID).</param>
        /// <returns>Returns the requested house. If no such house exists, the method should throw an exception.</returns>
        public House Load(House house)
        {
            if (!Exists(house))
            {
                throw new Exception($"There's no such house with ID: {house.ID}");
            }

            return context.Houses.Find(house.ID);
        }



        /// <summary>
        /// Tries to store (persist) data about a given house.
        /// </summary>
        /// <param name="house">House to be persisted in the repo.</param>
        public void Store(House house)
        {
            context.Entry(house).State = ((house.ID == 0) ? (EntityState.Added) : (EntityState.Modified));

            context.SaveChanges();
        }



        /// <summary>
        /// Adds a new house to the repo.
        /// </summary>
        /// <param name="house">House to add.</param>
        public void Add(House house)
        {
            context.Houses.Add(house);

            context.SaveChanges();
        }



        /// <summary>
        /// Removes a given house from the repo.
        /// </summary>
        /// <param name="house">House to remove.</param>
        public void Remove(House house)
        {
            context.Entry(house).State = EntityState.Deleted;

            context.SaveChanges();
        }



        private IQueryable<House> BuildQuery(IQueryable<House> query, House house)
        {

            if (house.ID != 0)
            {
                query = query.Where(u => u.ID == house.ID);
            }
            if (house.Description != null)
            {
                query = query.Where(u => u.Description == house.Description);
            }
            // ...

            return query;

        }



    }




}
