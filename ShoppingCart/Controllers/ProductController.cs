using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using BusinessLayer.PropertyClass;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.BussinessLogic;

namespace ShoppingCart.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private ProductListLogic accessProduct = new ProductListLogic();

        [Route("getproduct")]
        [HttpGet]

        public async Task<List<ProductDetails>> GetProducts()
        {
            List<ProductDetails> productDetailslist = new List<ProductDetails>();

            var product = await accessProduct.GetAllProduct();

            if (product.Count >0)
            {
                foreach (var products in product)
                {
                    ProductDetails productdetailsmodel = new ProductDetails()
                    {
                        ProductId = products.ProductId,
                        ProductName = products.ProductName,
                        Quantity = products.Quantity,
                        UnitPrice = products.UnitPrice,
                        image = products.image,
                        Description = products.Description
                       

                    };

                    productDetailslist.Add(productdetailsmodel);

                }
            }
            
            return productDetailslist;

        }


    }
}

