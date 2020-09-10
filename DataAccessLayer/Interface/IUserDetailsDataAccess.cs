using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Interface
{
   public interface IUserDetailsDataAccess
    {
       public List<Customer> getuserdetails(int userid);
    }
}
