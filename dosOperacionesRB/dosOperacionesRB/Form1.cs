using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dosOperacionesRB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RadioBoton1.Checked == true)
            {
                int valor1 = int.Parse(textBox1.Text);
                int valor2 = int.Parse(textBox2.Text);
                int suma = valor1 + valor2;
                label3.Text = suma.ToString();
            }
            if (RadioBoton2.Checked == true)
            {
                int valor1 = int.Parse(textBox1.Text);
                int valor2 = int.Parse(textBox2.Text);
                int resta = valor1 - valor2;
                label3.Text = resta.ToString();
            }
        }
    }
}
