namespace SP1Rodriguez
{
    partial class fmrLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblModulo = new System.Windows.Forms.Label();
            this.cmbAceptar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.ltsModulo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(16, 31);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(49, 16);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.Color.Blue;
            this.txtUsuario.Location = new System.Drawing.Point(92, 28);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(116, 21);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(13, 81);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(68, 16);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(92, 78);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '#';
            this.txtContraseña.Size = new System.Drawing.Size(116, 21);
            this.txtContraseña.TabIndex = 3;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(16, 127);
            this.lblModulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(49, 16);
            this.lblModulo.TabIndex = 4;
            this.lblModulo.Text = "Modulo";
            // 
            // cmbAceptar
            // 
            this.cmbAceptar.Location = new System.Drawing.Point(253, 25);
            this.cmbAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAceptar.Name = "cmbAceptar";
            this.cmbAceptar.Size = new System.Drawing.Size(88, 28);
            this.cmbAceptar.TabIndex = 5;
            this.cmbAceptar.Text = "Aceptar";
            this.cmbAceptar.UseVisualStyleBackColor = true;
            this.cmbAceptar.Click += new System.EventHandler(this.cmbAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(253, 75);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(88, 28);
            this.cmdCancelar.TabIndex = 6;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // ltsModulo
            // 
            this.ltsModulo.FormattingEnabled = true;
            this.ltsModulo.Items.AddRange(new object[] {
            "ADM",
            "SIST",
            "COM",
            "VTA"});
            this.ltsModulo.Location = new System.Drawing.Point(92, 124);
            this.ltsModulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ltsModulo.Name = "ltsModulo";
            this.ltsModulo.Size = new System.Drawing.Size(116, 24);
            this.ltsModulo.TabIndex = 7;
            // 
            // fmrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 184);
            this.Controls.Add(this.ltsModulo);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmbAceptar);
            this.Controls.Add(this.lblModulo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmrLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Button cmbAceptar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ComboBox ltsModulo;
    }
}