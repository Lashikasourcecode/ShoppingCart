using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace DataAccessLayer.DBContext
{
    public class AppConfigurations
    {

        public AppConfigurations()
        {
           // string path = "C:/Users/Lashika/source/repos/Online Shopping Cart\Online Shopping Cart\appsetting.json";
            var configBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(),"appsettings.json");
           // configBuilder.SetBasePath(Directory.GetCurrentDirectory());
            configBuilder.AddJsonFile(path, false);
            configBuilder.AddJsonFile("appsettings.json");
            var root = configBuilder.Build();
            var appsetting = root.GetSection("ConnectionString:DefaultConnection");
            SQLConnection = appsetting.Value;


        }

        public string SQLConnection { get; set; }
    }

}
