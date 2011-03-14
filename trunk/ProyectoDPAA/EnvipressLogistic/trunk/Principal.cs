using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnvipressLogistic
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "envipress" && txtContraseña.Text == "123456")
            {
                Indice index = new Indice();
                index.WindowState = FormWindowState.Normal;
                index.Show();
            }
            else
                MessageBox.Show("Usuario o Contraseña Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
