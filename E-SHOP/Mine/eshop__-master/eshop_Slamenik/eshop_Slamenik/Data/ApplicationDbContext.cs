using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

using eshop_Slamenik.BusinessObjects;

namespace eshop_Slamenik.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Item> Items { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
    }
}
