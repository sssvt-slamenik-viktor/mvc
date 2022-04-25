using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PetEShopWebMVC.BusinessObjects;
using PetEShopWebMVC.Interfaces.Repos.Test;
using PetEShopWebMVC.Interfaces.Services.Test;



namespace PetEShopWebMVC.Services.Test
{



    public class UserService : IUserService
    {



        private readonly IUserRepo userRepo;



        public UserService(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }



        public User RegisterUser(User newUser)
        {
            return null;
        }


        public User SaveUser(User user)
        {
            if (user.ID != 0)
            {
                // User already exists.
                // UPDATE
                this.userRepo.Store(user);
            }
            else
            {
                // Create a new user.
                // INSERT
                this.userRepo.Add(user);
            }
            return user;
        }



        public IList<User> GetAllUsers()
        {
            return this.userRepo.GetList();
        }


        public User GetUser(int id)
        {
            User userData = new User();
            userData.ID = id;
            return this.userRepo.Load(userData);
        }



    }



}
