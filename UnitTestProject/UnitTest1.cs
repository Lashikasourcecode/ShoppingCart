using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart.Controllers;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShoppingCart.Controllers;
using BusinessLayer.PropertyClass;
using BusinessLayer.Interface;
using DataAccessLayer.Model;
using BusinessLayer.Services;
using System;
using Moq;
using System.Web.Http;
using System.Web.Http.Results;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

         private readonly IUserService iuserService;

        private readonly ICheckoutService icheckoutService;

        public UnitTest1()
        {
           // iuserService = new IUserService();
           // iuserController = new UserController(iuserService);
        }

        private List<ProductDetails> GetTestProducts()
        {
            var testProducts = new List<ProductDetails>();
            testProducts.Add(new ProductDetails { ProductId = 1002, ProductName = "mug", Quantity = 10, image = "../../../assets/mugBea.jpg", UnitPrice = 300, Description = "mug" });
            testProducts.Add(new ProductDetails { ProductId = 1, ProductName = "vase", Quantity = 20, image = "../../../assets/mug.jpg", UnitPrice = 250, Description = "birthday mug" });
            testProducts.Add(new ProductDetails { ProductId = 3, ProductName = "vase", Quantity = 30, image = "../../../assets/vas.jpg", UnitPrice = 600, Description = "flower vase" });

           return testProducts;
        }

       
        private AuthenticationRequest Login()
        {
            var login = new AuthenticationRequest();

            login.Username = "dil@gmail.com";
            login.Password = "d1234";

            return login;
        }






        [TestMethod]
        public void TestMethod1()
        {
        }

       



        //Unit test for get Products
        [TestMethod]
        public async void GetAllProducts_ShouldReturnAllProducts()
        {
            var testProducts = GetTestProducts();
            var controller = new ProductController();

            var result = await controller.GetProducts() as List<ProductDetails>;
            Assert.AreEqual(testProducts.Count, result.Count);
           // Assert.AreEqual(testProducts, result);

            //var testProducts = GetTestProducts();
            //var controller = new ProductController();

            //var result = await controller.GetProducts() as List<ProductDetails>;
            //Assert.AreEqual(testProducts.Count, result.Count);
        }

        //[TestMethod]
        //public void GetReturnsProduct()
        //{
        //     private readonly ICheckoutService icheckoutService;
        //// Arrange
        //     var controller = new CheckoutController(CartItemDetails);
        //    controller.Request = new HttpRequestMessage();
        //    controller.Configuration = new HttpConfiguration();

        //    // Act
        //    var response = controller.(10);

        //    // Assert
        //    CartItemDetails cartproduct;
        //    Assert.Istrue(response.TryGetContentValue<Product>(out product));
        //    Assert.AreEqual(10, product.Id);
        //}



  //Unit test for Insert Customer Details
    [TestMethod]
    public async void PostMethodInserCustomer()
    {
       
            // Arrange
            var mockRepository = new Mock<ICustomerService>();

            var controller = new CustomerController(mockRepository.Object);

        // Act
       // IHttpActionResult actionResult = controller.AddCustomerDetails(new CustomerDetails { Password = "", firstName = "Product1", LastName = "", BilingAddress = "", DeliveryAddress = "", DeliveryCity = "", MobileNo = "", Email = "" });

              bool status = await controller.AddCustomerDetails(new CustomerDetails { Password = "qazwsx",
                firstName = "Lashika", LastName = "Dilanthi", BilingAddress = "kurunegala", DeliveryAddress = "Kurunegala",
                DeliveryCity = "Kurunegala", MobileNo = "0779886520", Email ="dilanthilashika@yahoo.com"});

            // var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<CustomerDetails>;
                    
            //Assert
            Assert.AreEqual(true,status);

       
    }

        //unit testing to get userdetails by customerId

        [TestMethod]
        public void GetReturnsCustomerWithSameId()
        {

            int customerId = 0;
            List<CustomerDetails> customerDetails = new List<CustomerDetails>();

            var mockRepository = new Mock<IUserDetails>();
            var controller = new UserDetailsController(mockRepository.Object);

            // Act
            // IHttpActionResult actionResult = controller.getuserdetails(10);

            customerDetails = controller.getuserdetails(1);

            foreach (var cdetails in customerDetails)
            {
                customerId = cdetails.CustomerId;
            }

            // Assert
            Assert.AreEqual(customerId, 1);
        }

        //not found customerId
        [TestMethod]
        public void GetReturnsNotFoundCustomerId()
        {
            // Arrange
            List<CustomerDetails> customerDetails = new List<CustomerDetails>();

            var mockRepository = new Mock<IUserDetails>();
            var controller = new UserDetailsController(mockRepository.Object);

            // Act
           // IHttpActionResult actionResult = controller.getuserdetails(10);

            customerDetails = controller.getuserdetails(12);

            // Assert
            Assert.AreEqual(customerDetails, null);
        }

        [TestMethod]
        public  void TestUserLoggin()
        {

            var mockRepository = new Mock<IUserDetails>();
            var controller = new UserDetailsController(mockRepository.Object);
            AuthenticationRequest request = new AuthenticationRequest()
            {
                Password = "d1234",
                Username = "dil@gmail.com",

            };


            UserController userController = new UserController(iuserService);


            var status = userController.UserAuthenticate(request);

           // IHttpActionResult result = userController.UserAuthenticate(request);


          // Assert.AreEqual();
               

        }


        //Test Invalid User
        [TestMethod]
        public void TestInvalidUserLoggin()
        {
            AuthenticationRequest request = new AuthenticationRequest()
            {
                Password = "d12345",
                Username = "dil@gmail.com",

            };


            UserController userController = new UserController(iuserService);


            var status = userController.UserAuthenticate(request);

            Assert.AreEqual(status,null);
     


        }

        //unit test for checkout
        [TestMethod]

        public void TestCheckout()
        {

            var mockRepository = new Mock<ICheckoutService>();
            var controller = new CheckoutController(mockRepository.Object);

            var testproduct = GetTestProducts();
            var testProducts = new List<CartItemDetails>();
            List<CartItemDetails> cartItems = new List<CartItemDetails>();
            cartItems.Add(new CartItemDetails { ProductId = 1, ProductName = "vase", Quantity = 5, UnitPrice = 300, Description = "mug" });



            // var controller = new CheckoutController(icheckoutService);
           

            var checkvalidity = controller.checkquantity(cartItems);


     

            
        
        }










    }
}

