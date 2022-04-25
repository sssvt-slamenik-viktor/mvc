using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;



namespace PetEShopWebMVC.Interfaces.Services.Test
{



    public interface IAuthService
    {



        IList<IdentityUser> GetIdentityUsers();



    }



}
