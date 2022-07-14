﻿namespace IKnow
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnCorrecta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.btnVerRespuesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoEllipsis = true;
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(203, 29);
            this.lblPregunta.MaximumSize = new System.Drawing.Size(600, 96);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(138, 32);
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
            this.btnCorrecta.Location = new System.Drawing.Point(49, 354);
            this.btnCorrecta.Name = "btnCorrecta";
            this.btnCorrecta.Size = new System.Drawing.Size(222, 53);
            this.btnCorrecta.TabIndex = 19;
            this.btnCorrecta.Text = "CORRECTA";
            this.btnCorrecta.UseVisualStyleBackColor = false;
            this.btnCorrecta.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(600, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "INCORRECTA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoEllipsis = true;
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRespuesta.ForeColor = System.Drawing.Color.White;
            this.lblRespuesta.Location = new System.Drawing.Point(203, 234);
            this.lblRespuesta.MaximumSize = new System.Drawing.Size(600, 96);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(114, 25);
            this.lblRespuesta.TabIndex = 21;
            this.lblRespuesta.Text = "Respuesta";
            this.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRespuesta.Visible = false;
            // 
            // btnVerRespuesta
            // 
            this.btnVerRespuesta.BackColor = System.Drawing.Color.Black;
            this.btnVerRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerRespuesta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVerRespuesta.Location = new System.Drawing.Point(363, 340);
            this.btnVerRespuesta.Name = "btnVerRespuesta";
            this.btnVerRespuesta.Size = new System.Drawing.Size(172, 67);
            this.btnVerRespuesta.TabIndex = 22;
            this.btnVerRespuesta.Text = "VER RESPUESTA";
            this.btnVerRespuesta.UseVisualStyleBackColor = false;
            this.btnVerRespuesta.Click += new System.EventHandler(this.btnVerRespuesta_Click);
            // 
            // frmPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btnVerRespuesta);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCorrecta);
            this.Controls.Add(this.lblPregunta);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPregunta_FormClosed);
            this.Load += new System.EventHandler(this.frmPregunta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnCorrecta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Button btnVerRespuesta;
    }
}