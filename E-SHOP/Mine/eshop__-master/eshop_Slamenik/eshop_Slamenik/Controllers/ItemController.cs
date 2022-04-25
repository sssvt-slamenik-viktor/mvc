using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using eshop_Slamenik.BusinessObjects;
using eshop_Slamenik.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace eshop_Slamenik.Controllers
{
    [Route("item")]
    public class ItemController : Controller
    {
        private readonly IConfiguration _configuration;


        public ItemController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("list")]
        public IActionResult GetItems()
        {
            List<Item> books = new List<Item>();
            string connString = _configuration.GetConnectionString("MssqlSchoolConnection");
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            



            return View("BookList", new ItemModel { Items = books });
        }
    }
}
