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
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            //Mostramos solo el GroupBox de Acciones
            gbDatosAlmacen.Visible = false;
            gbBuscar.Visible = false;
            dgvAlmacenes.Visible = false;
            btVerDetalle.Visible = false;
            btCancelarResultado.Visible = false;
            //Desactivamos los botones que no necesitamos
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
            btGuardar.Enabled = false;
            btGuardarNuevo.Enabled = false;
            btCancelar.Enabled = false;
            btCancelarNuevo.Enabled = false;
            gbDatosReserva.Visible = false;
            dgvReserva.Visible = false;
            btVerDetalle2.Visible = false;
            btCancelarResultado2.Visible = false;
            gbBuscar2.Visible = false;
            btReservaModificar.Enabled = false;
            btReservaEliminar.Enabled = false;
            btReservaGuardarNuevo.Enabled = false;
            btReservaCancelar.Enabled = false;

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            //Mostramos los datos a rellenar y activamos los botones de guardar y cancelar nuevo
            gbDatosAlmacen.Visible = true;
            gbDatosAlmacen.Enabled = true;
            btGuardarNuevo.Enabled = true;
            btCancelarNuevo.Enabled = true;
            btGuardarNuevo.Visible = true;
            btCancelarNuevo.Visible= true;
            //Ocultamos los botones de aceptar y cancelar. Desactivamos los botones buscar y nuevo
            btGuardar.Visible = false;
            btCancelar.Visible = false;
            btNuevo.Enabled = false;
            btBuscar.Enabled = false;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            gbDatosAlmacen.Enabled = true;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
            btModificar.Enabled = false;
            btCancelarNuevo.Visible = false;
            btGuardarNuevo.Visible = false;
            btEliminar.Enabled = false;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            gbBuscar.Visible = true;
            btNuevo.Enabled = false;
            btBuscar.Enabled = false;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            //Mostramos solo el GroupBox de Acciones
            gbDatosAlmacen.Visible = false;
            gbBuscar.Visible = false;
            dgvAlmacenes.Visible = false;
            btVerDetalle.Visible = false;
            btCancelarResultado.Visible = false;
            //Desactivamos los botones que no necesitamos
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
            btGuardar.Enabled = false;
            btGuardarNuevo.Enabled = false;
            btCancelar.Enabled = false;
            btCancelarNuevo.Enabled = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btGuardarNuevo_Click(object sender, EventArgs e)
        {
            //Mostramos solo el GroupBox de Acciones
            gbDatosAlmacen.Visible = false;
            //Desactivamos los botones que no necesitamos
            btGuardarNuevo.Enabled = false;
            btCancelarNuevo.Enabled = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btCancelarNuevo_Click(object sender, EventArgs e)
        {
            //Mostramos solo el GroupBox de Acciones
            gbDatosAlmacen.Visible = false;
            //Desactivamos los botones que no necesitamos
            btGuardarNuevo.Enabled = false;
            btCancelarNuevo.Enabled = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //Mostramos solo el GroupBox de Acciones
            gbDatosAlmacen.Visible = false;
            gbBuscar.Visible = false;
            dgvAlmacenes.Visible = false;
            btVerDetalle.Visible = false;
            btCancelarResultado.Visible = false;
            //Desactivamos los botones que no necesitamos
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
            btGuardar.Enabled = false;
            btGuardarNuevo.Enabled = false;
            btCancelar.Enabled = false;
            btCancelarNuevo.Enabled = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            gbDatosAlmacen.Visible = false;
            dgvAlmacenes.Visible = false;
            btVerDetalle.Enabled = true;
            btVerDetalle.Visible = false;
            btCancelarResultado.Visible = false;
            btGuardarNuevo.Visible = true;
            btCancelarNuevo.Visible = true;
            btGuardar.Enabled = false;
            btCancelar.Enabled = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btBuscarBuscar_Click(object sender, EventArgs e)
        {
            dgvAlmacenes.Visible = true;
            btVerDetalle.Visible = true;
            btVerDetalle.Enabled = true;
            btCancelarResultado.Visible = true;
            gbBuscar.Enabled = false;
        }

        private void btVerDetalle_Click(object sender, EventArgs e)
        {
            gbBuscar.Enabled = true;
            gbBuscar.Visible = false;
            gbDatosAlmacen.Visible = true;
            btModificar.Enabled = true;
            btEliminar.Enabled = true;
            btVerDetalle.Enabled = false;
            gbDatosAlmacen.Enabled = false;
        }

        private void btCancelarResultado_Click(object sender, EventArgs e)
        {
            if (gbDatosAlmacen.Visible == true)
            {
                gbDatosAlmacen.Visible = false;
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
                dgvAlmacenes.Visible = false;
                btVerDetalle.Enabled = true;
                btVerDetalle.Visible = false;
                gbBuscar.Visible = true;
                btCancelarResultado.Visible = false;
            }
            else
            {
                btVerDetalle.Visible = false;
                dgvAlmacenes.Visible = false;
                btCancelarResultado.Visible = false;
                gbBuscar.Enabled = true;
            }
        }

        private void btInicio_Click(object sender, EventArgs e)
        {
            //Mostramos solo el GroupBox de Acciones
            gbDatosAlmacen.Visible = false;
            gbBuscar.Visible = false;
            dgvAlmacenes.Visible = false;
            btVerDetalle.Visible = false;
            btCancelarResultado.Visible = false;
            //Desactivamos los botones que no necesitamos
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
            btGuardar.Enabled = false;
            btGuardarNuevo.Enabled = false;
            btCancelar.Enabled = false;
            btCancelarNuevo.Enabled = false;
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btCancelarBuscar_Click(object sender, EventArgs e)
        {
            gbBuscar.Visible = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }
   
        private void btReservaNuevo_Click(object sender, EventArgs e)
        {
            //Mostramos los datos a rellenar y activamos los botones de guardar y cancelar nuevo
            gbDatosReserva.Visible = true;
            gbDatosReserva.Enabled = true;
            btGuardarNuevo.Enabled = true;
            btCancelarNuevo.Enabled = true;
            btGuardarNuevo.Visible = true;
            btCancelarNuevo.Visible = true;
            //Ocultamos los botones de aceptar y cancelar. Desactivamos los botones buscar y nuevo
            btGuardar.Visible = false;
            btCancelar.Visible = false;
            btNuevo.Enabled = false;
            btBuscar.Enabled = false;
        }

        private void btReservaModificar_Click(object sender, EventArgs e)
        {
            gbDatosReserva.Enabled = true;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
            btModificar.Enabled = false;
            btCancelarNuevo.Visible = false;
            btGuardarNuevo.Visible = false;
            btEliminar.Enabled = false;
        }

        private void btReservaBuscar_Click(object sender, EventArgs e)
        {
            gbBuscar.Visible = true;
            btNuevo.Enabled = false;
            btBuscar.Enabled = false;
        }

        private void btReservaEliminar_Click(object sender, EventArgs e)
        {
            //Mostramos solo el GroupBox de Acciones
            gbDatosReserva.Visible = false;
            gbBuscar.Visible = false;
            dgvReserva.Visible = false;
            btVerDetalle.Visible = false;
            btCancelarResultado.Visible = false;
            //Desactivamos los botones que no necesitamos
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
            btGuardar.Enabled = false;
            btGuardarNuevo.Enabled = false;
            btCancelar.Enabled = false;
            btCancelarNuevo.Enabled = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btReservaGuardarNuevo_Click(object sender, EventArgs e)
        {
            //Mostramos solo el GroupBox de Acciones
            gbDatosReserva.Visible = false;
            //Desactivamos los botones que no necesitamos
            btGuardarNuevo.Enabled = false;
            btCancelarNuevo.Enabled = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btReservaCancelar_Click(object sender, EventArgs e)
        {
            gbDatosReserva.Visible = false;
            dgvReserva.Visible = false;
            btVerDetalle.Enabled = true;
            btVerDetalle.Visible = false;
            btCancelarResultado.Visible = false;
            btGuardarNuevo.Visible = true;
            btCancelarNuevo.Visible = true;
            btGuardar.Enabled = false;
            btCancelar.Enabled = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btReservaGuardar_Click(object sender, EventArgs e)
        {
            //Mostramos solo el GroupBox de Acciones
            gbDatosReserva.Visible = false;
            gbBuscar.Visible = false;
            dgvReserva.Visible = false;
            btVerDetalle.Visible = false;
            btCancelarResultado.Visible = false;
            //Desactivamos los botones que no necesitamos
            btModificar.Enabled = false;
            btEliminar.Enabled = false;
            btGuardar.Enabled = false;
            btGuardarNuevo.Enabled = false;
            btCancelar.Enabled = false;
            btCancelarNuevo.Enabled = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btReservaCancelarNuevo_Click(object sender, EventArgs e)
        {
            //Mostramos solo el GroupBox de Acciones
            gbDatosReserva.Visible = false;
            //Desactivamos los botones que no necesitamos
            btGuardarNuevo.Enabled = false;
            btCancelarNuevo.Enabled = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btReservaBuscarBuscar_Click(object sender, EventArgs e)
        {
            dgvReserva.Visible = true;
            btVerDetalle.Visible = true;
            btVerDetalle.Enabled = true;
            btCancelarResultado.Visible = true;
            gbBuscar.Enabled = false;
        }

        private void btCancelarBuscar2_Click(object sender, EventArgs e)
        {
            gbBuscar.Visible = false;
            btNuevo.Enabled = true;
            btBuscar.Enabled = true;
        }

        private void btVerDetalle2_Click(object sender, EventArgs e)
        {
            gbBuscar.Enabled = true;
            gbBuscar.Visible = false;
            gbDatosReserva.Visible = true;
            btModificar.Enabled = true;
            btEliminar.Enabled = true;
            btVerDetalle.Enabled = false;
            gbDatosReserva.Enabled = false;
        }

        private void btCancelarResultado2_Click(object sender, EventArgs e)
        {
            if (gbDatosAlmacen.Visible == true)
            {
                gbDatosReserva.Visible = false;
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
                dgvReserva.Visible = false;
                btVerDetalle.Enabled = true;
                btVerDetalle.Visible = false;
                gbBuscar.Visible = true;
                btCancelarResultado.Visible = false;
            }
            else
            {
                btVerDetalle.Visible = false;
                dgvReserva.Visible = false;
                btCancelarResultado.Visible = false;
                gbBuscar.Enabled = true;
            }
        }

        //Creadas por Christian

        private void btVolverReserva_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btInicioReserva_Click(object sender, EventArgs e)
        {
            gbDatosReserva.Visible = false;
            gbBuscar2.Visible = false;
            dgvReserva.Visible = false;
            btVerDetalle2.Visible = false;
            btCancelarResultado2.Visible = false;
            btReservaModificar.Enabled = false;
            btReservaEliminar.Enabled = false;
            btReservaGuardarNuevo.Enabled = false;
            btReservaCancelar.Enabled = false;

        }

        private void btReservaNuevo_Click_1(object sender, EventArgs e)
        {
            gbDatosReserva.Visible = true;
            btReservaGuardarNuevo.Enabled = true;
            btReservaCancelar.Enabled = true;
            btReservaNuevo.Enabled = false;
            btReservaBuscar.Enabled = false;
        }

        private void btReservaBuscar_Click_1(object sender, EventArgs e)
        {
            gbBuscar2.Visible = true;
            gbAcciones2.Enabled = true;
            gbBuscar2.Enabled = true;

        }

        private void btCancelarResultado2_Click_1(object sender, EventArgs e)
        {
            btCancelarResultado2.Visible = false;
            dgvReserva.Visible = false;
            btVerDetalle2.Visible = false;
            gbAcciones2.Enabled = true;
            gbBuscar2.Enabled = true;
        }

        private void btReservaBuscarBuscar_Click_1(object sender, EventArgs e)
        {
            dgvReserva.Visible = true;
            btCancelarResultado2.Visible = true;
            btVerDetalle2.Visible = true;
            gbAcciones2.Enabled = false;
            gbBuscar2.Enabled = false;
        }

        private void btCancelarBuscar2_Click_1(object sender, EventArgs e)
        {
            gbBuscar2.Visible = false;
        }

        private void btReservaCancelar_Click_1(object sender, EventArgs e)
        {
            gbDatosReserva.Visible = false;
            btReservaNuevo.Enabled = true;
            btReservaBuscar.Enabled = true;
            btReservaCancelar.Enabled = false;
            btReservaGuardarNuevo.Enabled = false;
        }
    }
}
