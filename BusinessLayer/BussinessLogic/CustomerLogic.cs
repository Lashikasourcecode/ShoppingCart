using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.PropertyClass;
using DataAccessLayer.Interface;
using DataAccessLayer.Function;
using DataAccessLayer.Model;

using System.Linq;

namespace BusinessLayer.BussinessLogic
{
   public class CustomerLogic
    {

       private ICustomerDataAccess _customerdetails = new InsertCustomerData();

        //public DataAccessLayer dataAccess = new DataAccessLayer()

        public byte[] password;
        public async Task<bool> addCustomer(CustomerDetails customerDetails)
        {
            try {

                List<Customer> customer = new List<Customer>();

                Customer customeravailability = customer.Where(x => x.Email == customerDetails.Email).FirstOrDefault();

                if (customeravailability == null)
                {
                    byte[] passToHash;
                    string encryptedPassword = "";

                    passToHash = System.Text.Encoding.UTF8.GetBytes(customerDetails.Password);// string password convert to byte array
                    encryptedPassword = Shared.shared.Hash(passToHash);// call passwrod encryption menthod


                    Customer cus = new Customer
                    {
                        FirstName = customerDetails.firstName,
                        LastName = customerDetails.LastName,
                        Email = customerDetails.Email,
                        BilingAddress = customerDetails.BilingAddress,
                        Password = encryptedPassword,
                        // Password = System.Text.Encoding.UTF8.GetBytes(customerDetails.Password.ToString()),
                        DeliveryAddress = customerDetails.DeliveryAddress,
                        DeleveryCity = customerDetails.DeliveryCity,
                        MobileNo =customerDetails.MobileNo,



                    };

                    var result = await _customerdetails.InsertCustomerRecord(cus);

                    if (result != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
                    
                




            } catch (Exception ex)
            {
                return false;

            }
           // InsertCustomerData insertCustomer = new InsertCustomerData();

           //List<Customer> customerde = new List<Customer>();

           // Customer cu = new Customer
            //{
              // // cu.FirstName = customerDetails.firstName,
               //// cu.LastName 

           //// };

            /// customerde = await insertCustomer.InsertCustomerRecord(customerDetails);

            //return customerde;
            //List<Product> products = await _productlist.GetAllProducts();
           // return products;
        }

    }
}
