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


        }

    }
}


