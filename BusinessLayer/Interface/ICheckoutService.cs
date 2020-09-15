using BusinessLayer.PropertyClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface ICheckoutService
    {
       
        public  List<CartItemDetails> checkProductAvailabilty(List<CartItemDetails> productDetails);
    }
}
