using DataAccessLayer.DBContext;
using DataAccessLayer.Interface;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Function
{
    public class UserLoginDBFunction : IUser
    {

       
            public IEnumerable<Customer> GetAll()
            {
                List<Customer> customers = new List<Customer>();

                using (var context = new ShoppingCartDBContext(ShoppingCartDBContext.optionBuild.dbOption))
                {
                    customers = context.Customers.ToList();
                }
                return customers;
            }

           

            
        }
    }

