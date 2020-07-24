using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Model;


namespace BusinessLayer.PropertyClass
{
    public class AuthenticationResponse
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string JWToken { get; set; }

        public AuthenticationResponse(Customer customer, string token)
        {
            CustomerId = customer.CustomerId;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Email = customer.Email;
            JWToken = token;

        }
    }
}
