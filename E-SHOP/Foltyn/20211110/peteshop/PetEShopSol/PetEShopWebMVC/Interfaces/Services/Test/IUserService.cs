using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PetEShopWebMVC.BusinessObjects;



namespace PetEShopWebMVC.Interfaces.Services.Test
{



    public interface IUserService
    {



        User RegisterUser(User newUser);


        User SaveUser(User user);


        IList<User> GetAllUsers();


        User GetUser(int id);



    }



}
