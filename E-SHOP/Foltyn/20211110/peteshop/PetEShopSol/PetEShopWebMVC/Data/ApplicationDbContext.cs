using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


using MySql.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;


using PetEShopWebMVC.BusinessObjects;
using Microsoft.AspNetCore.Identity;

namespace PetEShopWebMVC.Data
{



    public class ApplicationDbContext : IdentityDbContext
    //public class ApplicationDbContext : DbContext
    //public class ApplicationDbContext : MySqlDbContext
    {



        //public DbSet<PetEShopWebMVC.BusinessObjects.Pet> Pet { get; set; }
        //public DbSet<Pet> Pets { get; set; }
        //public DbSet<User> Users { get; set; }
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<User> TestUsers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<House> Houses { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base()
        {
        }



    }



}
