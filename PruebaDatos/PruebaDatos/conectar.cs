using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PruebaDatos
{
    class conectar
    {
        MySqlDataReader Lector;
        MySqlCommand Comando;
        MySqlConnection Conector;

        public string obtenerDato() {
            String Dato="";

            Conector = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=pruebas; password=driftking125");
            Conector.Open();

            Comando = new MySqlCommand(string.Format("SELECT Resultado FROM pruebas.cambiardato WHERE id_resultado=1;"), Conector);

            Lector = Comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            Conector.Close();
            return Dato;
        }

        public int actualizarDato(string data) {

            int resultado = -1;
                Conector = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=pruebas; password=driftking125");
                Conector.Open();

                if (data != "NULL"){
                    Comando = new MySqlCommand(string.Format("UPDATE pruebas.cambiardato SET Resultado='{0}' WHERE id_resultado=1;", data), Conector);
                    resultado = 50;
                }

                Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    resultado = 50;
                }
                Conector.Close();

            return resultado;
        }
    }
}