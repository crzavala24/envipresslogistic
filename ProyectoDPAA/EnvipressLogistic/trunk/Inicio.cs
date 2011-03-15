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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            MenuPrincipal.Visible = false;
            pboxPrincipal.Visible = false;
            pnlPrincipal.Visible = false;
        }

        private void btAceptarPrincipal_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "envipress" && txtPassword.Text == "123456")
            {
                imgPrincipal.Visible = false;
                lbUsuario.Visible = false;
                lbPassword.Visible = false;
                txtUsuario.Visible = false;
                txtPassword.Visible = false;
                btAceptarPrincipal.Visible = false;
                btCancelarPrincipal.Visible = false;
                MenuPrincipal.Visible = true;
                pboxPrincipal.Visible = true;
                pnlPrincipal.Visible = true;                
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
        }

        private void btCancelarPrincipal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }
    }
}
