using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Interface;
using DataAccessLayer.Function;
using BusinessLayer.PropertyClass;
using System.Linq;

namespace BusinessLayer.BussinessLogic
{
    public class UserDetailsBL
    {

        private IUserDetailsDataAccess userDetailsData = new UserDetailsDBFunction();

        List<CustomerDetails> customerDetailslist = new List<CustomerDetails>();

        public List<CustomerDetails> GetUserDetails(int customerid)
        {

            var usersdetais = userDetailsData.getuserdetails(customerid).ToList();

            foreach (var users in usersdetais)
            {
                if (users.CustomerId == customerid)
                {
                    customerDetailslist.Add(new CustomerDetails
                    {
                        CustomerId = users.CustomerId,
                        firstName = users.FirstName,
                        LastName = users.LastName,
                        Email = users.Email,
                        BilingAddress = users.BilingAddress,
                        DeliveryAddress = users.DeliveryAddress,
                        MobileNo = users.MobileNo,

                    });
                }

                else {

                }
                
                   
            }

           

            return customerDetailslist;

        }
    }
}
