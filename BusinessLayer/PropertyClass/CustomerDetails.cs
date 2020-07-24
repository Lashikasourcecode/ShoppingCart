using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PropertyClass
{
    public class CustomerDetails
    {
        public int CustomerId { get; set; }

        public string Password { get; set; }

        public string firstName { get; set; }

        public string LastName { get; set; }

        public string BilingAddress { get; set; }

        public string DeliveryAddress { get; set; }

        public string DeliveryCity { get; set; }

        public string MobileNo { get; set; }

        public string Email { get; set; }

       // public CustomerDetails _customerDetails
       // {
           // get { return _customerDetails; }
           // set { value = _customerDetails; }
        //}

    }

    
}
