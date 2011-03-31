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
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            btBaja.Enabled = false;
            gbDatosBancarios.Visible = false;
            gbDatosContrato.Visible = false;
            gbDatosPersonales.Visible = false;
            gbDatosContrato2.Visible = false;
            gbTipoContrato.Visible = false;
            gbDesencadenante.Visible = false;
            gbAlta.Visible = false;
            dgvEmpleados.Visible = false;
            btVerDetalle.Visible = false;
            btModificar.Enabled = false;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            gbDatosPersonales.Visible = true;
            gbDatosBancarios.Visible = true;
            gbTipoContrato.Visible = true;
            gbDatosContrato.Visible = true;
            gbDesencadenante.Visible = false;
            gbAlta.Visible = true;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //Propiedades del groupBox para Buscar
            gbDesencadenante.Visible = true;
            gbDesencadenante.Text = "Buscar";

            //Elementos de Buscar Visibles
            txtBuscarApellido.Visible = true;
            txtBuscarCiudad.Visible = true;
            txtBuscarDni.Visible = true;
            txtBuscarNombre.Visible = true;
            btBuscarAceptar.Visible = true;
            btBuscarCancelar.Visible = true;

            //Componentes de Baja
            btConfirmarBaja.Visible = false;
            btCancelarBaja.Visible = false;
            lbMotivoBaja.Visible = false;
            rbDespido.Visible = false;
            rbFinContrato.Visible = false;
            rbBajaMedica.Visible = false;
            rtxtMotivo.Visible = false;

            //GrupBox de Alta Ocultos
            gbDatosPersonales.Visible = false;
            gbDatosBancarios.Visible = false;
            gbTipoContrato.Visible = false;
            gbDatosContrato.Visible = false;
            gbDatosContrato2.Visible = false;

            //Bloquear Alta y Desbloquear baja
            btNuevo.Enabled = false;
            btBaja.Enabled = true;
        }

        private void btBaja_Click(object sender, EventArgs e)
        {
            //Propiedades del groupBox para Baja
            gbDesencadenante.Text = "Baja";

            //Elementos de Buscar Ocultos
            txtBuscarApellido.Visible = false;
            txtBuscarCiudad.Visible = false;
            txtBuscarDni.Visible = false;
            txtBuscarNombre.Visible = false;
            btBuscarAceptar.Visible = false;
            btBuscarCancelar.Visible = false;

            //Elementos de Baja Visibles
            btConfirmarBaja.Visible = true;
            btCancelarBaja.Visible = true;
            lbMotivoBaja.Visible = true;
            rbDespido.Visible = true;
            rbFinContrato.Visible = true;
            rbBajaMedica.Visible = true;
            rtxtMotivo.Visible = true;

        }

        private void rbDespido_Click(object sender, EventArgs e)
        {
            rtxtMotivo.Enabled = true;
        }

        private void rbBajaMedica_Click(object sender, EventArgs e)
        {
            rtxtMotivo.Enabled = true;
        }

        private void rbFinContrato_Click(object sender, EventArgs e)
        {
            rtxtMotivo.Enabled = false;
        }

        private void rbtIndefinido_Click(object sender, EventArgs e)
        {
            gbDatosContrato.Visible = true;
            gbDatosContrato2.Visible = false;
        }

        private void rbtParcial_Click(object sender, EventArgs e)
        {
            gbDatosContrato2.Visible = true;
            gbDatosContrato.Visible = false;
        }

        private void btBuscarCancelar_Click(object sender, EventArgs e)
        {
            txtBuscarDni.Text = "";
            txtBuscarNombre.Text = "";
            txtBuscarApellido.Text = "";
            txtBuscarCiudad.Text = "";
            btNuevo.Enabled = true;
            gbDesencadenante.Visible = false;
        }

        private void btCancelarBaja_Click(object sender, EventArgs e)
        {
            rtxtMotivo.Text = "";
            gbDesencadenante.Visible = false;
            btNuevo.Enabled = true;
        }

        private void btVerDetalle_Click(object sender, EventArgs e)
        {
            gbDatosPersonales.Visible = true;
            gbDatosBancarios.Visible = true;
            gbDatosContrato.Visible = true;
            gbDatosContrato2.Visible = true;
            gbTipoContrato.Visible = true;
            gbDatosPersonales.Enabled = false;
            gbDatosBancarios.Enabled = false;
            gbDatosContrato.Enabled = false;
            gbDatosContrato2.Enabled = false;
            gbTipoContrato.Enabled = false;
            btModificar.Enabled = true;
            btVerDetalle.Visible = false;
        }

        private void btBuscarAceptar_Click(object sender, EventArgs e)
        {
            //Mostrar el DataGridView
            dgvEmpleados.Visible = true;
            btVerDetalle.Visible = true;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            gbAlta.Text = "Modificar";
            gbAlta.Visible = true;
            btAltaCancelar.Visible = false;
            btAltaConfirmar.Visible = false;
            btModificarConfirmar.Visible = true;
            btModificarCancelar.Visible = true;
            gbDatosPersonales.Enabled = true;
            gbDatosBancarios.Enabled = true;
            gbDatosContrato.Enabled = true;
            gbDatosContrato2.Enabled = true;
            gbTipoContrato.Enabled = true;
            //btModificar.Enabled = true;
        }

        private void btModificarCancelar_Click(object sender, EventArgs e)
        {
            gbDatosPersonales.Visible = false;
            gbDatosBancarios.Visible = false;
            gbDatosContrato.Visible = false;
            gbDatosContrato2.Visible = false;
            gbTipoContrato.Visible = false;
            gbAlta.Visible = false;
        }

    }
}
