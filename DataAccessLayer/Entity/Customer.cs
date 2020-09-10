using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BilingAddress { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeleveryCity { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        // public ICollection<Order> orderId { get; set; }

        //public virtual ICollection<Order> orders { get; set; }

        public virtual ICollection<Order> orders { get; set; }




    }
}
