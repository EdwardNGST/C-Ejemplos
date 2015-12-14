using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            conectar conn = new conectar();
            label.Text = conn.obtenerDato();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void A(object sender, EventArgs e)
        {

        }

        private void btnActualizar1_Click(object sender, EventArgs e)
        {
            conectar conn = new conectar();
            
            if (txtDato.Text!="")
            {
                MessageBox.Show("Se actualizo el dato");
                conn.actualizarDato(txtDato.Text);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el dato");
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            conectar conn = new conectar();
            label.Text= conn.obtenerDato();
        }
    }
}