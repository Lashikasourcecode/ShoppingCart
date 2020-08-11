using BusinessLayer.PropertyClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface ICheckoutService
    {
        // public Task<List<ProductDetails>> checkProductAvailabilty(ProductDetails productDetails);
        //List
        //public List<ProductDetails> checkProductAvailabilty(List<ProductDetails> productDetails);


       // public ProductDetails checkProductAvailabilty(ProductDetails productDetails);


        public  List<CartItemDetails> checkProductAvailabilty(List<CartItemDetails> productDetails);
    }
}
