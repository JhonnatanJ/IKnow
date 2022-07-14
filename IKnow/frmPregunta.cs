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
    public partial class frmPregunta : Form
    {
        public string pregunta;
        public string respuesta;
        public int valor;
        private int duration = 31;


        frmPrincipal form;

        public frmPregunta(string pregunta, string respuesta, int valor, frmPrincipal form)
        {
            InitializeComponent();
            this.pregunta = pregunta;
            this.respuesta = respuesta;
            this.valor = valor;
            this.form = form;
        }

        private void btnVerRespuesta_Click(object sender, EventArgs e)
        {
            lblRespuesta.Visible = true;
            timer1.Stop();
        }

        private void frmPregunta_Load(object sender, EventArgs e)
        {
            
            lblPregunta.Text = this.pregunta;
            lblRespuesta.Text = this.respuesta;
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void count_down(object sender, EventArgs e)
        {

            if (duration == 0)
            {
                timer1.Stop();
                lblRespuesta.Visible = true;
                btnCorrecta.Enabled = false;
            }
            else if (duration > 0)
            {
                duration--;
                lblTimer.Text = duration.ToString();
            }
        }


        private void lblPregunta_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            int cont = Convert.ToInt32(this.form.btnTurno.Text);
            if (this.form.btnTurno.Text == "1")
            {
                int suma = Convert.ToInt32(this.form.lblScoreG1.Text);
                suma += valor;
                this.form.lblScoreG1.Text = suma.ToString();

            }
            if (this.form.btnTurno.Text == "2")
            {
                int suma = Convert.ToInt32(this.form.lblScoreG2.Text);
                suma += valor;
                this.form.lblScoreG2.Text = suma.ToString();

            }
            if (this.form.btnTurno.Text == "3")
            {
                int suma = Convert.ToInt32(this.form.lblScoreG3.Text);
                suma += valor;
                this.form.lblScoreG3.Text = suma.ToString();

            }
            if (this.form.btnTurno.Text == "4")
            {
                int suma = Convert.ToInt32(this.form.lblScoreG4.Text);
                suma += valor;
                this.form.lblScoreG4.Text = suma.ToString();

            }
            if (this.form.btnTurno.Text == "5")
            {
                int suma = Convert.ToInt32(this.form.lblScoreG5.Text);
                suma += valor;
                this.form.lblScoreG5.Text = suma.ToString();

            }



            if (cont < 5)
                cont++;
            else
                cont = 1;

            this.form.btnTurno.Text = cont.ToString();


            this.Close();
        }

        private void frmPregunta_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont = Convert.ToInt32(this.form.btnTurno.Text);
            if (this.form.btnTurno.Text == "1")
            {
                int suma = Convert.ToInt32(this.form.lblScoreG1.Text);
                suma -= valor;
                this.form.lblScoreG1.Text = suma.ToString();

            }
            if (this.form.btnTurno.Text == "2")
            {
                int suma = Convert.ToInt32(this.form.lblScoreG2.Text);
                suma -= valor;
                this.form.lblScoreG2.Text = suma.ToString();

            }
            if (this.form.btnTurno.Text == "3")
            {
                int suma = Convert.ToInt32(this.form.lblScoreG3.Text);
                suma -= valor;
                this.form.lblScoreG3.Text = suma.ToString();

            }
            if (this.form.btnTurno.Text == "4")
            {
                int suma = Convert.ToInt32(this.form.lblScoreG4.Text);
                suma -= valor;
                this.form.lblScoreG4.Text = suma.ToString();

            }
            if (this.form.btnTurno.Text == "5")
            {
                int suma = Convert.ToInt32(this.form.lblScoreG5.Text);
                suma -= valor;
                this.form.lblScoreG5.Text = suma.ToString();

            }



            if (cont < 5)
                cont++;
            else
                cont = 1;

            this.form.btnTurno.Text = cont.ToString();


            this.Close();
        }
    }
}
