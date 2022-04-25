using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using eshop_Slamenik.BusinessObjects;
namespace eshop_Slamenik.Interfaces
{
    public interface IItemRepo
    {

        IList<Item> GetList();

        bool Exists(Item item);

        Item Load(Item item);

        void Store(Item item);

        void Add(Item item);

        void Remove(Item item);

    }
}
