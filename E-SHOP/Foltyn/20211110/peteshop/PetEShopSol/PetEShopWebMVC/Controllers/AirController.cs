using Microsoft.AspNetCore.Mvc;
using PetEShopWebMVC.BusinessObjects;
using PetEShopWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetEShopWebMVC.Controllers
{

    public class AirController : Controller
    {

        //public IActionResult Index()
        //{
        //    return View();
        //}


        // GET /Air/AirPlanes
        public IActionResult AirPlanes()
        {
            List<AirPlane> airPlanes = new List<AirPlane>();
            airPlanes.Add(new AirPlane("Airbus A220", 130));
            airPlanes.Add(new AirPlane("Airbus A300", 254));
            airPlanes.Add(new AirPlane("Airbus A380", 555));
            airPlanes.Add(new AirPlane("Boeing 737", 215));
            airPlanes.Add(new AirPlane("Boeing 777", 550));
            return View( new AirPlaneModel { AirPlanes = airPlanes } );
        }

    }


}
