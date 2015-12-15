using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace DevolverNumero
{
    class cambiar
    {
        public String generarDato() {
            MySqlDataReader reader;
            MySqlCommand comand;
            MySqlConnection conectar;
            String resultado = "";

            conectar = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=pruebas; password=driftking125");
            conectar.Open();

            comand = new MySqlCommand(string.Format("UPDATE pruebas.cambiardato SET Resultado = 'Dato1' WHERE id_resultado=1;"),conectar);

            reader = comand.ExecuteReader();

            while (reader.Read())
            {
                resultado = ;
            }
            conectar.Close();
            return resultado;
        }
    }
}