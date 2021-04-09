    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Library.Models
{
    
        public class MyDB : DbContext
        {
            public MyDB()
            {

            }
            public DbSet<Customer> Customers { get; set; } // My domain models 
            public DbSet<Movie> Movies { get; set; }// My domain modelswe3
            public DbSet<MembershipType> MembershipTypes { get; set; }
            public DbSet<Genre> Genres { get; set; }
            public DbSet<Rental> Rentals { get; set; }
           
    }
    }
