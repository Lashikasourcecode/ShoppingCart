using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.PropertyClass;
using BusinessLayer.Interface;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {

        private readonly ICheckoutService icheckoutService;

        public CheckoutController(ICheckoutService checkoutService)
        {
            icheckoutService = checkoutService;
        }

        // List<ProductDetails> productlist = new List<ProductDetails>();
        List<CartItemDetails> cartproductlist = new List<CartItemDetails>();

        [Route("checkproductavailabilty")]
        [HttpPost]
        public List<CartItemDetails> checkquantity(List<CartItemDetails> products)
         {
             cartproductlist = icheckoutService.checkProductAvailabilty(products);

            if (cartproductlist != null)
            {
                return cartproductlist;

            }

            //return  productlist;

            return products;
        }
        // public ProductDetails checkquantity(ProductDetails products)
        // {
        //    //var p
        //    var productlist =  icheckoutService.checkProductAvailabilty(products);

        //    if (productlist != null)
        //    {
        //     //   // p.ProductId = productId;

        //    }

        //    //return  productlist;

        //    return products;

          



        //}
    }
}
