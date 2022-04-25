using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PetEShopWebMVC.BusinessObjects
{


    public class AirPlane
    {

        public string Type { get; set; }
        public int Capacity { get; set; }

        public AirPlane(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
        }

    }

}
