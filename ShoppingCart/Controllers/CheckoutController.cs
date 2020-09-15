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

        
       
        List<CartItemDetails> cartproductlist = new List<CartItemDetails>();

        [Route("checkproductavailabilty")]
        [HttpPost]
        public List<CartItemDetails> checkquantity([FromBody] List<CartItemDetails> products)
         {
            List<CartItemDetails> cartitemList = new List<CartItemDetails>();

             cartproductlist = icheckoutService.checkProductAvailabilty(products);

            if (cartproductlist != null)
            {
                foreach(var cartproduct in cartproductlist)
                {
                    CartItemDetails cartItemDetails = new CartItemDetails()
                    {
                        ProductId = cartproduct.ProductId,
                        ProductName = cartproduct.ProductName,
                        Quantity = cartproduct.Quantity,
                        Image = cartproduct.Image,
                        Description = cartproduct.Description,
                        UnitPrice = cartproduct.UnitPrice,
                        Availability =cartproduct.Availability,
                        Discount = cartproduct.Discount,
                    };

                    cartitemList.Add(cartItemDetails);
                }

            }

            //return  productlist;

            return cartitemList.ToList();
        }
       
    }
}
