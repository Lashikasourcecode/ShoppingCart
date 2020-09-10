using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using BusinessLayer.PropertyClass;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService iuserService;

        public UserController(IUserService userService)
        {
            iuserService = userService;
        }

        [Route("login")]
        [HttpPost]

        //user login and send authentication request

        public async Task<IActionResult> UserAuthenticate(AuthenticationRequest request)
        {
            var response = await iuserService.userLogin(request);

            if (response == null)
                return BadRequest(new{message="username or password is incorrect" });

            return Ok(response);

        }

       


    }
}
