
namespace IKnow
{
    partial class frmPrincipal
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPreguntas = new System.Windows.Forms.Panel();
            this.pnlGrupo1 = new System.Windows.Forms.Panel();
            this.pnlGrupo2 = new System.Windows.Forms.Panel();
            this.pnlGrupo3 = new System.Windows.Forms.Panel();
            this.pnlGrupo4 = new System.Windows.Forms.Panel();
            this.pnlGrupo5 = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPreguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1422, 76);
            this.pnlHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1422, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlPreguntas
            // 
            this.pnlPreguntas.Controls.Add(this.pnlGrupo5);
            this.pnlPreguntas.Controls.Add(this.pnlGrupo4);
            this.pnlPreguntas.Controls.Add(this.pnlGrupo3);
            this.pnlPreguntas.Controls.Add(this.pnlGrupo2);
            this.pnlPreguntas.Controls.Add(this.pnlGrupo1);
            this.pnlPreguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreguntas.Location = new System.Drawing.Point(0, 76);
            this.pnlPreguntas.Name = "pnlPreguntas";
            this.pnlPreguntas.Size = new System.Drawing.Size(1422, 681);
            this.pnlPreguntas.TabIndex = 2;
            // 
            // pnlGrupo1
            // 
            this.pnlGrupo1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGrupo1.Location = new System.Drawing.Point(0, 0);
            this.pnlGrupo1.Name = "pnlGrupo1";
            this.pnlGrupo1.Size = new System.Drawing.Size(284, 681);
            this.pnlGrupo1.TabIndex = 0;
            // 
            // pnlGrupo2
            // 
            this.pnlGrupo2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGrupo2.Location = new System.Drawing.Point(284, 0);
            this.pnlGrupo2.Name = "pnlGrupo2";
            this.pnlGrupo2.Size = new System.Drawing.Size(284, 681);
            this.pnlGrupo2.TabIndex = 1;
            // 
            // pnlGrupo3
            // 
            this.pnlGrupo3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGrupo3.Location = new System.Drawing.Point(568, 0);
            this.pnlGrupo3.Name = "pnlGrupo3";
            this.pnlGrupo3.Size = new System.Drawing.Size(284, 681);
            this.pnlGrupo3.TabIndex = 2;
            // 
            // pnlGrupo4
            // 
            this.pnlGrupo4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGrupo4.Location = new System.Drawing.Point(852, 0);
            this.pnlGrupo4.Name = "pnlGrupo4";
            this.pnlGrupo4.Size = new System.Drawing.Size(284, 681);
            this.pnlGrupo4.TabIndex = 3;
            // 
            // pnlGrupo5
            // 
            this.pnlGrupo5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGrupo5.Location = new System.Drawing.Point(1136, 0);
            this.pnlGrupo5.Name = "pnlGrupo5";
            this.pnlGrupo5.Size = new System.Drawing.Size(285, 681);
            this.pnlGrupo5.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1422, 757);
            this.Controls.Add(this.pnlPreguntas);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iKnow!!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPreguntas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPreguntas;
        private System.Windows.Forms.Panel pnlGrupo5;
        private System.Windows.Forms.Panel pnlGrupo4;
        private System.Windows.Forms.Panel pnlGrupo3;
        private System.Windows.Forms.Panel pnlGrupo2;
        private System.Windows.Forms.Panel pnlGrupo1;
    }
}