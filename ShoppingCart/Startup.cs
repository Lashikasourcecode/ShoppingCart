using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Mvc.Formatters.Json;
using Microsoft.Extensions.Hosting;
using BusinessLayer.Interface;
using BusinessLayer.Services;
using System.Text;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using BusinessLayer.PropertyClass;
using BusinessLayer.PropertyClass.MailSetting;
using BusinessLayer.Services;
using NETCore.MailKit.Core;
using MailKit;

namespace ShoppingCart
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //code for send email
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));
           // services.AddTransient<IMailServicea,Service.MailService>();
           // BusinessLayer.Services.MailService;
           // services.AddScoped<IMailService,MailService>();
            services.AddControllers();
            // services.AddControllers();
            //
            services.AddControllers();
            services.AddCors();

            ////Email sender
            var emailConfig = Configuration
            .GetSection("EmailConfiguration")
            .Get<EmailCofiguration>();
            services.AddSingleton(emailConfig);
            services.AddControllers();

            ////Email Sender



            //services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICheckoutService, CheckOutService>();
            services.AddScoped<IUserDetails, UserDetailService>();
            //payment conformation
            services.AddScoped<IPaymentConfService, PaymetconformationService>();
            //send email
            services.AddScoped<IEmailSender, EmailSender>();
          


            var key = Encoding.ASCII.GetBytes("THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING");
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
           .AddJwtBearer(x =>
           {
               x.RequireHttpsMetadata = false;
               x.SaveToken = true;
               x.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuerSigningKey = true,
                   IssuerSigningKey = new SymmetricSecurityKey(key),
                   ValidateIssuer = false,
                   ValidateAudience = false
               };
           });

            services.AddScoped<ICustomerService, CustomerService>();
            // services.AddScoped<IUserServicecs, UserService>();

        }

        //services.AddMvc()
        //.SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
        //.AddJsonOptions(options => {
        //    //var resolver = options.SerializerSettings.ContractResolver;
        //    var resolver = options.SerialierSettings.ContractResolver;

        //    if (resolver != null)
        //        (resolver as DefaultContractResolver).NamingStratergy = null;
        //});






        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(option => option.WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader()
            );

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

