namespace IKnow
{
    partial class frmPregunta
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
            this.components = new System.ComponentModel.Container();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnCorrecta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnVerRespuesta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnRespuesta = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoEllipsis = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(142, 0);
            this.lblPregunta.MaximumSize = new System.Drawing.Size(650, 175);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(650, 175);
            this.lblPregunta.TabIndex = 18;
            this.lblPregunta.Text = "Pregunta";
            this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPregunta.Click += new System.EventHandler(this.lblPregunta_Click);
            // 
            // btnCorrecta
            // 
            this.btnCorrecta.BackColor = System.Drawing.Color.Black;
            this.btnCorrecta.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCorrecta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCorrecta.Location = new System.Drawing.Point(0, 397);
            this.btnCorrecta.Name = "btnCorrecta";
            this.btnCorrecta.Size = new System.Drawing.Size(222, 53);
            this.btnCorrecta.TabIndex = 19;
            this.btnCorrecta.Text = "CORRECTA";
            this.btnCorrecta.UseVisualStyleBackColor = false;
            this.btnCorrecta.Visible = false;
            this.btnCorrecta.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(640, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "INCORRECTA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoEllipsis = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRespuesta.ForeColor = System.Drawing.Color.Lime;
            this.lblRespuesta.Location = new System.Drawing.Point(605, 243);
            this.lblRespuesta.MaximumSize = new System.Drawing.Size(600, 100);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(283, 38);
            this.lblRespuesta.TabIndex = 21;
            this.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRespuesta.Click += new System.EventHandler(this.lblRespuesta_Click);
            // 
            // btnVerRespuesta
            // 
            this.btnVerRespuesta.BackColor = System.Drawing.Color.Black;
            this.btnVerRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerRespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerRespuesta.Location = new System.Drawing.Point(388, 397);
            this.btnVerRespuesta.Name = "btnVerRespuesta";
            this.btnVerRespuesta.Size = new System.Drawing.Size(120, 41);
            this.btnVerRespuesta.TabIndex = 22;
            this.btnVerRespuesta.Text = "SALIR";
            this.btnVerRespuesta.UseVisualStyleBackColor = false;
            this.btnVerRespuesta.Visible = false;
            this.btnVerRespuesta.Click += new System.EventHandler(this.btnVerRespuesta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 450);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTimer.Location = new System.Drawing.Point(807, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(81, 51);
            this.lblTimer.TabIndex = 24;
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // btnRespuesta
            // 
            this.btnRespuesta.BackColor = System.Drawing.Color.Black;
            this.btnRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRespuesta.ForeColor = System.Drawing.Color.White;
            this.btnRespuesta.Location = new System.Drawing.Point(35, 177);
            this.btnRespuesta.Name = "btnRespuesta";
            this.btnRespuesta.Size = new System.Drawing.Size(537, 53);
            this.btnRespuesta.TabIndex = 25;
            this.btnRespuesta.Text = ".";
            this.btnRespuesta.UseVisualStyleBackColor = false;
            this.btnRespuesta.Click += new System.EventHandler(this.btnRespuesta_Click);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.BackColor = System.Drawing.Color.Black;
            this.btnOpcion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpcion2.ForeColor = System.Drawing.Color.White;
            this.btnOpcion2.Location = new System.Drawing.Point(35, 236);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(537, 53);
            this.btnOpcion2.TabIndex = 26;
            this.btnOpcion2.Text = ".";
            this.btnOpcion2.UseVisualStyleBackColor = false;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // btnOpcion3
            // 
            this.btnOpcion3.BackColor = System.Drawing.Color.Black;
            this.btnOpcion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpcion3.ForeColor = System.Drawing.Color.White;
            this.btnOpcion3.Location = new System.Drawing.Point(35, 295);
            this.btnOpcion3.Name = "btnOpcion3";
            this.btnOpcion3.Size = new System.Drawing.Size(537, 53);
            this.btnOpcion3.TabIndex = 27;
            this.btnOpcion3.Text = ".";
            this.btnOpcion3.UseVisualStyleBackColor = false;
            this.btnOpcion3.Click += new System.EventHandler(this.btnOpcion3_Click);
            // 
            // frmPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btnOpcion3);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.btnRespuesta);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnVerRespuesta);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCorrecta);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPregunta_FormClosed);
            this.Load += new System.EventHandler(this.frmPregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnCorrecta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVerRespuesta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnRespuesta;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion3;
        public System.Windows.Forms.Label lblRespuesta;
    }
}