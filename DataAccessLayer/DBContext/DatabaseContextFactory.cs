using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer.DBContext
{
    public class DatabaseContextFactory  : IDesignTimeDbContextFactory<ShoppingCartDBContext>
       {

        ShoppingCartDBContext IDesignTimeDbContextFactory<ShoppingCartDBContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ShoppingCartDBContext>();

            AppConfigurations appConfig = new AppConfigurations();
           
            optionsBuilder.UseSqlServer(appConfig.SQLConnection);

            return new ShoppingCartDBContext(optionsBuilder.Options);
        }

           // public ShoppingCartDBContext CreateShoppingCartDBContext(string[] args)
           // {
           // AppConfigurations appConfig = new AppConfigurations();
           // var optionsBuilder = new DbContextOptionsBuilder<ShoppingCartDBContext>();
           // //optionsBuilder.UseSqlServer("Data Source=blog.db");
           // optionsBuilder.UseSqlServer(appConfig.SQLConnection);

            //return new ShoppingCartDBContext(optionsBuilder.Options);
            //}

        
    }

    
}
