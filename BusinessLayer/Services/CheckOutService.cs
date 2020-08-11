
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interface;
using BusinessLayer.BussinessLogic;
using BusinessLayer.PropertyClass;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
   public  class CheckOutService:ICheckoutService
    {
        private CheckOutLogic checkOutLogic = new CheckOutLogic();


        public List<CartItemDetails> checkProductAvailabilty(List<CartItemDetails> productDetails)
        {
            var productslist = checkOutLogic.checkProductAvailabilty(productDetails);

            return productslist;
        }


        // ProductDetails productslist = new ProductDetails();

        //public ProductDetails checkProductAvailabilty(ProductDetails productDetails)
        //{
        //   var productslist = checkOutLogic.checkProductAvailabilty(productDetails);

        //    return productslist;
        //}


    }
}
