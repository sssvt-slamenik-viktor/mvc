using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using eshop_Slamenik.Models;
using eshop_Slamenik.Data;

namespace eshop_Slamenik.DAL
{
    public class ItemContext : IdentityDbContext
    {
        public ItemContext()
            : base()
        {
        }
    }
}
