using IKnow.Cache;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace IKnow
{
    class Materia
    {
        public DataTable CargarCombo()
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();
            DataTable dt = new DataTable();

            comando.Connection = conexionBD;
            comando.CommandText = "select id, nombre from materia";
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            da.Fill(dt);
            conexionBD.Close();
            return dt;
        }

        public void CargarDatosMateria(string nombreMateria)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conexionBD;
            comando.CommandText = "select * from materia where nombre=@nombre";
            comando.Parameters.AddWithValue("@nombre", nombreMateria);
            comando.CommandType = System.Data.CommandType.Text;
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CacheMateria.id = reader.GetInt32(0);
                    CacheMateria.nombre = reader.GetString(1);
                }
            }
            conexionBD.Close();
        }
        //public void AgregarMateria(string id, string nombre)
        //{
        //    MySqlConnection conexionBD = Conexion.conexion();
        //    conexionBD.Open();
        //    MySqlCommand comando = new MySqlCommand();


        //    comando.Connection = conexionBD;
        //    comando.CommandText = "insert into materia(id, nombre) " +
        //        "VALUES (@id, @nombre)";

        //    comando.Parameters.AddWithValue("@id", id);
        //    comando.Parameters.AddWithValue("@nombre", nombre);

        //    comando.CommandType = System.Data.CommandType.Text;
        //    comando.ExecuteNonQuery();
        //    conexionBD.Close();
        //}
    }
}
