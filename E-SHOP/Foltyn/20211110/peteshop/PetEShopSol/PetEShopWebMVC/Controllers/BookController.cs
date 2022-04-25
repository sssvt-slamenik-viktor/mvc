using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PetEShopWebMVC.BusinessObjects;
using PetEShopWebMVC.Models;

namespace PetEShopWebMVC.Controllers
{




    public class BookController : Controller
    {

        //public IActionResult Booklist()
        //{
        //    return View("~/Views/Book/BookList");
        //}

        // GET /book/list
        // GET /Book/GetBooks
        //[HttpGet("list")]

        


        public IActionResult BookList()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("Kuchařka z listového těsta", 2015));
            books.Add(new Book("Život Steva Jobse", 2021));
            books.Add(new Book("Pod skalou u řeky", 1997));
            books.Add(new Book("Matrix I", 2008));
            books.Add(new Book("Matrix II", 2012));



            return View(new BookModel { Books = books });
        }



        // POST /book/save
        [HttpPost("save")]
        public IActionResult SaveBook([FromForm] Book book)
        {
            Console.WriteLine($"Title: {book.Title}    Published In: {book.PublishedIn}");

            return new OkResult();
        }



        // GET /book/edit
        [HttpGet("edit")]
        public IActionResult ShowEditBook()
        {
            return View("BookEdit", new Book());
        }


        // POST /book/edit
        //[HttpPost("edit")]
        [HttpPost("/Book/BookEdit")]
        public IActionResult ProcessEditBook([FromForm] Book book)
        {
            Console.WriteLine(book.Title);
            Console.WriteLine(book.PublishedIn);

            return new OkResult();
        }



    }



}
