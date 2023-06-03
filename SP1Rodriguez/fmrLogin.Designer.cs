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
            this.IblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.IblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.IblModulo = new System.Windows.Forms.Label();
            this.cmbAceptar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.ltsModulo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // IblUsuario
            // 
            this.IblUsuario.AutoSize = true;
            this.IblUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblUsuario.Location = new System.Drawing.Point(16, 31);
            this.IblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IblUsuario.Name = "IblUsuario";
            this.IblUsuario.Size = new System.Drawing.Size(51, 16);
            this.IblUsuario.TabIndex = 0;
            this.IblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.Color.Blue;
            this.txtUsuario.Location = new System.Drawing.Point(94, 29);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(116, 21);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IblContraseña
            // 
            this.IblContraseña.AutoSize = true;
            this.IblContraseña.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblContraseña.Location = new System.Drawing.Point(13, 81);
            this.IblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IblContraseña.Name = "IblContraseña";
            this.IblContraseña.Size = new System.Drawing.Size(73, 16);
            this.IblContraseña.TabIndex = 2;
            this.IblContraseña.Text = "Contraseña";
            this.IblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(94, 79);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '#';
            this.txtContraseña.Size = new System.Drawing.Size(116, 21);
            this.txtContraseña.TabIndex = 3;
            // 
            // IblModulo
            // 
            this.IblModulo.AutoSize = true;
            this.IblModulo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblModulo.Location = new System.Drawing.Point(16, 127);
            this.IblModulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IblModulo.Name = "IblModulo";
            this.IblModulo.Size = new System.Drawing.Size(49, 16);
            this.IblModulo.TabIndex = 4;
            this.IblModulo.Text = "Modulo";
            // 
            // cmbAceptar
            // 
            this.cmbAceptar.Location = new System.Drawing.Point(243, 26);
            this.cmbAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAceptar.Name = "cmbAceptar";
            this.cmbAceptar.Size = new System.Drawing.Size(88, 28);
            this.cmbAceptar.TabIndex = 5;
            this.cmbAceptar.Text = "Aceptar";
            this.cmbAceptar.UseVisualStyleBackColor = true;
            this.cmbAceptar.Click += new System.EventHandler(this.cmbAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(243, 76);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4);
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
            this.ltsModulo.Location = new System.Drawing.Point(92, 125);
            this.ltsModulo.Margin = new System.Windows.Forms.Padding(4);
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
            this.Controls.Add(this.IblModulo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.IblContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.IblUsuario);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmrLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.fmrLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label IblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label IblModulo;
        private System.Windows.Forms.Button cmbAceptar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.ComboBox ltsModulo;
    }
}