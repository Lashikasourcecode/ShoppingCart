using DataAccessLayer.DBContext;
using DataAccessLayer.Interface;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Function
{
    public class CheckoutDBfunction:ICheckOut
    {


        //GetAllProduct(List<int> productId);
        // public IEnumerable<Product> GetAllProducts()


        //public IEnumerable<Product> GetAllProducts()
        //{
        //    List<Product> products = new List<Product>();

        //    using (var context = new ShoppingCartDBContext(ShoppingCartDBContext.optionBuild.dbOption))
        //    {
        //        products = context.products.ToList();
        //    }

        //    return products;
        //}

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            using (var context = new ShoppingCartDBContext(ShoppingCartDBContext.optionBuild.dbOption))
            {
                products = context.products.ToList();
            }

            return products;
        }






        //public async  Task<List<Product>> GetAllProductsQuantity(int productId)
        //{
        //    List<Product> productList = new List<Product>();

        //    using (var context = new ShoppingCartDBContext(ShoppingCartDBContext.optionBuild.dbOption))
        //    {
        //        productList = await context.products.ToListAsync();
        //    }

        //    return productList;
        //}
    }
}
