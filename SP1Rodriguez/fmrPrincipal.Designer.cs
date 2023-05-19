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
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdSigIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(76, 12);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(234, 75);
            this.cmdLogin.TabIndex = 0;
            this.cmdLogin.Text = "Log In";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdSigIn
            // 
            this.cmdSigIn.Location = new System.Drawing.Point(76, 93);
            this.cmdSigIn.Name = "cmdSigIn";
            this.cmdSigIn.Size = new System.Drawing.Size(234, 71);
            this.cmdSigIn.TabIndex = 1;
            this.cmdSigIn.Text = "Sig In";
            this.cmdSigIn.UseVisualStyleBackColor = true;
            this.cmdSigIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 198);
            this.Controls.Add(this.cmdSigIn);
            this.Controls.Add(this.cmdLogin);
            this.Name = "fmrPrincipal";
            this.Text = "ingreso";
            this.Load += new System.EventHandler(this.fmrPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Button cmdSigIn;
    }
}