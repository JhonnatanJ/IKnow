using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKnow
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            frmOpciones opciones = new frmOpciones();
            opciones.Show();
        }

        public void Ocultar()
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            frmRanking rank = new frmRanking();
            rank.Show();
        }

        private void pbInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
