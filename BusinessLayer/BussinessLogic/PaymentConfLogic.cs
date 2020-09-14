using BusinessLayer.PropertyClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Model;
using DataAccessLayer.DBContext;
using System.Linq;
using BusinessLayer.PropertyClass;
using System.Net.Mail;
//using MimeKit;
//using MailKit.Net.Smtp;
using System.Data;
using System.IO;
using System.Xml;
using System.Net.Mail;

namespace BusinessLayer.BussinessLogic
{
    public class PaymentConfLogic
    {

        PaymentConformation payconf = new PaymentConformation();

        int ProductId;
        string ProductName;
        double UnitPrice;
        double Quantity;


        public bool PaymentConf(PaymentConformation payments)
        {
            //int orderID = 0;
            
            payconf = payments;
           
            try
            {
                if (payments != null) {

                    using (var context = new ShoppingCartDBContext(ShoppingCartDBContext.optionBuild.dbOption))
                    {
                        //// foreach (var pay in payments) {
                        var order = new Order();
                        {
                            order.DateTime = payments.datetime;
                            order.Total = payments.total;
                            order.customers = context.Customers.First(c => c.CustomerId == payments.customerId);
                            // order.Payments = context.Payments.First(p =>p.PayamentId == payments.P);
                            ////payment
                            context.Orders.Add(order);
                            context.SaveChanges();

                        }

                        CartItemModel cartItem = new CartItemModel();

                        int orderID = order.OrderId;

                        var cutomerName = context.Customers.First(c => c.CustomerId == payments.customerId);

                        foreach (var ordersdetail in payments.cartItemModel)
                        {
                            OrderDetail orderDetail = new OrderDetail();
                            {
                                orderDetail.UnitPrice = ordersdetail.unitPrice;
                                orderDetail.Quantity = ordersdetail.quantity;
                                orderDetail.discount = ordersdetail.discount;
                                //
                                // orderDetail.product = context.products.First(o => o.ProductId == cartItem.productId );
                                orderDetail.product = context.products.First(o => o.ProductId == ordersdetail.productId);
                                orderDetail.orders = context.Orders.First(o => o.OrderId == orderID);

                                context.OrderDetails.Add(orderDetail);
                                context.SaveChanges();

                            };

                            int orderItemId = orderDetail.OrderDtailId;

                            // ProductDetails productDetails = new ProductDetails();
                            // {

                            // }

                        }
                        //endforeach


                        // foreach (var paymt in payments)
                        // {
                        Payment payment = new Payment();
                        {
                            payment.Amount = payments.total;
                            payment.PaymentMethod = payments.paymentMethod;
                            payment.order = context.Orders.FirstOrDefault(x => x.OrderId == orderID);
                            context.Payments.Add(payment);
                            context.SaveChanges();
                        }
                        // }
                    }






                    // MailMessage msg = new MailMessage();
                    // message.From = new MailAddress(Session["Email"].Tostring());
                    // message.To.Add(ConfigurationSettings.AppSettings["RequesEmail"].ToString());
                    // msg.Subject = "Shopping Cart Oder Details ";
                    // msg.IsBodyHtml = true;

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.Subject = "Shopping Cart Order  ";
                    mail.From = new MailAddress("dlashika86@gmail.com");
                    mail.To.Add("dlashika86@gmail.com");
                    mail.Subject = "Shopping Cart";

                    foreach (var pay in payments.cartItemModel)
                    {
                         ProductId = pay.productId;
                         ProductName = pay.productName;
                         UnitPrice = pay.unitPrice;
                         Quantity = pay.quantity;
                         

                    }


                    string textBody = "" +
                     "<h4>Customer Name</h4><span>" + payments.customerId + "</span><span><h4>Address</h4>"+ payments.deliveryAddress+"</span></br>" +
                     "<span><h4>Date</h4>" + payments.datetime + "</span></br>" +
                     "<span><h4>Payment Method</h4>" + payments.paymentMethod + "</span></br>" +
                     "<span><h4>Payment Amount</h4>" + payments.total + "</span></br>" +
                     "<table border=" + 1 + " cellpadding=" + 0 + " cellspacing=" + 0 + " width = " + 400 + "><tr bgcolor='#4da6ff'><th><b>Product Id</b></th> <th> <b> Product Name </b> </th> <th> <b> Quantity </b> </th> <th> <b> UnitPrice </b> </th></tr>";// +

                    foreach (var pay in payments.cartItemModel)
                    {
                        textBody += "<tr>" +
                            "<td>" +pay.productId + "</td>" +
                            "<td>" +pay.productName + "</td>" +
                            "<td>" +pay.unitPrice + "</td>" +
                            "<td>" + pay.quantity + "</td>" +
                            "</tr> ";
                    }  
                        textBody += "</table> <br/><h3>Thank You</h3>";

                    
                        //MailMessage mail = new MailMessage();
                        //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        //mail.Subject = "Shopping Cart Order  ";
                        //mail.From = new MailAddress("dlashika86@gmail.com");
                        //mail.To.Add("dlashika86@gmail.com");
                        //mail.Subject = "Shopping Cart";
                        mail.Body = textBody;

                        mail.IsBodyHtml = true;
                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("dlashika86@gmail.com", "lash1234");
                        SmtpServer.EnableSsl = true;
                        SmtpServer.Send(mail);
                     
               }




                      

                   
                   

                    
                        


                        return true;        

             }
                
                
            catch (Exception ex)
            {
              
            }



            return true;

                





                



            }

            
             

        
    }

   

}
