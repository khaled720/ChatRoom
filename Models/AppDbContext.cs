using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{

    
    public class AppDbContext : DbContext
    {
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder options) {
// Connection String Must Not be Hard coded it must be inside appSetting file 
            options.UseSqlServer("Data Source = (localdb)\\mssqllocaldb; Initial Catalog = MYDATABASE");
       
        }

    }
}
