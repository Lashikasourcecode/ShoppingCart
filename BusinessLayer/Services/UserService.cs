using BusinessLayer.BussinessLogic;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.PropertyClass;
using BusinessLayer.Interface;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class UserService : IUserService
    {
        private UserLoginLogic pbl = new UserLoginLogic();

        public async Task<AuthenticationResponse> userLogin(AuthenticationRequest model)
        {
            AuthenticationResponse status = pbl.Authenticate(model);

            return  status;
        }
    }
}
