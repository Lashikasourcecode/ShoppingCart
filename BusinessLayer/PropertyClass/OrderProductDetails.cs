using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PropertyClass
{
    public class OrderProductDetails
    {
        public int Pid { get; set; }
        public string productName { get; set; }

        public int Quantity { get; set; }

        public string StockAvailability { get; set; }
    }

    //public List<ValidProductDetails> validProducts
    //{
    //    set { value = ValidProductDetails}
    //}
}
