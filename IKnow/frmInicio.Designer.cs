
namespace IKnow
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbInicio = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRanking = new System.Windows.Forms.Button();
            this.pbIKnow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIKnow)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInicio
            // 
            this.pbInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbInicio.Image = global::IKnow.Properties.Resources.fondoInicio;
            this.pbInicio.Location = new System.Drawing.Point(0, 0);
            this.pbInicio.Name = "pbInicio";
            this.pbInicio.Size = new System.Drawing.Size(1167, 743);
            this.pbInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInicio.TabIndex = 1;
            this.pbInicio.TabStop = false;
            this.pbInicio.Click += new System.EventHandler(this.pbInicio_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Transparent;
            this.btnJugar.BackgroundImage = global::IKnow.Properties.Resources.btnJugar2;
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJugar.Location = new System.Drawing.Point(456, 478);
            this.btnJugar.Margin = new System.Windows.Forms.Padding(0);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnJugar.Size = new System.Drawing.Size(323, 106);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::IKnow.Properties.Resources.icon_cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(1118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.Black;
            this.btnRanking.BackgroundImage = global::IKnow.Properties.Resources.btnRanking;
            this.btnRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRanking.Location = new System.Drawing.Point(438, 633);
            this.btnRanking.Margin = new System.Windows.Forms.Padding(0);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRanking.Size = new System.Drawing.Size(353, 74);
            this.btnRanking.TabIndex = 4;
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // pbIKnow
            // 
            this.pbIKnow.BackColor = System.Drawing.Color.Black;
            this.pbIKnow.Image = global::IKnow.Properties.Resources.pbIKnow;
            this.pbIKnow.Location = new System.Drawing.Point(365, 24);
            this.pbIKnow.Name = "pbIKnow";
            this.pbIKnow.Size = new System.Drawing.Size(516, 82);
            this.pbIKnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIKnow.TabIndex = 5;
            this.pbIKnow.TabStop = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 743);
            this.Controls.Add(this.pbIKnow);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.pbInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iKNOW!!";
            ((System.ComponentModel.ISupportInitialize)(this.pbInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIKnow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInicio;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.PictureBox pbIKnow;
    }
}

