using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.BussinessLogic;
using BusinessLayer.Interface;
using BusinessLayer.PropertyClass;

namespace BusinessLayer.Services
{
    public class PaymetconformationService : IPaymentConfService
    {
        private PaymentConfLogic paycoformation = new PaymentConfLogic(); 
        public bool payConformation(PaymentConformation orderDetails)
        {
            bool status = paycoformation.PaymentConf(orderDetails);

            return status;

        }

    }
}
