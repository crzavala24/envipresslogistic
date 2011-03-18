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
                this.WindowState = FormWindowState.Maximized;
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

        private void gestionPersonal_Click(object sender, EventArgs e)
        {
            GestionPersonal nForm = new GestionPersonal();
            nForm.WindowState = FormWindowState.Maximized;
            nForm.Show();
        }

        private void buscarCliente_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "BuscarCliente")
                {
                    f.Activate();
                    return;
                }
            }

            BuscarCliente fBuscar = new BuscarCliente();
            fBuscar.MdiParent = this;
            fBuscar.WindowState = FormWindowState.Normal;
            fBuscar.Show();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void controlAlmacen_Click(object sender, EventArgs e)
        {
            ControlAlmacen nForm = new ControlAlmacen();
            nForm.WindowState = FormWindowState.Maximized;
            nForm.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_FacturaNueva frmhijo = new Form_FacturaNueva();
            frmhijo.MdiParent = this;
            frmhijo.Show();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Facturacion frmhijo = new Form_Facturacion();
            frmhijo.MdiParent = this;
            frmhijo.Show();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BuscarFactura frmhijo = new Form_BuscarFactura();
            frmhijo.MdiParent = this;
            frmhijo.Show();
        }

        private void listadoFlotaStrpMenuItem_Click(object senderm, EventArgs e)
        {
            ListadoFlota form = new ListadoFlota();
            form.MdiParent = this;
            form.Show();
        }

        private void FlotaStrpMenuItem_Click(object senderm, EventArgs e)
        {
            Flota form = new Flota();
            form.MdiParent = this;
            form.Show();
        }

        private void incidenciasAntStrpMenuItem_Click(object senderm, EventArgs e)
        {
            IncidenciasAnteriores form = new IncidenciasAnteriores();
            form.MdiParent = this;
            form.Show();
        }

        private void incidenciastrpMenuItem_Click(object senderm, EventArgs e)
        {
            Incidencias form = new Incidencias();
            form.MdiParent = this;
            form.Show();
        }
    }
}
