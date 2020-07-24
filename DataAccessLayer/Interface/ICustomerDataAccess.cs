using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Model;

namespace DataAccessLayer.Interface
{
   public interface ICustomerDataAccess
    {
        Task<int> InsertCustomerRecord(Customer customer);
        
    }
}
