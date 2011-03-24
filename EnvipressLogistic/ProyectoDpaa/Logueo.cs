using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;

namespace EnvipressLogistic
{
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "envipress" && txtPassword.Text == "123456")
            {
                Principal princ = new Principal();
                princ.WindowState = FormWindowState.Maximized;
                princ.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Logueo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void Logueo_Load(object sender, EventArgs e)
        {

        }
    }
}
