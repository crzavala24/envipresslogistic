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
    public partial class Incidencias : Form
    {
        public Incidencias()
        {
            InitializeComponent();
        }

        private void Incidencias_Load(object sender, EventArgs e)
        {
            gbAcciones.Visible = true;
            dtvIncidencias.Visible = false;
            btDetalle.Visible = false;
            gbGenerales.Visible = false;
            gbImplicados.Visible = false;
            gbBuscar.Visible = false;
            gbNueva.Visible = false;
            btBorrar.Enabled = false;
            btModificar.Enabled = false;
            txtId.Enabled = true;
            txtAlmacen.Enabled = true;
            txtVehiculo.Enabled = true;
            dtFecha.Enabled = true;
            rtxDescripcion.Enabled = true;
            btNueva.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btNueva_Click_1(object sender, EventArgs e)
        {
            gbGenerales.Visible = true;
            gbImplicados.Visible = true;
            gbNueva.Visible = true;
            btConfirmarModificar.Visible = false;
            btCancelarModificar.Visible = false;
            btBuscar.Enabled = false;
            btBorrar.Enabled = false;
            btModificar.Enabled = false;
            txtId.Enabled = true;
            chRevisada.Enabled = true;
            dtFecha.Enabled = true;
            rtxDescripcion.Enabled = true;
            txtAlmacen.Enabled = true;
            txtVehiculo.Enabled = true;
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            gbBuscar.Visible = true;
            gbBuscar.Text = "Borrar";
            txtIdBuscar.Visible = false;
            btConfirmarBuscar.Visible = false;
            btCancelarBuscar.Visible = false;
            btNueva.Enabled = false;
            btBuscar.Enabled = false;
            btModificar.Enabled = false;
            rbExpirada.Visible = true;
            rbSolucionada.Visible = true;
            lbMotivo.Visible = true;
            rtxMotivo.Visible=true;
            btConfirmarBorrar.Visible = true;
            btCancelarBorrar.Visible = true;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            gbBuscar.Visible = true;
            rbExpirada.Visible = false;
            rbSolucionada.Visible = false;
            lbMotivo.Visible = false;
            rtxMotivo.Visible = false;
            btConfirmarBorrar.Visible = false;
            btCancelarBorrar.Visible = false;
            btNueva.Enabled = false;
            btModificar.Enabled = false;
            btBorrar.Enabled = false;
            txtIdBuscar.Visible = true;
            btConfirmarBuscar.Visible = true;
            btCancelarBuscar.Visible = true;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            btNueva.Enabled = false;
            btBorrar.Enabled = false;
            btBuscar.Enabled = false;
            gbNueva.Visible = true;
            gbNueva.Text = "Modificar";
            gbBuscar.Visible = false;
            btConfirmarModificar.Visible = true;
            btCancelarModificar.Visible = true;
            btConfirmarModificar.Visible = true;
            btCancelarModificar.Visible = true;
            txtId.Enabled = true;
            chRevisada.Enabled = true;
            dtFecha.Enabled = true;
            rtxDescripcion.Enabled = true;
            txtAlmacen.Enabled = true;
            txtVehiculo.Enabled = true;
        }

        private void btConfirmarModificar_Click(object sender, EventArgs e)
        {
            Incidencias_Load(sender, e);
        }

        private void btCancelarModificar_Click(object sender, EventArgs e)
        {
            Incidencias_Load(sender, e);
        }

        private void btConfirmarNueva_Click(object sender, EventArgs e)
        {
            Incidencias_Load(sender, e);
        }

        private void btCancelarNueva_Click(object sender, EventArgs e)
        {
            Incidencias_Load(sender, e);
        }

        private void btConfirmarBuscar_Click(object sender, EventArgs e)
        {
            dtvIncidencias.Visible = true;
            btDetalle.Visible = true;
        }

        private void btCancelarBuscar_Click(object sender, EventArgs e)
        {
            Incidencias_Load(sender, e);
        }

        private void btConfirmarBorrar_Click(object sender, EventArgs e)
        {
            Incidencias_Load(sender, e);
        }

        private void btCancelarBorrar_Click(object sender, EventArgs e)
        {
            Incidencias_Load(sender, e);
        }

        private void btDetalle_Click(object sender, EventArgs e)
        {
            gbGenerales.Visible = true;
            gbImplicados.Visible = true;
            txtId.Enabled = false;
            txtAlmacen.Enabled = false;
            txtVehiculo.Enabled = false;
            dtFecha.Enabled = false;
            rtxDescripcion.Enabled = false;
            btBorrar.Enabled = true;
            btModificar.Enabled = true;
        }

        private void btAlmacen_Click(object sender, EventArgs e)
        {
            /*     Almacen f = new Almacen();

            Almacen.MdiParent = MdiParent;
            Almacen.Show();
            almacen.mostrarDetalles();*/
        }

        private void btVehiculo_Click(object sender, EventArgs e)
        {
            Flota f = new Flota();

            f.MdiParent = MdiParent;
            f.Show();
            f.mostrarDetalles();
        }
    }
}
