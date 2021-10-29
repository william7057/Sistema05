using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace CapaDatos
{
   public class Conexion
    {
        string cadena = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

       public SqlConnection conectar() {
            SqlConnection Ocon = new SqlConnection(cadena);
            return Ocon;
                }

    }
}
