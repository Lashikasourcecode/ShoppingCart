
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using BusinessLayer.PropertyClass;
using DataAccessLayer.Model;
using DataAccessLayer.Interface;
using BusinessLayer.Shared;
using BusinessLayer.Helper;

using System.Security.Claims;

namespace BusinessLayer.BussinessLogic
{
    public class UserLoginLogic
    {
        public IUser iuser = new DataAccessLayer.Function.UserLoginDBFunction();

        private readonly AppSetting _appSettings;



        // private IUser user = new User //secret
        private const string Secret = "THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING";
        /// <summary>
        /// User Authenticate
        /// </summary>
        /// <param name="model">AuthenticateRequest type model</param>
        /// <returns>JWT Token and user details</returns>
        public AuthenticationResponse Authenticate(AuthenticationRequest model)
        {
           // IEnumerable<Customer> cus = user.GetAll();
            IEnumerable<Customer> cus = iuser.GetAll();
            byte[] passToHash = System.Text.Encoding.UTF8.GetBytes(model.Password);// call password encrpted method
            string encryptedPassword = Shared.shared.Hash(passToHash);// get encripted password 
            var userL = cus.SingleOrDefault(x => x.Email == model.Username && x.Password == encryptedPassword);
            // return null if user not found
            if (userL == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(userL);

            return new AuthenticationResponse(userL,token);
        }

        /// <summary>
        /// Creating a JWT Token
        /// </summary>
        /// <param name="user"></param>
        /// <returns> craeted JWT Token</returns>
       
        //Lashika
        private string generateJwtToken(Customer user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            
            
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.CustomerId.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

