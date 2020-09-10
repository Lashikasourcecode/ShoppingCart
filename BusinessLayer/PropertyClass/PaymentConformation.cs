using BusinessLayer.PropertyClass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PropertyClass
{
    public class PaymentConformation
    {
        public int customerId { get; set; }
        public double total { get; set; }
        public DateTime datetime { get; set; }
        public string paymentMethod { get; set; }

        public string customerName { get; set; }

        public string deliveryAddress { get; set; }

        public List<CartItemModel> cartItemModel { get; set; }







        //CartItemModel cartItemlist = new CartItemModel();


        //[JsonProperty("CartItemModel")]
        //public List<CartItemModel> cartItemList { get; set; }

        //public CartItemModel[] cartItemlist;

       // public CartItemModel[] cart;
  

        //private List<CartItemResponse> cartItems;
        //public List<CartItemResponse> cartItemlist { get => cartItems; set => cartItems = value; }


        // public int CustomerId { get => customerId; set => customerId = value; }
        //product details
        

        // public List<CartItemResponse> cartItemList { get; set; } = new List<CartItemResponse>();


    }
}









    
        
    
   
    

