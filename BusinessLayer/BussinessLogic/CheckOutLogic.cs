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

        //List<ProductDetails> productDetailslist = new List<ProductDetails>();

        List<OrderProductDetails> validProducts = new List<OrderProductDetails>();

        //List<ProductDetails> productsDetailList = new List<ProductDetails>();
          List<CartItemDetails> cartProductDetails = new List<CartItemDetails>();


        // ProductDetails productDetails = new ProductDetails();

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
                            //foreach (var vp in validProducts)
                            //{
                            //    // vp.Pid = products.ProductId;
                            //    // vp.productName = products.ProductName;

                            //    vp.StockAvailability = "InStock";
                            //}

                        }

                        else
                        {
                            productsdetail.Availability = "Out of Stock";
                            //foreach (var vp in validProducts)
                            //{
                            //    vp.StockAvailability = "Out of Stock";
                            //}
                        }



                    }
                    else
                    {
                        productsdetail.Availability = "Out of Stock";



                    }



                }

                // }








                // return productDetails;
                 // return cartproductDetaillist;




            }
           return productDetails;

        }
        //public ProductDetails checkProductAvailabilty(ProductDetails productDetails)
        //{

        //    IEnumerable<Product> prod = icheckOut.GetAllProducts();

        //    // List<Product> prod = icheckOut.GetAllProducts();
        //    //where().tolist
        //    var productDetailslist = prod.Where(x => x.ProductId == productDetails.ProductId).ToList();

        //    foreach (var products1 in productDetailslist)
        //    {
        //        if (products1.ProductId == productDetails.ProductId && products1.Quantity >= productDetails.Quantity)
        //        {
        //            productDetails.ProductId = products1.ProductId;
        //            productDetails.ProductName = products1.ProductName;
        //            productDetails.Quantity = products1.Quantity;

        //            if (productDetails.Quantity <= products1.Quantity)
        //            {
        //                foreach (var vp in validProducts)
        //                {

        //                    vp.StockAvailability = "InStok";
        //                }
        //            }
        //            else
        //            {
        //                foreach (var vp in validProducts)
        //                {
        //                    vp.StockAvailability = "out of stok";
        //                }
        //            }
        //        }
        //    }

        //    return productDetails;




        //}
    }
    
}
    

