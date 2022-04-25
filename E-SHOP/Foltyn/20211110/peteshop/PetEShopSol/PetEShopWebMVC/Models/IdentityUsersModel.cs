using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Identity;



namespace PetEShopWebMVC.Models
{
    public class IdentityUsersModel
    {

        public ICollection<IdentityUser> IdentityUsers { get; set; }

    }
}
