using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;

namespace CapaDatos
{
    public class Conexion
    {
        private readonly string connection;
        private readonly IConfiguration _configuration;

        public Conexion(IConfiguration Configuration)
        {
            _configuration = Configuration;
            connection = _configuration.GetConnectionString("SqlConnection")!;
        }
        public SqlConnection get()
        {
            return new SqlConnection(connection);
        }


    }
}
