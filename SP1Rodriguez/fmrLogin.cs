using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1Rodriguez
{
    public partial class fmrLogin : Form
    {
        int errores = 0;
        public fmrLogin()
           
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void cmbAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text; 
            string contraseña = txtContraseña.Text; 
            string Modulo = ltsModulo.Text;
            fmrBienvenida fmrBienvenida = new fmrBienvenida();
            switch (usuario)
            {
                case "Adm":
                    if (contraseña == "@1a" & (Modulo == "ADM" || Modulo == "COM" || Modulo == "VIA"))
                    {
                        errores = 0;
                        this.Hide();
                        fmrBienvenida.Show();
                    }
                    else
                    {
                        MessageBox.Show("contraseña y modulo incorrecto", "error",MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        
                    }
                    break;
                case "Ceci":
                    if (contraseña == "*@3c" & (Modulo == "ADM" || Modulo == "VTA"))
                    {
                        errores = 0;
                        this.Hide();
                        fmrBienvenida.Show();
                    }
                    else
                    {
                        MessageBox.Show("contraseña y modulo incorrecto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);errores = 0;
                        
                        
                    }
                    break;
                case "John":
                    if (contraseña == "*2b" & (Modulo == "SIST"))
                    {
                        errores = 0;
                        this.Hide();
                        fmrBienvenida.Show();
                    }
                    else
                    {
                        MessageBox.Show("contraseña y modulo incorrecto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    break;
                    case "God":
                    if (contraseña == "*@#4d" & (Modulo == "SIST" ||  Modulo == "ADM" || Modulo == "COM" || Modulo == "VIA"))
                    {
                        errores = 0;
                        this.Hide();
                        fmrBienvenida.Show();
                    }
                    else
                    {
                        MessageBox.Show("contraseña y modulo incorrecto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    break;
                    
                    
                    






            }
            
            
               
            
            


























        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

