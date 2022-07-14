using IKnow.Cache;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKnow
{
    class Pregunta
    {
        public void CargarDatosPregunta(int idTema, int indice)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            int i = 0;
            comando.Connection = conexionBD;
            comando.CommandText = "select * from pregunta where idtema=@idtema";
            comando.Parameters.AddWithValue("@idtema", CacheTema.id[indice]);

            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (i < 5) {
                        CachePregunta.id[i] = reader.GetInt32(0);
                        CachePregunta.descripcion[i] = reader.GetString(1);
                        CachePregunta.idtema[i] = reader.GetInt32(2);
                        CachePregunta.respuesta[i] = reader.GetString(3);
                        i++;
                    }
                }
            }
            conexionBD.Close();
        }
    }
}
