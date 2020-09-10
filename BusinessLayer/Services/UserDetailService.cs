using BusinessLayer.BussinessLogic;
using BusinessLayer.Interface;
using BusinessLayer.PropertyClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
   public class UserDetailService :IUserDetails
    {
        private UserDetailsBL userDetailBL = new UserDetailsBL();

        public List<CustomerDetails> GetUserDetails(int customerid)
        {
            var userdetails = userDetailBL.GetUserDetails(customerid);

            return userdetails;
        }
    }
}
