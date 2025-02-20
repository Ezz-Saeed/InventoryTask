using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTask
{
    public class Settings
    {
        private readonly SqlConnection connection;
        private readonly IConfiguration configuration;

        public Settings()
        {
            configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            connection = new SqlConnection(configuration.GetSection("connection").Value);
        }

        public SqlConnection GetConnection => connection;
    }
}
