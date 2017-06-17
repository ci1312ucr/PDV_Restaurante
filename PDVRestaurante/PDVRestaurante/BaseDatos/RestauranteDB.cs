using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PDVRestaurante.Objetos;
using System.Security;

namespace PDVRestaurante.BaseDatos
{
    public class RestauranteDB
    {
        private string connectionString;

        public RestauranteDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["RestauranteConn"].ConnectionString;
        }

        
    }
}
