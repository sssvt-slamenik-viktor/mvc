using PetEShopWebMVC.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetEShopWebMVC.Models
{
    public class AirPlaneModel
    {
        public ICollection<AirPlane> AirPlanes { get; set; }
    }
}
