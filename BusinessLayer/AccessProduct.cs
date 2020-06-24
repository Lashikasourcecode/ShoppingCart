using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Interface;
using DataAccessLayer.Model;
using System.Data;


namespace BusinessLayer
{
    public class AccessProduct
    {

        private IProducts _productlist = new DataAccessLayer.Function.ShoppingCartDBFunction();

        //public DataAccessLayer dataAccess = new DataAccessLayer()
                        

        public async Task<List<Product>> GetAllProduct()
        {
            List<Product> products = await _productlist.GetAllProducts();
            return products;
        }
    }
}
