using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Interface
{
    public interface IUser
    {
        
        IEnumerable<Customer> GetAll();
        

       
    }
}
