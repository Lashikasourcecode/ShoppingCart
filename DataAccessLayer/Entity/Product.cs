using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        //
       
        public int ProductName { get; set; }
        public int Quantity { get; set; }
        public byte[] image { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public double Discount { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        [ForeignKey("Category")]
        public virtual Category categories { get; set; }


    }
}
