using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using BusinessLayer.BussinessLogic;
using BusinessLayer.PropertyClass;
using ShoppingCart.Controllers;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
       

        private readonly IMailServicea mailService;

        public EmailController(IMailServicea mailService)
        {
            this.mailService = mailService;
        }


        
        [Route("email")]
        [HttpPost]
        public async Task<IActionResult> SendWelcomeMail(Paymenthistory request)
        {
            try
            {
                await mailService.SendWelcomeEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
