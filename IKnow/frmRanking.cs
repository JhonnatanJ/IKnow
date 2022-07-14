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
    public partial class frmRanking : Form
    {
        public frmRanking()
        {
            InitializeComponent();
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            Puntuaciones pun = new Puntuaciones();
            pun.CargarDatosRanking();

            lblRank1.Text = CacheRanking.nombre[0];
            lblRank2.Text = CacheRanking.nombre[1];
            lblRank3.Text = CacheRanking.nombre[2];
            lblRank4.Text = CacheRanking.nombre[3];
            lblRank5.Text = CacheRanking.nombre[4];

            lblRankP1.Text = CacheRanking.puntaje[0].ToString();
            lblRankP2.Text = CacheRanking.puntaje[1].ToString();
            lblRankP3.Text = CacheRanking.puntaje[2].ToString();
            lblRankP4.Text = CacheRanking.puntaje[3].ToString();
            lblRankP5.Text = CacheRanking.puntaje[4].ToString();

        }
    }
}
