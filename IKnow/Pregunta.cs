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
        public void CargarDatosPregunta(string descripcionPregunta)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "select * from pregunta where descripcion=@descipcion && idtema=@idtema";
            comando.Parameters.AddWithValue("@descripcion", descripcionPregunta);
            comando.Parameters.AddWithValue("@idtema", CacheTema.id);

            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CachePregunta.id = reader.GetInt32(0);
                    CachePregunta.descripcion = reader.GetString(1);
                    CachePregunta.idtema = reader.GetInt32(2);
                    CachePregunta.respuesta = reader.GetString(3);

                }
            }
            conexionBD.Close();
        }
    }
}
