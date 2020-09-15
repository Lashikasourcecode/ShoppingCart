using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Function;
using BusinessLayer.PropertyClass;
using System.Threading.Tasks;
using System.Linq;
using DataAccessLayer.Model;

namespace BusinessLayer.BussinessLogic
{
    public class CheckOutLogic
    {

        public ICheckOut icheckOut = new CheckoutDBfunction();

       
        List<OrderProductDetails> validProducts = new List<OrderProductDetails>();

       
          List<CartItemDetails> cartProductDetails = new List<CartItemDetails>();


       

        //List
        public List<CartItemDetails> checkProductAvailabilty(List<CartItemDetails> productDetails)
        {
            List<Product> prod = icheckOut.GetAllProducts();

           

            foreach (var productsdetail in productDetails)
            {
                //  productsDetailList
                var cartproductDetaillist = prod.Where(x => x.ProductId == productsdetail.ProductId).ToList();

                //}


                foreach (var productsmodel in cartproductDetaillist)
                {
                    if (productsmodel.ProductId == productsdetail.ProductId && productsmodel.Quantity >= productsdetail.Quantity)
                    {

                        productsdetail.ProductId = productsmodel.ProductId;
                        productsdetail.ProductName = productsmodel.ProductName;
                        productsdetail.Image = productsmodel.image;
                        productsdetail.Description = productsmodel.Description;
                        // productsdetail.Quantity = productsmodel.Quantity;
                        productsdetail.Quantity = productsdetail.Quantity;


                        if (productsmodel.Quantity >= productsdetail.Quantity)
                        {

                            productsdetail.Availability = "InStok";
                           

                        }

                        else
                        {
                            productsdetail.Availability = "Out of Stock";
                            
                        }



                    }
                    else
                    {
                        productsdetail.Availability = "Out of Stock";



                    }



                }

                



            }
           return productDetails;

        }
      



        
    }
    
}
    

