using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.Model
{
   public  class OrderDetail
    {
        [Key]
        public int OrderDtailId { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public double discount { get; set; }

        [ForeignKey("Order")]
        public virtual Order orders { get; set; }

       // public virtual ICollection<Product> products { get; set; }
       [ForeignKey("Product")]
        public virtual Product product { get; set; }

        

        


    }
}
