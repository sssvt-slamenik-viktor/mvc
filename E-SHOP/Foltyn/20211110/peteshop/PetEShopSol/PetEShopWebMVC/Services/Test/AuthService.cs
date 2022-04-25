using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;

using PetEShopWebMVC.Interfaces.Repos.Test;
using PetEShopWebMVC.Interfaces.Services.Test;



namespace PetEShopWebMVC.Services.Test
{



    public class AuthService : IAuthService
    {



        private readonly IAuthRepo authRepo;



        public AuthService(IAuthRepo authRepo)
        {
            this.authRepo = authRepo;
        }



        public IList<IdentityUser> GetIdentityUsers()
        {
            return this.authRepo.GetList();
        }



    }



}
