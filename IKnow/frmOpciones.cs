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
    public partial class frmOpciones : Form
    {
        public frmOpciones()
        {
            InitializeComponent();
        }

        private void btnAJugar_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            frmPrincipal principal = new frmPrincipal();

            inicio.Visible=false;
            this.Close();

            principal.Show();
        }

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            Materia materia = new Materia();

        }
    }
}
