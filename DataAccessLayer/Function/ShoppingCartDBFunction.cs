using DataAccessLayer.DBContext;
using DataAccessLayer.Interface;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Function
{
    public class ShoppingCartDBFunction:IProducts
    {

        public async Task<List<Product>> GetAllProducts()
        {

            List<Product> productlist = new List<Product>();

            using (var context = new ShoppingCartDBContext(ShoppingCartDBContext.optionBuild.dbOption))
            {
                productlist = await context.products.ToListAsync();

            }

            return productlist;

        }

    }
}









