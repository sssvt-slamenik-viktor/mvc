using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using eshop_Slamenik.BusinessObjects;
using eshop_Slamenik.Data;
using eshop_Slamenik.Interfaces;

namespace eshop_Slamenik.Repos
{
    public class ItemRepo : IItemRepo
    {

        private readonly ApplicationDbContext context;

        public ItemRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IList<Item> GetList()
        {
            var query = from u in context.Items
                        select u;
            var items = query.ToList<Item>();

            return items;
        }

        public bool Exists(Item item)
        {
            var query = from u in context.Items
                        where u.Name == item.Name
                        select u;

            //IQueryable<Item> query = BuildQuery(context.Items, item);

            var exists = query.Any<Item>();
            return exists;
        }

        public Item Load(Item item)
        {
            if (!Exists(item))
            {
                throw new Exception($"There's no such item with ID: {item.ID}");
            }

            return context.Items.Find(item.ID);
        }
        public void Store(Item item)
        {
            context.Entry(item).State = ((item.ID == 0) ? (EntityState.Added) : (EntityState.Modified));

            context.SaveChanges();
        }

        public void Add(Item item)
        {
            context.Items.Add(item);

            context.SaveChanges();
        }

        public void Remove(Item item)
        {
            context.Entry(item).State = EntityState.Deleted;

            context.SaveChanges();
        }





    }
}
