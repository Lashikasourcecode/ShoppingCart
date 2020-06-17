using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Model
{
   public  class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime DateTime { get; set; }

        public double Total { get; set; }

        public ICollection<Customer> customers { get; set; }

        public ICollection<OrderDetail> orderdetails { get; set; }

        [ForeignKey("Payment")]
        public virtual Payment Payments { get; set; }


    }
}
