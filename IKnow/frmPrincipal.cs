using IKnow.Cache;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public int contador = 1;
        public int contadorGanador = 0;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (Cache.CacheMateria.nombre.ToLower().Equals("matemáticas"))
            {
                pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath+"/../../../Imagenes/Materias/imgMatematicas.png");
            }
            if (Cache.CacheMateria.nombre.ToLower().Equals("ciencias naturales"))
            {
                pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "/../../../Imagenes/Materias/imgCienciasN.png");
            }
            if (Cache.CacheMateria.nombre.ToLower().Equals("gamificación"))
            {
                pictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "/../../../Imagenes/Materias/imgGamificacion.png");
            }

            Tema tema = new Tema();
            tema.CargarDatosTema(CacheMateria.id);

            lblTema1.Text = CacheTema.nombre[0];
            lblTema2.Text = CacheTema.nombre[1];
            lblTema3.Text = CacheTema.nombre[2];
            lblTema4.Text = CacheTema.nombre[3];
            lblTema5.Text = CacheTema.nombre[4];

            btnTurno.Text = contador.ToString();

        }

        public void Ganar()
        {
            int[] aux = new int[5];
            int ganar,indice=0;
            aux[0] = int.Parse(this.lblScoreG1.Text);
            aux[1] = int.Parse(this.lblScoreG2.Text);
            aux[2] = int.Parse(this.lblScoreG3.Text);
            aux[3] = int.Parse(this.lblScoreG4.Text);
            aux[4] = int.Parse(this.lblScoreG5.Text);

            ganar = aux.Max();

            for(int i=0; i<5; i++)
            {
                if (aux[i] == ganar)
                {
                    indice = i;
                }
            }

            frmGanador ganador = new frmGanador(ganar, indice);
            ganador.Show();
            this.Enabled = false;
        }

        private void btnT1500_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[0];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 0);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[0], CachePregunta.respuesta[0], 500, this);
            btnT1500.Text = "";
            btnT1500.Enabled = false;
            form.Show();
        }

        private void btnT1400_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[0];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 0);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[1], CachePregunta.respuesta[1], 400, this);
            btnT1400.Text = "";
            btnT1400.Enabled = false;
            form.Show();
        }

        private void btnT1300_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[0];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 0);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[2], CachePregunta.respuesta[2], 300, this);
            btnT1300.Text = "";
            btnT1300.Enabled = false;
            form.Show();
        }

        private void btnT1200_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[0];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 0);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[3], CachePregunta.respuesta[3], 200, this);
            btnT1200.Text = "";
            btnT1200.Enabled = false;
            form.Show();
        }

        private void btnT1100_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[0];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 0);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[4], CachePregunta.respuesta[4], 100, this);
            btnT1100.Text = "";
            btnT1100.Enabled = false;
            form.Show();
        }

        private void btnT2500_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[1];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 1);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[0], CachePregunta.respuesta[0], 500, this);
            btnT2500.Text = "";
            btnT2500.Enabled = false;
            form.Show();
        }

        private void btnT2400_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[1];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 1);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[1], CachePregunta.respuesta[1], 400, this);
            btnT2400.Text = "";
            btnT2400.Enabled = false;
            form.Show();
        }

        private void btnT2300_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[1];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 1);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[2], CachePregunta.respuesta[2], 300, this);
            btnT2300.Text = "";
            btnT2300.Enabled = false;
            form.Show();
        }

        private void btnT2200_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[1];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 1);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[3], CachePregunta.respuesta[3], 200, this);
            btnT2200.Text = "";
            btnT2200.Enabled = false;
            form.Show();
        }

        private void btnT2100_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[1];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 1);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[4], CachePregunta.respuesta[4], 100, this);
            btnT2100.Text = "";
            btnT2100.Enabled = false;
            form.Show();
        }

        private void btnT3500_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[2];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 2);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[0], CachePregunta.respuesta[0], 500, this);
            btnT3500.Text = "";
            btnT3500.Enabled = false;
            form.Show();
        }

        private void btnT3400_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[2];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 2);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[1], CachePregunta.respuesta[1], 400, this);
            btnT3400.Text = "";
            btnT3400.Enabled = false;
            form.Show();
        }

        private void btnT3300_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[2];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 2);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[2], CachePregunta.respuesta[2], 300, this);
            btnT3300.Text = "";
            btnT3300.Enabled = false;
            form.Show();
        }

        private void btnT3200_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[2];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 2);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[3], CachePregunta.respuesta[3], 200, this);
            btnT3200.Text = "";
            btnT3200.Enabled = false;
            form.Show();
        }

        private void btnT3100_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[2];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 2);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[4], CachePregunta.respuesta[4], 100, this);
            btnT3100.Text = "";
            btnT3100.Enabled = false;
            form.Show();
        }

        private void btnT4500_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[3];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 3);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[0], CachePregunta.respuesta[0], 500, this);
            btnT4500.Text = "";
            btnT4500.Enabled = false;
            form.Show();
        }

        private void btnT4400_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[3];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 3);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[1], CachePregunta.respuesta[1], 400, this);
            btnT4400.Text = "";
            btnT4400.Enabled = false;
            form.Show();
        }

        private void btnT4300_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[3];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 3);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[2], CachePregunta.respuesta[2], 300, this);
            btnT4300.Text = "";
            btnT4300.Enabled = false;
            form.Show();
        }

        private void btnT4200_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[3];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 3);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[3], CachePregunta.respuesta[3], 200, this);
            btnT4200.Text = "";
            btnT4200.Enabled = false;
            form.Show();
        }

        private void btnT4100_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[3];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 3);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[4], CachePregunta.respuesta[4], 100, this);
            btnT4100.Text = "";
            btnT4100.Enabled = false;
            form.Show();
        }

        private void btnT5500_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[4];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 4);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[0], CachePregunta.respuesta[0], 500, this);
            btnT5500.Text = "";
            btnT5500.Enabled = false;
            form.Show();
        }

        private void btnT5400_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[4];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 4);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[1], CachePregunta.respuesta[1], 400, this);
            btnT5400.Text = "";
            btnT5400.Enabled = false;
            form.Show();
        }

        private void btnT5300_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[4];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 4);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[2], CachePregunta.respuesta[2], 300, this);
            btnT5300.Text = "";
            btnT5300.Enabled = false;
            form.Show();
        }

        private void btnT5200_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[4];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 4);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[3], CachePregunta.respuesta[3], 200, this);
            btnT5200.Text = "";
            btnT5200.Enabled = false;
            form.Show();
        }

        private void btnT5100_Click(object sender, EventArgs e)
        {
            int cache = CacheTema.id[4];
            Pregunta p = new Pregunta();
            p.CargarDatosPregunta(cache, 4);

            frmPregunta form = new frmPregunta(CachePregunta.descripcion[4], CachePregunta.respuesta[4], 100, this);
            btnT5100.Text = "";
            btnT5100.Enabled = false;
            form.Show();
        }

        private void pbVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


