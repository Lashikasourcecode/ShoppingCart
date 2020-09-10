using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.PropertyClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Interface;
using BusinessLayer.BussinessLogic;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {

        private readonly IUserDetails iuserService;

        public UserDetailsController(IUserDetails userService)
        {
            iuserService = userService;
        }

        

        [Route("userdetails")]
        [HttpGet]
        //get user by Customer Id
        public List<CustomerDetails> getuserdetails(int customerid)
        {

            var userdetails =  iuserService.GetUserDetails(customerid);

            if (userdetails != null) {

                foreach (var users in userdetails)
                {
                    CustomerDetails customerDetails = new CustomerDetails()
                    {
                       CustomerId = users.CustomerId,
                       firstName = users.firstName,
                       LastName = users.LastName,
                       Email = users.Email,
                       BilingAddress=users.BilingAddress,
                       DeliveryAddress = users.DeliveryAddress,
                       DeliveryCity = users.DeliveryCity,
                       MobileNo = users.MobileNo,
                    };
                }
            }

            return userdetails;

              

        }
    }
}
