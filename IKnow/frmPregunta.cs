using IKnow.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKnow
{
    public partial class frmPregunta : Form
    {
        public string pregunta;
        public string respuesta;
        public string opcion2;
        public string opcion3;
        public int valor;
        private int duration = 31;
        

        frmPrincipal form;

      

        public frmPregunta(string pregunta, string respuesta, string opcion_2, string opcion_3, int valor, frmPrincipal form)
        {
            InitializeComponent();
            this.pregunta = pregunta;
            this.respuesta = respuesta;
            this.opcion2 = opcion_2;
            this.opcion3 = opcion_3;
            this.valor = valor;
            this.form = form;
        }

        private void btnVerRespuesta_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
        }

        private void frmPregunta_Load(object sender, EventArgs e)
        {

            
            
            lblPregunta.Text = this.pregunta;
            btnRespuesta.Text = this.respuesta;
            btnOpcion2.Text = this.opcion2;
            btnOpcion3.Text = this.opcion3;
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
            form.contadorGanador += 1;
            if (form.contadorGanador == 25)
            {
                form.Ganar();
            }

            int cont = Convert.ToInt32(this.form.btnTurno.Text);
            //int equi = Convert.ToInt32(CacheEquipos.id);
            //if (cont <= equi && cont > 0)
            //{
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

            //}

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
            form.contadorGanador += 1;
            if (form.contadorGanador == 25)
            {
                form.Ganar();
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblRespuesta_Click(object sender, EventArgs e)
        {

        }

        private void btnRespuesta_Click(object sender, EventArgs e)
        {
            btnVerRespuesta.Visible = true;
            lblRespuesta.ForeColor = Color.Green;
            lblRespuesta.Text = "CORRECTA";
            
            form.contadorGanador += 1;
            if (form.contadorGanador == 25)
            {
                form.Ganar();
            }

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

            timer1.Stop();
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            btnVerRespuesta.Visible = true;
            lblRespuesta.Text = "INCORRECTA";
            lblRespuesta.ForeColor = Color.Red;
            
            form.contadorGanador += 1;
            if (form.contadorGanador == 25)
            {
                form.Ganar();
            }
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
            timer1.Stop();
        }

        private void btnOpcion3_Click(object sender, EventArgs e)
        {
            btnVerRespuesta.Visible = true;
            lblRespuesta.Text = "INCORRECTA";
            lblRespuesta.ForeColor = Color.Red;

            form.contadorGanador += 1;
            if (form.contadorGanador == 25)
            {
                form.Ganar();
            }
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
            timer1.Stop();
        }
    }
}
