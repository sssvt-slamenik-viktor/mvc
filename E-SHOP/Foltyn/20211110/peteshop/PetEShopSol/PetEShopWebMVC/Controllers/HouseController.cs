using PetEShopWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using PetEShopWebMVC.BusinessObjects;
using PetEShopWebMVC.Interfaces.Services.Test;

using Microsoft.AspNetCore.Identity;



namespace PetEShopWebMVC.Controllers
{


    [Route("houses")]
    public class HouseController : Controller
    {


        private readonly IHouseService houseService;

        private readonly IAuthService authService;


        public HouseController(IHouseService houseService, IAuthService authService)
        {
            this.houseService = houseService;
            this.authService = authService;
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}



        // http://localhost:25630
        // GET   /House/Houses
        // http://localhost:25630/House/Houses
        public IActionResult Houses()
        {
            List<House> houses = new List<House>();
            houses.Add(new House("Rezidence nad mořem", 30.0, 20.0));
            houses.Add(new House("Vila u lesního paloučku", 10.0, 10.0));
            houses.Add(new House("Chata", 3.5, 4.0));
            houses.Add(new House("Rodinný dům", 20.0, 25.0));

            return View(new HouseModel { Houses = houses });
        }


        // POST /houses/save
        [HttpPost("save")]
        public IActionResult SaveHouse([FromForm] House house)
        {
            Console.WriteLine($"Descr.:  {house.Description}  Size: {house.Width}x{house.Length} m");

            return new OkResult();
        }



        // GET /houses/edit-house
        [HttpGet("edit-house")]
        public IActionResult ShowEditHouse()
        {
            return View("/Views/House/EditHouse.cshtml", new House());
        }


        // POST /House/EditHouse
        [HttpPost("/houses")]
        public IActionResult EditHouse([FromForm] House house)
        {
            Console.WriteLine($"Descr.:  {house.Description}  Size: {house.Width}x{house.Length} m");

            this.houseService.SaveHouse(house);

            return new OkResult();
        }



        // GET /houses/list-users
        [HttpGet("list-users")]
        public IActionResult ListIdentityUsers()
        {
            IList<IdentityUser> identityUsers = this.authService.GetIdentityUsers();

            return View("IdentityUsers", new IdentityUsersModel { IdentityUsers = identityUsers });
        }



    }



}
