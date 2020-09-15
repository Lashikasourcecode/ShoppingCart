using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.PropertyClass;
using BusinessLayer.BussinessLogic;
using BusinessLayer.Interface;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentConformationController : ControllerBase
    {

        private readonly IPaymentConfService ipaymentService;

        //private readonly IEmailSender iemailSender;
       

        public PaymentConformationController(IPaymentConfService paymentService)
        {
            ipaymentService = paymentService;
           

        }

        [Route("payment")]
        [HttpPost]
        public async Task<bool> PaymentConf(PaymentConformation payments)
        {
            

            PaymentConfLogic paymentCofom = new PaymentConfLogic();

             bool status = paymentCofom.PaymentConf(payments);             

            return status;




        }

        



    }
}
