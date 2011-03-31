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
    public partial class Flota : Form
    {
        public Flota()
        {
            InitializeComponent();
        }

        private void Flota_Load(object sender, EventArgs e)
        {
            gbAcciones.Visible = true;
            gbDatosGenerales.Visible = false;
            gbActuales.Visible = false;
            gbBuscar.Visible = false;
            gbNuevo.Visible = false;
            dgvFlota.Visible = false;
            btDetalle.Visible = false;
            btBorrar.Enabled = false;
            btModificar.Enabled = false;
            btBuscar.Enabled = true;
            btNuevo.Enabled = true;
        }

        private void btNuevo_Click_1(object sender, EventArgs e)
        {
            gbDatosGenerales.Visible = true;
            gbActuales.Visible = true;
            gbNuevo.Visible = true;
            gbDatosGenerales.Enabled = true;
            gbActuales.Enabled = true;
            txtEstado.Enabled = true;
            txtConductor.Enabled = true;
            btConfirmarModificar.Visible = false;
            btCancelarModificar.Visible = false;
            btConfirmarNuevo.Visible = true;
            btCancelarNuevo.Visible = true;
        }
 
        private void btBorrar_Click(object sender, EventArgs e)
        {
            rbDefectuoso.Visible = true;
            rbNoRentable.Visible = true;
            lbMotivo.Visible = true;
            rtxMotivo.Visible = true;
            btConfirmarBorrar.Visible = true;
            btCancelarBorrar.Visible = true;
            btBuscar.Enabled = false;
            btNuevo.Enabled = false;
            btModificar.Enabled = false;
            txtBuscarMatricula.Visible = false;
            btConfirmarBuscar.Visible = false;
            btCancelarBuscar.Visible = false;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            gbBuscar.Visible = true;
            rbDefectuoso.Visible = false;
            rbNoRentable.Visible = false;
            btConfirmarBorrar.Visible = false;
            btCancelarBorrar.Visible = false;
            btNuevo.Enabled = false;
            btBorrar.Enabled = false;
            btModificar.Enabled = false;
            lbMotivo.Visible = false;
            rtxMotivo.Visible = false;
            txtBuscarMatricula.Visible = true;
            btConfirmarBuscar.Visible = true;
            btCancelarBuscar.Visible = true;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            gbDatosGenerales.Visible = true;
            gbAcciones.Visible = true;
            gbNuevo.Visible = true;
            gbNuevo.Text = "Modificar";
            btConfirmarNuevo.Visible = false;
            btCancelarNuevo.Visible = false;
            btNuevo.Enabled = false;
            btBorrar.Enabled = false;
            btBuscar.Enabled = false;
            btConfirmarModificar.Visible = true;
            btCancelarModificar.Visible = true;
            gbBuscar.Visible = false;
            txtMatricula.Enabled = true;
            txtDimensiones.Enabled = true;
            txtCapacidad.Enabled = true;
            txtConductor.Enabled = true;
            txtEstado.Enabled = true;
        }

        private void btConfirmarModificar_Click(object sender, EventArgs e)
        {
            Flota_Load(sender, e);
        }

        private void btCancelarModificar_Click(object sender, EventArgs e)
        {
            Flota_Load(sender, e);
        }

        private void btConfirmarNuevo_Click(object sender, EventArgs e)
        {
            Flota_Load(sender, e);
        }

        private void btCancelarNuevo_Click(object sender, EventArgs e)
        {
            Flota_Load(sender, e);
        }

        private void btConfirmarBuscar_Click(object sender, EventArgs e)
        {
            dgvFlota.Visible = true;
            btDetalle.Visible = true;
        }

        private void btCancelarBuscar_Click(object sender, EventArgs e)
        {
            Flota_Load(sender, e);
        }

        private void btConfirmarBorrar_Click(object sender, EventArgs e)
        {
            Flota_Load(sender, e);
        }

        private void btCancelarBorrar_Click(object sender, EventArgs e)
        {
            Flota_Load(sender, e);
        }

        private void btDetalle_Click(object sender, EventArgs e)
        {
            gbDatosGenerales.Visible = true;
            gbActuales.Visible = true;
            txtMatricula.Enabled = false;
            txtDimensiones.Enabled = false;
            txtEstado.Enabled = false;
            txtConductor.Enabled = false;
            txtCapacidad.Enabled = false;
            btBorrar.Enabled = true;
            btModificar.Enabled = true;
        }

        private void btConductor_Click(object sender, EventArgs e)
        {
       /*     Personal f = new Personal();

            Personal.MdiParent = MdiParent;
            Personal.Show();
            Personal.mostrarDetalles();*/
        }

        public void mostrarDetalles()
        {
            gbDatosGenerales.Visible = true;
            gbActuales.Visible = true;
            gbDatosGenerales.Enabled = false;
            gbAcciones.Visible = true;
            btBorrar.Enabled = true;
            btModificar.Enabled = true;
            txtConductor.Enabled = false;
            txtEstado.Enabled = false;
            btConductor.Enabled = true;
        }
    }
}
