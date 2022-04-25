using eshop_Slamenik.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


using eshop_Slamenik.Repos;
using eshop_Slamenik.Data;
using Microsoft.EntityFrameworkCore;
using eshop_Slamenik.BusinessObjects;
using Microsoft.AspNetCore.Http;

namespace eshop_Slamenik.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DbContextOptions<ApplicationDbContext> _contextOptions;

        public HomeController(ILogger<HomeController> logger, DbContextOptions<ApplicationDbContext> contextOptions)
        {
            _logger = logger;
            _contextOptions = contextOptions;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult ItemList()
        {
            using (var dbContext = new ApplicationDbContext(_contextOptions))
            {
                ItemRepo itemRepo = new ItemRepo(dbContext);
                var items = itemRepo.GetList();
                return View(new ItemModel { Items = items });
            }              
        }
        [HttpGet("Kosik")]
        public IActionResult Kosik()
        {
            List<string> listC = new List<string>();
            List<Itemy> listB = new List<Itemy>();

            if (Request.Cookies["LIST"] != null)
            {
                var words = Request.Cookies["LIST"].ToString();
                foreach (var word in words.Split("-"))
                {
                    listC.Add(word);
                }
                foreach (var i in listC)
                {
                    if (Request.Cookies[i].ToString() != null)
                    {
                        var ks = Request.Cookies[i].ToString();
                        listB.Add(new Itemy(Int32.Parse(i.Substring(i.Length - 1)), Int32.Parse(ks)));
                    }
                    else
                    {

                    }
                    
                }
            }                    
            else
            {
 
            }

            return View(new ItemyModel { list = listB });
        }

        [HttpGet("ItemDetail/{id}")]
        public IActionResult Detail(int id)
        {
            Item item;
            using (var dbContext = new ApplicationDbContext(_contextOptions))
            {
                var query = from i in dbContext.Items
                            where i.ID == id
                            select i;
                item = query.Single<Item>();
            }
            return View(new SingleItemModel { Item = item });
        }


        [HttpGet("Kosik/{id}")]
        public IActionResult AddItem(int id)
        {
            string cookievalue;
            string k = "Kosik_" + id;
            if (Request.Cookies[k] != null)
            {
                cookievalue = Request.Cookies[k].ToString();
                var cookieNumber = Int32.Parse(cookievalue);
                cookieNumber = cookieNumber+1;

                cookievalue = cookieNumber.ToString();

                HttpContext.Response.Cookies.Append(k, cookievalue, new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(7)
                });
            }
            else
            {
                HttpContext.Response.Cookies.Append(k, "1", new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(7)
                });

                if (Request.Cookies["LIST"] != null)
                {
                    var list = Request.Cookies["LIST"].ToString();
                    HttpContext.Response.Cookies.Append("LIST", list + "-" + k, new CookieOptions()
                    {
                        Expires = DateTime.Now.AddDays(7)
                    });
                }
                else
                {
                    HttpContext.Response.Cookies.Append("LIST", k, new CookieOptions()
                    {
                        Expires = DateTime.Now.AddDays(7)
                    });
                }
                    
                
            }
            return View("Index");
        }







        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
