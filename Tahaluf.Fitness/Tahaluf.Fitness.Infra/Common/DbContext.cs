using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Tahaluf.Fitness.Core.Common;

namespace Tahaluf.Fitness.Infra.Common
{
    public class DbContext:IDbContext
    {
        private DbConnection connection;
        private readonly IConfiguration configuration;

        public DbContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public DbConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(configuration["ConnectionStrings:DBConnectionString"]);
                    connection.Open();
                }
                else if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
            }
        }
    }
}
