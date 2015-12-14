using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reloj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblHora.Visible = true;
            lblMinuto.Visible = true;
            lblSegundo.Visible = true;
        }

        int h = 0;
        int m = 0;
        int s = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHora.Visible = true;
            lblMinuto.Visible = true;
            lblSegundo.Visible = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            reloj.Start();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            reloj.Stop();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            reloj.Stop();
            s = 0;
            m = 0;
            h = 0;
            lblHora.Text = "        ";
            lblMinuto.Text = "    ";
            lblSegundo.Text = "    ";
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            lblSegundo.Text = System.Convert.ToString(s = s + 1);

            if(s == 59){
                s = 0;
                lblMinuto.Text = System.Convert.ToString(m = m + 1);
            }

            if (m == 59){
                m = 0;
                lblHora.Text = System.Convert.ToString(h = h + 1);
            }

        }
        
    }
}