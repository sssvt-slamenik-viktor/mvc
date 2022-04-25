using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;



namespace PetEShopWebMVC.Models
{



    public class IdentityUsersListModel
    {



        public ICollection<IdentityUser> IdentityUsers { get; set; }



    }



}
