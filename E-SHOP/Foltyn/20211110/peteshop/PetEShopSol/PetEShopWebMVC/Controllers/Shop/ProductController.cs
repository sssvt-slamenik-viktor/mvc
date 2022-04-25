using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

using PetEShopWebMVC.Interfaces.Services.Shop;
using PetEShopWebMVC.Models.Shop;
using PetEShopWebMVC.BusinessObjects;

namespace PetEShopWebMVC.Controllers.Shop
{



    [Route("product")]
    public class ProductController : Controller
    {



        private readonly ILogger<ProductController> logger;

        private readonly IProductService productService;



        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            this.logger = logger;
            this.productService = productService;
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}



        // GET /product/list
        [HttpGet("list")]
        public IActionResult List()
        {
            ICollection<Pet> pets = this.productService.GetPets();
            //return View("ProductList", new ProductListViewModel { Pets = pets });
            //return View("Shop/ProductList", new ProductListViewModel { Pets = pets });
            //return View("/Shop/ProductList", new ProductListViewModel { Pets = pets });
            //return View("/Views/Shop/ProductList", new ProductListViewModel { Pets = pets });
            return View("/Views/Shop/ProductList.cshtml", new ProductListViewModel { Pets = pets });
        }



        // GET /product/edit/?id=1
        [HttpGet("edit")]
        public IActionResult Edit([FromQuery] int id)
        {
            Pet pet = this.productService.GetPet(id);
            return View("/Views/Shop/ProductEdit.cshtml", new ProductEditViewModel { Pet = pet });
        }



        // GET /product/pet-edit/3
        //[HttpGet("pet-edit/:id")]
        [HttpGet("pet-edit/{id:int}")]
        public IActionResult PetEdit([FromRoute] int id)
        //public IActionResult PetEdit([FromQuery] int id)
        {
            Pet pet = this.productService.GetPet(id);
            return View("/Views/Shop/PetEdit.cshtml", pet);
        }



        // POST /product/pet-edit
        // POST /product/pet-edit/3
        //[HttpPost("pet-save")]
        //[HttpPost("pet-edit")]
        [HttpPost("pet-edit/{id:int}")]
        public IActionResult PetSave([FromRoute] int id, [FromForm] Pet pet)
        {
            this.logger.LogInformation(pet.ToString());
            return Redirect("/product/list");
        }



    }



}
