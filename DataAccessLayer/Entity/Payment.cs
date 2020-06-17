using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using DataAccessLayer;

namespace DataAccessLayer.Model
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public double Amount { get; set; }

        public string PaymentMethod { get; set; }

        [ForeignKey("Order")]
        public virtual Order order { get; set; }

    }
}
