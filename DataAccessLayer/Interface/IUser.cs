using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Interface
{
    public interface IUser
    {
        //Task<int> CheckUser(Customer customer);
        // Task<List<Customer>> CheckUser(Customer customer);
        IEnumerable<Customer> GetAll();
        

        // Task<AuthenticationResponse> userLogin(AuthenticationRequest model)
    }
}
