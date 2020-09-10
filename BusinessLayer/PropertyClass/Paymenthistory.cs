using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PropertyClass
{
    public class Paymenthistory
    {
        public int customerId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string paymentMethod { get; set; }

        public double total { get; set; }

        public List<CartItemModel> cartItemModel { get; set; }







   
    }
}
