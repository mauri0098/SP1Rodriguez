namespace SP1Rodriguez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblSintepartSRL = new System.Windows.Forms.Label();
            this.cmdIniciarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSintepartSRL
            // 
            this.lblSintepartSRL.AutoSize = true;
            this.lblSintepartSRL.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintepartSRL.Location = new System.Drawing.Point(7, 9);
            this.lblSintepartSRL.Name = "lblSintepartSRL";
            this.lblSintepartSRL.Size = new System.Drawing.Size(383, 78);
            this.lblSintepartSRL.TabIndex = 3;
            this.lblSintepartSRL.Text = "Sintepart SRL";
            // 
            // cmdIniciarSesion
            // 
            this.cmdIniciarSesion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciarSesion.Location = new System.Drawing.Point(114, 254);
            this.cmdIniciarSesion.Name = "cmdIniciarSesion";
            this.cmdIniciarSesion.Size = new System.Drawing.Size(153, 39);
            this.cmdIniciarSesion.TabIndex = 7;
            this.cmdIniciarSesion.Text = "Iniciar Sesion";
            this.cmdIniciarSesion.UseVisualStyleBackColor = true;
            this.cmdIniciarSesion.Click += new System.EventHandler(this.cmdIniciarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SP1Rodriguez.Properties.Resources._4GSUPRZXXREO7A3YKFIT3W2RMM;
            this.pictureBox1.Location = new System.Drawing.Point(12, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 321);
            this.Controls.Add(this.cmdIniciarSesion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSintepartSRL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSintepartSRL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdIniciarSesion;
    }
}