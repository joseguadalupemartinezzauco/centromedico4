using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace bibliotecaCBD
{
    public class conexion
    {

        public SqlConnection getConnection() {
            try
            {
                string cadena = @"Data Source=mybdjose.database.windows.net;Initial Catalog=centromedico;User ID=josegpe;Password=********;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection con = new SqlConnection(cadena);
                con.Open();
                return con;
            }
            catch (Exception) {
               return null;
            }

        }




    }
}
