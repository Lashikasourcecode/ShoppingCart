using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface ICheckOut
    {
        //product id,name,quantity,price
        //get product quantity
        // Task<List<Product>> GetAllProductsQuantity(int productId);



       // public IEnumerable<Product> GetAllProducts();
        public List<Product> GetAllProducts();
    }
}
