﻿namespace SP1Rodriguez
{
    partial class fmrBienvenida
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
            this.lblBienvenvido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSintepartSRL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenvido
            // 
            this.lblBienvenvido.AutoSize = true;
            this.lblBienvenvido.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenvido.Location = new System.Drawing.Point(12, 9);
            this.lblBienvenvido.Name = "lblBienvenvido";
            this.lblBienvenvido.Size = new System.Drawing.Size(576, 108);
            this.lblBienvenvido.TabIndex = 3;
            this.lblBienvenvido.Text = "Bienvenvido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SP1Rodriguez.Properties.Resources._4GSUPRZXXREO7A3YKFIT3W2RMM;
            this.pictureBox1.Location = new System.Drawing.Point(30, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblSintepartSRL
            // 
            this.lblSintepartSRL.AutoSize = true;
            this.lblSintepartSRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintepartSRL.Location = new System.Drawing.Point(12, 327);
            this.lblSintepartSRL.Name = "lblSintepartSRL";
            this.lblSintepartSRL.Size = new System.Drawing.Size(653, 108);
            this.lblSintepartSRL.TabIndex = 5;
            this.lblSintepartSRL.Text = "Sintepart SRL";
            // 
            // fmrBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 444);
            this.Controls.Add(this.lblSintepartSRL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBienvenvido);
            this.Name = "fmrBienvenida";
            this.Text = "fmrBienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenvido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSintepartSRL;
    }
}