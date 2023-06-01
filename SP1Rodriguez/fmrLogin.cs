using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1Rodriguez
{
    public partial class fmrLogin : Form
    {
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
            string contraseña =txtUsuario.Text; 
            string Modulo = ltsModulo.Text;

            switch (usuario)
            {
                case "Adm":
                    if (contraseña == "@la" & (Modulo == "ADM"   ) & (Modulo == "COM") & (Modulo == "VIA"))
                    {

                    }

            }
                
            }







        }
    }
}

