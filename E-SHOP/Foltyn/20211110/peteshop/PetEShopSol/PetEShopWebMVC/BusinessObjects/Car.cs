using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetEShopWebMVC.BusinessObjects
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Car(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }
    }
}
