using Microsoft.Extensions.Configuration;
using System.IO;

namespace ConnectToDB.DataAcces
{
    public static class AppSettings
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
            get { return configuration.GetConnectionString("ADONETConnectionString"); }
        }
    }
}
