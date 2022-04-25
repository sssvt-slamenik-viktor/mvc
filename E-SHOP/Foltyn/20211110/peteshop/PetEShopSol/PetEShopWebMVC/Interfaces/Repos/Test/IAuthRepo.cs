using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Identity;



namespace PetEShopWebMVC.Interfaces.Repos.Test
{



    public interface IAuthRepo
    {



        IList<IdentityUser> GetList();



    }



}
