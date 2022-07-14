using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace IKnow
{
    class Conexion
    {
        public static string server = "localhost";
        public static string user = "root";
        public static string pwd = "root";
        public static string database = "iknow";
    
        public static MySqlConnection conexion()
        {
            string cadenaConexion = "server=" + server + ";user=" + user + ";pwd=" + pwd + ";database=" + database + ";SslMode=none;";
            try
            {
                MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                return myCon;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
