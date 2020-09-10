using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.PropertyClass
{
    public class PaymetDetailsCollection
    {
        private PaymentConformation paymentConf { get; set; }

        public PaymentConformation PaymentConformation { get => paymentConf; set => paymentConf = value; }


        private List<CartItemModel> cartItems;
        public List<CartItemModel> cartItemlist { get => cartItems; set => cartItems = value; }
    }
}
