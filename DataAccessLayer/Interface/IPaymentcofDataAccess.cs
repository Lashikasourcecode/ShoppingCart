using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccessLayer.Interface
{
    public interface IPaymentcofDataAccess
    {
        public string SaveDetails();
        List<Product> saveproductdetails(List<Product> productdetails);

        List<Customer> saveCustomerDetails(List<Customer> customerdetails);

        List<Order> saveOrder(List<Order> orderDetails);

        List<OrderDetail> saveorderDetails(List<OrderDetail> orderdetailsDetail);

        List<Payment> savePaymentDetails(List<Payment> paymentDetails);
    }
}
