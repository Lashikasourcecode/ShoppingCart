using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.PropertyClass;
using BusinessLayer.BussinessLogic;
using BusinessLayer;
using BusinessLayer.Interface;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService icustomerService;

        public CustomerController(ICustomerService customerService)
        {
            icustomerService = customerService;
        }

        [Route("addCustomer")]
        [HttpPost]
        public async Task<bool>  AddCustomerDetails(CustomerDetails customer)
        {

            bool status = await icustomerService.addCustomer(customer);

            return status;

            

        }

    }
}
