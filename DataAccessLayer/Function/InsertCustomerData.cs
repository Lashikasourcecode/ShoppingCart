using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interface;
using DataAccessLayer.DBContext;
using Microsoft.EntityFrameworkCore;


namespace DataAccessLayer.Function
{
    public class InsertCustomerData : ICustomerDataAccess
    {

       public async Task<int> InsertCustomerRecord(Customer customer)
        {

            using (var context = new ShoppingCartDBContext(ShoppingCartDBContext.optionBuild.dbOption))
            {
                await context.Customers.AddAsync(customer);
                await context.SaveChangesAsync();

            }

            return customer.CustomerId;
           

          

        }
       

           



        }
        
}
