using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace IngresarCuenta
{
    class conexion
    {
        public int iniciarSesion(String user, String pass) {
            MySqlDataReader reader;
            MySqlCommand comand;
            MySqlConnection conectar;
            int resultado = -1;

            conectar = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=pruebas; password=driftking125");
            conectar.Open();
            comand = new MySqlCommand(string.Format("SELECT * FROM pruebas.iniciarsesion where Nombre='{0}' and Contraseña ='{1}';",user,pass),conectar);

            reader = comand.ExecuteReader();

            while (reader.Read()) {
                resultado = 50;
            }
            conectar.Close();
            return resultado;
        }
    }
}