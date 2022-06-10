using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Type { get; set; }

        public int PagesNumber { get; set; }



        public int AuthorId { get; set; }
        public Author author { get; set; }


  





    }

}
