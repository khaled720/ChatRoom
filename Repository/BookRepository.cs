using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class BookRepository
    {
        private static AppDbContext appDbContext =new AppDbContext();

        public static void SaveBook(Book book)
        {

            appDbContext.Add(book);
            appDbContext.SaveChanges();
        }
        public static void DeleteBook(int Id)
        {

            appDbContext.Books.Remove(appDbContext.Books.First(y=>y.Id==Id));
            appDbContext.SaveChanges();
        }

        public static void UpdateBook(Book book)
        {

            Book dbBook = appDbContext.Books.First(t=>t.Id==book.Id);

            //  if(ModelState)
            dbBook.Title = book.Title;
            dbBook.PagesNumber = book.PagesNumber;
            dbBook.Type = book.Type;
            

                appDbContext.Update(dbBook);

            

            appDbContext.SaveChanges();
        }
        public static IEnumerable<Book> GetAllBooks()
        {
          

            return appDbContext.Books.ToList();

        }

        public static Book FindBook(Book book)
        {

       var result=     appDbContext.Books.FirstOrDefault(t=>t.Id==book.Id);
            return result;
        }


    }
}
