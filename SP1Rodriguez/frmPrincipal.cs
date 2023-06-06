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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdIniciarSesion_Click(object sender, EventArgs e)
        {
            frmLogin fmrLogin = new frmLogin();
            this.Hide();
            fmrLogin.ShowDialog();
        }
    }
}
