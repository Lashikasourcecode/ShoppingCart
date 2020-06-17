using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.ComponentModel;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.DBContext
{
    public class ShoppingCartDBContext:DbContext
    {

        public class OptionBuild {

            public OptionBuild()
            {
                appConfigurations = new AppConfigurations();
                optionsBuilder = new DbContextOptionsBuilder<ShoppingCartDBContext>();
                optionsBuilder.UseSqlServer(appConfigurations.SQLConnection);
                dbOption = optionsBuilder.Options;
            }

            public DbContextOptionsBuilder<ShoppingCartDBContext> optionsBuilder { get; set; }
            public DbContextOptions<ShoppingCartDBContext> dbOption { get; set; }
            private AppConfigurations appConfigurations { get; set; }


        }

        public static OptionBuild optionBuild = new OptionBuild();

        public ShoppingCartDBContext(DbContextOptions<ShoppingCartDBContext> options) : base(options)
        {

        }

        //Entities
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; } 
        public DbSet<Payment> Payments { get; set; }

        public DbSet<Product> products { get; set; }

      

    }
        
      
}

