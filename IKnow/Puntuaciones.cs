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

        public DataTable CargarDGV(string nombre)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select * from puntacion where nombre=@nombre";
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }
    }
}
