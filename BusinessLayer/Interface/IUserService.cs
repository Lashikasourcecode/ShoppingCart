using BusinessLayer.PropertyClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IUserService
    {

        // public Task<bool> userlogin(AuthenticationRequest authentication);


        Task<AuthenticationResponse> userLogin(AuthenticationRequest model);
    }
}
