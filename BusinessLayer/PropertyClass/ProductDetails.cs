using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PropertyClass
{
    public class ProductDetails
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string image { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public double Discount { get; set; } 

       // public List<ProductDetails> cartproductlist { get; set; }

        public List<PaymentConformation> payment { get; set; } 

        

    }

    
}