using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
namespace pruebaConexion
{
    public class conexion
    {
        

        public string ObtenerConexion() {
            String dato="";
            MySqlConnection conect;
            MySqlCommand comand;
            MySqlDataReader dr;
            conect = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=horario;Password=driftking125");
            conect.Open();
            comand = new MySqlCommand(string.Format("SELECT Materia FROM horario.semestre where Maestro='Pelao';"), conect);

            dr = comand.ExecuteReader();
            while (dr.Read())
            {
                dato = dr.GetString(0);
            }
            conect.Close();
            return dato;
        }
    }
}
