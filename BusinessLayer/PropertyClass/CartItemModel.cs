using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PropertyClass
{
    public class CartItemModel
    {

        
        public string availability { get; set; }
        public string description { get; set; }
               
        public double discount { get; set; }
        public string image { get; set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public int quantity { get; set; }
        public double unitPrice { get; set; } 






       // public List<CartItemModel> cart { set; get; }


       //public string Availability { get => availability; set => availability = value; }
       // public string Description { get => description; set => description = value; }
       // public double Discount { get => discount; set => discount = value; }
       // public string Image { get => image; set => image = value; }
       // public int ProductId { get => productId; set => productId = value; }
       // public string ProductName { get => productName; set => productName = value; }
       // public int Quantity { get => quantity; set => quantity = value; }
       // public double UnitPrice { get => unitPrice; set => unitPrice = value; }
       // public List<PaymentConformation> paymentslist { get; set; } = new List<PaymentConformation>();

       // public PaymentConformation paymentConformation { get; set; }

    }
}
