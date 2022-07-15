
namespace IKnow
{
    partial class frmGanador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbYouWin = new System.Windows.Forms.PictureBox();
            this.pbIconoGanador = new System.Windows.Forms.PictureBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.pbPuntaje = new System.Windows.Forms.PictureBox();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.pbNombreEquipo = new System.Windows.Forms.PictureBox();
            this.txbxNombreEquipo = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYouWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoGanador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuntaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackground
            // 
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Image = global::IKnow.Properties.Resources.pbBorde3;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(830, 694);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // pbYouWin
            // 
            this.pbYouWin.Image = global::IKnow.Properties.Resources.pbxGanador2;
            this.pbYouWin.Location = new System.Drawing.Point(116, 69);
            this.pbYouWin.Name = "pbYouWin";
            this.pbYouWin.Size = new System.Drawing.Size(594, 92);
            this.pbYouWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbYouWin.TabIndex = 1;
            this.pbYouWin.TabStop = false;
            // 
            // pbIconoGanador
            // 
            this.pbIconoGanador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIconoGanador.Location = new System.Drawing.Point(140, 186);
            this.pbIconoGanador.Name = "pbIconoGanador";
            this.pbIconoGanador.Size = new System.Drawing.Size(131, 94);
            this.pbIconoGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconoGanador.TabIndex = 2;
            this.pbIconoGanador.TabStop = false;
            this.pbIconoGanador.Click += new System.EventHandler(this.pbIconoGanador_Click);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEquipo.ForeColor = System.Drawing.Color.Violet;
            this.lblEquipo.Location = new System.Drawing.Point(131, 299);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(144, 40);
            this.lblEquipo.TabIndex = 15;
            this.lblEquipo.Text = "EQUIPO";
            this.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPuntaje
            // 
            this.pbPuntaje.Image = global::IKnow.Properties.Resources.pbxPuntaje;
            this.pbPuntaje.Location = new System.Drawing.Point(383, 202);
            this.pbPuntaje.Name = "pbPuntaje";
            this.pbPuntaje.Size = new System.Drawing.Size(339, 62);
            this.pbPuntaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPuntaje.TabIndex = 16;
            this.pbPuntaje.TabStop = false;
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuntaje.ForeColor = System.Drawing.Color.Violet;
            this.lblPuntaje.Location = new System.Drawing.Point(383, 284);
            this.lblPuntaje.MaximumSize = new System.Drawing.Size(339, 400);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(339, 38);
            this.lblPuntaje.TabIndex = 17;
            this.lblPuntaje.Text = "PUNTAJE";
            this.lblPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbNombreEquipo
            // 
            this.pbNombreEquipo.Image = global::IKnow.Properties.Resources.pbNombreEquipo;
            this.pbNombreEquipo.Location = new System.Drawing.Point(209, 384);
            this.pbNombreEquipo.Name = "pbNombreEquipo";
            this.pbNombreEquipo.Size = new System.Drawing.Size(412, 92);
            this.pbNombreEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNombreEquipo.TabIndex = 18;
            this.pbNombreEquipo.TabStop = false;
            // 
            // txbxNombreEquipo
            // 
            this.txbxNombreEquipo.BackColor = System.Drawing.Color.Black;
            this.txbxNombreEquipo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbxNombreEquipo.ForeColor = System.Drawing.Color.White;
            this.txbxNombreEquipo.Location = new System.Drawing.Point(209, 500);
            this.txbxNombreEquipo.Name = "txbxNombreEquipo";
            this.txbxNombreEquipo.Size = new System.Drawing.Size(412, 44);
            this.txbxNombreEquipo.TabIndex = 19;
            this.txbxNombreEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackgroundImage = global::IKnow.Properties.Resources.btnFinalizar;
            this.btnTerminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerminar.Location = new System.Drawing.Point(188, 572);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(454, 78);
            this.btnTerminar.TabIndex = 20;
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // frmGanador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(830, 694);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.txbxNombreEquipo);
            this.Controls.Add(this.pbNombreEquipo);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.pbPuntaje);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.pbIconoGanador);
            this.Controls.Add(this.pbYouWin);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGanador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGanador";
            this.Load += new System.EventHandler(this.frmGanador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYouWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoGanador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuntaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombreEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbYouWin;
        private System.Windows.Forms.PictureBox pbIconoGanador;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.PictureBox pbPuntaje;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.PictureBox pbNombreEquipo;
        private System.Windows.Forms.TextBox txbxNombreEquipo;
        private System.Windows.Forms.Button btnTerminar;
    }
}