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
            //var listOfObjectsResult = Json.Decode<List<DataType>>(JsonData);
            //PaymentConformation payments

            PaymentConfLogic paymentCofom = new PaymentConfLogic();

             bool status = paymentCofom.PaymentConf(payments);

           

            if (status == false)
            {

                //try
                //{
                //    MailMessage mail = new MailMessage();
                //    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                //    mail.From = new MailAddress("dlashika86@gmail.com");
                //    mail.To.Add("dlashika86@gmail.com");
                //    mail.Subject = "Test Mail";
                //    mail.Body = "Your order is placed";

                //    SmtpServer.Port = 587;
                //    SmtpServer.Credentials = new System.Net.NetworkCredential("dlashika86@gmail.com", "lash1234");
                //    SmtpServer.EnableSsl = true;

                //    SmtpServer.Send(mail);
                //    //MessageBox.Show("mail Send");
                //}
                //catch (Exception ex)
                //{
                //    // MessageBox.Show(ex.ToString());
                //}

               




            }

            return status;







        }

        //[HttpGet]
        //// public async Task<IEnumerable<ProductDetails>> Get()
        //public async Task Get()
        //{
        //    IEnumerable<ProductDetails> productDetails;


        //    var message = new Message(new string[] { "dlashika86@gmail.com" }, "Test email async", "This is the content from our async email.", null);
        //    await iemailSender.SendEmailAsync(message);

        //    // return productDetails;




        //}



    }
}
