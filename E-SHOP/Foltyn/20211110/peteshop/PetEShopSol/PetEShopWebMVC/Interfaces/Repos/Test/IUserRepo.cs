using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PetEShopWebMVC.BusinessObjects;



namespace PetEShopWebMVC.Interfaces.Repos.Test
{



    public interface IUserRepo
    {



        IList<User> GetList();

        IList<User> FindList(User user);

        bool Exists(User user);

        User Load(User user);

        void Store(User user);

        void Add(User user);

        void Remove(User user);



    }



}
