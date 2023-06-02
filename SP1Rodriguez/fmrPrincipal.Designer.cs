namespace SP1Rodriguez
{
    partial class fmrPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPrincipal));
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdSigIn = new System.Windows.Forms.Button();
            this.lblSintepartSRL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(125, 276);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(165, 52);
            this.cmdLogin.TabIndex = 0;
            this.cmdLogin.Text = "Log In";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdSigIn
            // 
            this.cmdSigIn.Location = new System.Drawing.Point(125, 353);
            this.cmdSigIn.Name = "cmdSigIn";
            this.cmdSigIn.Size = new System.Drawing.Size(165, 51);
            this.cmdSigIn.TabIndex = 1;
            this.cmdSigIn.Text = "Sig In";
            this.cmdSigIn.UseVisualStyleBackColor = true;
            this.cmdSigIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSintepartSRL
            // 
            this.lblSintepartSRL.AutoSize = true;
            this.lblSintepartSRL.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintepartSRL.Location = new System.Drawing.Point(12, 9);
            this.lblSintepartSRL.Name = "lblSintepartSRL";
            this.lblSintepartSRL.Size = new System.Drawing.Size(472, 86);
            this.lblSintepartSRL.TabIndex = 2;
            this.lblSintepartSRL.Text = "Sintepart SRL";
            this.lblSintepartSRL.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SP1Rodriguez.Properties.Resources._4GSUPRZXXREO7A3YKFIT3W2RMM;
            this.pictureBox1.Location = new System.Drawing.Point(12, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSintepartSRL);
            this.Controls.Add(this.cmdSigIn);
            this.Controls.Add(this.cmdLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ingreso";
            this.Load += new System.EventHandler(this.fmrPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Button cmdSigIn;
        private System.Windows.Forms.Label lblSintepartSRL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}