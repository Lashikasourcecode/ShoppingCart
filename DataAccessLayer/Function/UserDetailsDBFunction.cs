using DataAccessLayer.DBContext;
using DataAccessLayer.Interface;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.Function
{
    public class UserDetailsDBFunction : IUserDetailsDataAccess
    {
       public List<Customer> getuserdetails(int userid)
        {

            // IEnumerable<Customer> customer;
            List<Customer> customers = new List<Customer>();

            using (var context = new ShoppingCartDBContext(ShoppingCartDBContext.optionBuild.dbOption))
            {
               customers = context.Customers.ToList();
                               
            }
            return customers;



        }
    }
}
