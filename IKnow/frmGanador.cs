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
    public partial class frmGanador : Form
    {
        int ganador;
        int grupo;
        public frmGanador(int ganador, int grupo)
        {
            this.ganador = ganador;
            this.grupo = grupo;
            InitializeComponent();
        }

        private void pbIconoGanador_Click(object sender, EventArgs e)
        {
            
        }

        private void frmGanador_Load(object sender, EventArgs e)
        {
            if (this.grupo == 0)
            {
                pbIconoGanador.BackgroundImage = Image.FromFile(Application.StartupPath + "/../../../Resources/icon_grupo1.png");
            }
            if (this.grupo == 1)
            {
                pbIconoGanador.BackgroundImage = Image.FromFile(Application.StartupPath + "/../../../Resources/icon_grupo2.png");
            }
            if (this.grupo == 2)
            {
                pbIconoGanador.BackgroundImage = Image.FromFile(Application.StartupPath + "/../../../Resources/icon_grupo3.png");
            }
            if (this.grupo == 3)
            {
                pbIconoGanador.BackgroundImage = Image.FromFile(Application.StartupPath + "/../../../Resources/icon_grupo4.png");
            }
            if (this.grupo == 4)
            {
                pbIconoGanador.BackgroundImage = Image.FromFile(Application.StartupPath + "/../../../Resources/icon_grupo5.png");
            }


            if (this.grupo == 0)
            {
                lblEquipo.ForeColor = Color.Violet;
                lblEquipo.Text = "EQUIPO 1";
            }
            if (this.grupo == 1)
            {
                lblEquipo.ForeColor = Color.FromArgb(255, 255, 192, 128);
                lblEquipo.Text = "EQUIPO 2";            }
            if (this.grupo == 2)
            {
                lblEquipo.ForeColor = Color.FromArgb(255, 255, 128, 128);
                lblEquipo.Text = "EQUIPO 3";
            }
            if (this.grupo == 3)
            {
                lblEquipo.ForeColor = Color.FromArgb(255, 128, 255, 128);
                lblEquipo.Text = "EQUIPO 4";
            }
            if (this.grupo == 4)
            {
                lblEquipo.ForeColor = Color.FromArgb(255, 128, 255, 255);
                lblEquipo.Text = "EQUIPO 5";
            }

            if (this.grupo == 0)
            {
                lblPuntaje.ForeColor = Color.Violet;
                lblPuntaje.Text = this.ganador.ToString();
            }
            if (this.grupo == 1)
            {
                lblPuntaje.ForeColor = Color.FromArgb(255, 255, 192, 128);
                lblPuntaje.Text = this.ganador.ToString();
            }
            if (this.grupo == 2)
            {
                lblPuntaje.ForeColor = Color.FromArgb(255, 255, 128, 128);
                lblPuntaje.Text = this.ganador.ToString();
            }
            if (this.grupo == 3)
            {
                lblPuntaje.ForeColor = Color.FromArgb(255, 128, 255, 128);
                lblPuntaje.Text = this.ganador.ToString();
            }
            if (this.grupo == 4)
            {
                lblPuntaje.ForeColor = Color.FromArgb(255, 128, 255, 255);
                lblPuntaje.Text = this.ganador.ToString();
            }

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
