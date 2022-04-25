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
    /// Exposes CRUD methods for the business object User.
    /// </summary>
    public class TestUserRepo : IUserRepo
    {




        //private readonly DbContext context;
        private readonly ApplicationDbContext context;



        //public UserRepo(DbContext context)
        public TestUserRepo(ApplicationDbContext context)
        {
            this.context = context;
        }



        /// <summary>
        /// Gets a complete list of all users.
        /// </summary>
        /// <returns>Returns the list of all users.</returns>
        public IList<User> GetList()
        {
            //var query = from u in context.Users
            var query = from u in context.TestUsers
                        select u;
            var users = query.ToList<User>();

            return users;
        }



        /// <summary>
        /// Finds all users matching given criteria (their ID and/or username).
        /// </summary>
        /// <param name="user">Criteria that the found users should match.</param>
        /// <returns>Returns a list of matching users.</returns>
        public IList<User> FindList(User user)
        {
            //var query = from u in context.Users
            var query = from u in context.TestUsers
                        where u.Username == user.Username
                        select u;

            // //IQueryable<User> query = BuildQuery(context.Users, user);
            //IQueryable<User> query = BuildQuery(context.TestUsers, user);

            var users = query.ToList<User>();
            return users;
        }



        /// <summary>
        /// Checks the repo for a given user (their ID and/or username).
        /// </summary>
        /// <param name="user">User to check the repo for.</param>
        /// <returns>Returns true :-: the user exists, false :-: the user does not exist.</returns>
        public bool Exists(User user)
        {
            //var query = from u in context.Users
            var query = from u in context.TestUsers
                        where u.Username == user.Username
                        select u;

            // //IQueryable<User> query = BuildQuery(context.Users, user);
            //IQueryable<User> query = BuildQuery(context.TestUsers, user);

            var exists = query.Any<User>();
            return exists;
        }



        /// <summary>
        /// Tries to load data about a given user (according to their ID) and returns the information loaded.
        /// </summary>
        /// <param name="user">Information identifying the user to be loaded (their ID).</param>
        /// <returns>Returns the requested user. If no such user exists, the method should throw an exception.</returns>
        public User Load(User user)
        {
            //if (!Exists(user))
            //{
            //    throw new Exception($"There's no such user with ID: {user.ID}");
            //}

            //return context.Users.Find(user.ID);
            return context.TestUsers.Find(user.ID);
        }



        /// <summary>
        /// Tries to store (persist) data about a given user.
        /// </summary>
        /// <param name="user">User to be persisted in the repo.</param>
        public void Store(User user)
        {
            context.Entry(user).State = ((user.ID == 0) ? (EntityState.Added) : (EntityState.Modified));

            context.SaveChanges();
        }



        /// <summary>
        /// Adds a new user to the repo.
        /// </summary>
        /// <param name="user">User to add.</param>
        public void Add(User user)
        {
            //context.Users.Add(user);
            context.TestUsers.Add(user);

            context.SaveChanges();
        }



        /// <summary>
        /// Removes a given user from the repo.
        /// </summary>
        /// <param name="user">User to remove.</param>
        public void Remove(User user)
        {
            context.Entry(user).State = EntityState.Deleted;

            context.SaveChanges();
        }



        private IQueryable<User> BuildQuery(IQueryable<User> query, User user)
        {

            if (user.ID != 0)
            {
                query = query.Where(u => u.ID == user.ID);
            }
            if (user.Username != null)
            {
                query = query.Where(u => u.Username == user.Username);
            }
            // ...

            return query;

        }



    }




}
