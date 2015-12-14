using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace formMySQL
{
    class conexion
    {
        public String obtenerMaestros(ComboBox cb)
        {
            String Materia="";
            MySqlConnection conectar = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=horario; password=driftking125");
            conectar.Open();

            comand = new SqlCommand(string.Format("select Nombre from Empleados where Nombre like '' or Id_Trabajador='{0}';", Id), conect);
        }
    }
}