using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Connected.DataAcces
{
   public static  class AppSettings
    {
        private static IConfigurationRoot configuration;

        static AppSettings()
        {

            IConfigurationBuilder builder = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("connectionstring.json", optional: true, reloadOnChange: true);
            configuration = builder.Build();
        }

        public static string ConnectionString
        {
            get { return configuration.GetConnectionString("ADONETConnectedLayer"); }
        }
    }
}
