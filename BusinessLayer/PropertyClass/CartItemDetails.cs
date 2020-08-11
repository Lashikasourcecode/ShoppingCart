using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PropertyClass
{
   public  class CartItemDetails
    {

        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string image { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public double Discount { get; set; }
       
        public string Availability { get; set; }

       // public List<ProductDetails> productList { get; set; }
    }
}
