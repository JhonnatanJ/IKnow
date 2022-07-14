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
        public void CargarDatosTema(int idmateria)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            int i = 0;
            comando.Connection = conexionBD;
            comando.CommandText = "select * from tema where idmateria=@idmateria";
            comando.Parameters.AddWithValue("@idmateria", CacheMateria.id);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader != null)
            {
                while (reader.Read())
                {
                    if(i < 5) {
                        CacheTema.id[i] = reader.GetInt32(0);
                        CacheTema.nombre[i] = reader.GetString(1);
                        CacheTema.idmateria[i] = reader.GetInt32(2);
                        i++;
                    }
                }
            }
            conexionBD.Close();
        }
    }
}
