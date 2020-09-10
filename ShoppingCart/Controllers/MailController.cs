using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.PropertyClass;
using BusinessLayer.Interface;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailServicea mailService;

        public MailController(IMailServicea mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost("email2")]
        public async Task<IActionResult> SendWelcomeMail([FromForm] Paymenthistory request)
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
