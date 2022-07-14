using IKnow.Cache;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKnow
{
    class Tema
    {
        public void CargarDatosTema(string nombreTema)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "select * from tema where nombre=@nombre && idmateria=@idmateria";
            comando.Parameters.AddWithValue("@nombre", nombreTema);
            comando.Parameters.AddWithValue("@idmateria", CacheMateria.id);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CacheTema.id = reader.GetInt32(0);
                    CacheTema.nombre = reader.GetString(1);
                    CacheTema.idmateria = reader.GetInt32(2);
                }
            }
            conexionBD.Close();
        }
    }
}
