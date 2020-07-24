using BusinessLayer.BussinessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interface;
using System.Threading.Tasks;
using BusinessLayer.PropertyClass;

namespace BusinessLayer.Services
{
    public class CustomerService:ICustomerService
    {
        private CustomerLogic customerLogic = new CustomerLogic();

        public async Task<bool> addCustomer(CustomerDetails customerDetails)
        { 
          bool status = await customerLogic.addCustomer(customerDetails);

            return status;

        }
    }
}
