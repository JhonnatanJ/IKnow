using IKnow.Cache;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKnow
{
    class Puntuaciones
    {
        public void InsertarPuntuacion(string nombre, double puntaje)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "insert into puntuacion(nombre, puntaje) " +
                "VALUES (@nombre, @puntaje)";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@puntaje", puntaje);
            comando.CommandType = System.Data.CommandType.Text;
            comando.ExecuteNonQuery();
            conexionBD.Close();
        }

        public void CargarDatosRanking()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            int i = 0;
            comando.Connection = conexionBD;
            comando.CommandText = "select * from puntuacion order by puntaje desc limit 5";

            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (i < 5)
                    {
                        CacheRanking.id[i] = reader.GetInt32(0);
                        CacheRanking.nombre[i] = reader.GetString(1);
                        CacheRanking.puntaje[i] = reader.GetInt32(2);
                        i++;
                    }
                }
            }
            conexionBD.Close();
        }
    }
}
