using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using PetEShopWebMVC.BusinessObjects;
using PetEShopWebMVC.Data;
using PetEShopWebMVC.Interfaces.Repos.Test;



namespace PetEShopWebMVC.Repos.Test
{



    /// <summary>
    /// Exposes CRUD methods for the business object Book.
    /// </summary>
    public class BookRepo : IBookRepo
    {




        //private readonly DbContext context;
        private readonly ApplicationDbContext context;



        //public BookRepo(DbContext context)
        public BookRepo(ApplicationDbContext context)
        {
            this.context = context;
        }



        /// <summary>
        /// Gets a complete list of all books.
        /// </summary>
        /// <returns>Returns the list of all books.</returns>
        public IList<Book> GetList()
        {
            var query = from u in context.Books
                        select u;
            var books = query.ToList<Book>();

            return books;
        }



        /// <summary>
        /// Finds all books matching given criteria (their ID and/or name).
        /// </summary>
        /// <param name="book">Criteria that the found books should match.</param>
        /// <returns>Returns a list of matching books.</returns>
        public IList<Book> FindList(Book book)
        {
            var query = from u in context.Books
                        where u.Title == book.Title
                        select u;

            //IQueryable<Book> query = BuildQuery(context.Books, book);

            var books = query.ToList<Book>();
            return books;
        }



        /// <summary>
        /// Checks the repo for a given book (their ID and/or name).
        /// </summary>
        /// <param name="book">Book to check the repo for.</param>
        /// <returns>Returns true :-: the book exists, false :-: the book does not exist.</returns>
        public bool Exists(Book book)
        {
            var query = from u in context.Books
                        where u.Title == book.Title
                        select u;

            //IQueryable<Book> query = BuildQuery(context.Books, book);

            var exists = query.Any<Book>();
            return exists;
        }



        /// <summary>
        /// Tries to load data about a given book (according to their ID) and returns the information loaded.
        /// </summary>
        /// <param name="book">Information identifying the book to be loaded (their ID).</param>
        /// <returns>Returns the requested book. If no such book exists, the method should throw an exception.</returns>
        public Book Load(Book book)
        {
            if (!Exists(book))
            {
                throw new Exception($"There's no such book with ID: {book.ID}");
            }

            return context.Books.Find(book.ID);
        }



        /// <summary>
        /// Tries to store (persist) data about a given book.
        /// </summary>
        /// <param name="book">Book to be persisted in the repo.</param>
        public void Store(Book book)
        {
            context.Entry(book).State = ((book.ID == 0) ? (EntityState.Added) : (EntityState.Modified));

            context.SaveChanges();
        }



        /// <summary>
        /// Adds a new book to the repo.
        /// </summary>
        /// <param name="book">Book to add.</param>
        public void Add(Book book)
        {
            context.Books.Add(book);

            context.SaveChanges();
        }



        /// <summary>
        /// Removes a given book from the repo.
        /// </summary>
        /// <param name="book">Book to remove.</param>
        public void Remove(Book book)
        {
            context.Entry(book).State = EntityState.Deleted;

            context.SaveChanges();
        }



        private IQueryable<Book> BuildQuery(IQueryable<Book> query, Book book)
        {

            if (book.ID != 0)
            {
                query = query.Where(u => u.ID == book.ID);
            }
            if (book.Title != null)
            {
                query = query.Where(u => u.Title == book.Title);
            }
            // ...

            return query;

        }



    }




}
