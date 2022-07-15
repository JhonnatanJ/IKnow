
namespace IKnow
{
    partial class frmOpciones
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
            this.cbEquipos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.btnAJugar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEquipos
            // 
            this.cbEquipos.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEquipos.ForeColor = System.Drawing.Color.White;
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbEquipos.Location = new System.Drawing.Point(174, 212);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.Size = new System.Drawing.Size(389, 37);
            this.cbEquipos.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IKnow.Properties.Resources.lblOpciones;
            this.pictureBox1.Location = new System.Drawing.Point(188, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IKnow.Properties.Resources.lblEquipos;
            this.pictureBox2.Location = new System.Drawing.Point(235, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IKnow.Properties.Resources.lblMateria;
            this.pictureBox3.Location = new System.Drawing.Point(235, 301);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(268, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // cbMateria
            // 
            this.cbMateria.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMateria.ForeColor = System.Drawing.Color.White;
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(174, 378);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(389, 37);
            this.cbMateria.TabIndex = 4;
            // 
            // btnAJugar
            // 
            this.btnAJugar.BackColor = System.Drawing.Color.Black;
            this.btnAJugar.BackgroundImage = global::IKnow.Properties.Resources.btnAjugar;
            this.btnAJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAJugar.Location = new System.Drawing.Point(188, 487);
            this.btnAJugar.Name = "btnAJugar";
            this.btnAJugar.Size = new System.Drawing.Size(361, 117);
            this.btnAJugar.TabIndex = 5;
            this.btnAJugar.UseVisualStyleBackColor = false;
            this.btnAJugar.Click += new System.EventHandler(this.btnAJugar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Image = global::IKnow.Properties.Resources.icon_cerrar;
            this.pictureBox4.Location = new System.Drawing.Point(678, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // frmOpciones
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(727, 643);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnAJugar);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbEquipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones de Quiz";
            this.Load += new System.EventHandler(this.frmOpciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEquipos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Button btnAJugar;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}