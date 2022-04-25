using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using PetEShopWebMVC.BusinessObjects;
using PetEShopWebMVC.Interfaces.Repos.Test;
using PetEShopWebMVC.Interfaces.Services.Test;



namespace PetEShopWebMVC.Services.Test
{


    public class HouseService : IHouseService
    {

        private readonly IHouseRepo houseRepo;

        public HouseService(IHouseRepo houseRepo)
        {
            this.houseRepo = houseRepo;
        }


        public House SaveHouse(House house)
        {
            if (house.ID == 0)
            {
                // INSERT
                this.houseRepo.Add(house);
            }
            else
            {
                // UPDATE
                this.houseRepo.Store(house);
            }
            return house;
        }

    }

}
