using BusinessLayer.PropertyClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
   public interface IPaymentConfService
    {
        public bool payConformation(PaymentConformation paymentConformation);
       
    }
}
