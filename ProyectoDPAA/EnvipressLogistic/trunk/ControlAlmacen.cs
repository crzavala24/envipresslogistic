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
    public partial class ControlAlmacen : Form
    {
        public ControlAlmacen()
        {
            IsMdiContainer = true;
            InitializeComponent();
        }

        private void MovimientoInsertarReserva_Click(object sender, EventArgs e)
        {
            CAInsertar_Reserva nuevaReserva = new CAInsertar_Reserva();
            nuevaReserva.WindowState = FormWindowState.Normal;
            nuevaReserva.Show();
        }

        private void MovimientoSalir_Click(object sender, EventArgs e)
        {
            //Mostramos mensaje de alerta al cerrar el formulario con la pestaña salir.
            if (MessageBox.Show("Desea Salir", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void MovimientoModificarReserva_Click(object sender, EventArgs e)
        {
            CAModificar_Reserva modReserva = new CAModificar_Reserva();
            modReserva.WindowState = FormWindowState.Normal;
            modReserva.Show();
        }

        private void MovimientoBorrarReserva_Click(object sender, EventArgs e)
        {
            CABorrar_Reserva borrarReserva = new CABorrar_Reserva();
            borrarReserva.WindowState = FormWindowState.Normal;
            borrarReserva.Show();
        }

        private void ControlReservas_Click(object sender, EventArgs e)
        {
            CAVerReservas verReserva = new CAVerReservas();
            verReserva.WindowState = FormWindowState.Normal;
            verReserva.Show();
        }

        private void ControlAlmacenes_Click(object sender, EventArgs e)
        {
            CAVerAlmacen verAlmacen = new CAVerAlmacen();
            verAlmacen.WindowState = FormWindowState.Normal;
            verAlmacen.Show();
        }

        private void BuscarReserva_Click(object sender, EventArgs e)
        {
            CABuscarReserva buscarAlmacen = new CABuscarReserva();
            buscarAlmacen.WindowState = FormWindowState.Normal;
            buscarAlmacen.Show();
        }

        private void BuscarAlmacen_Click(object sender, EventArgs e)
        {
            CABuscarAlmacen buscarAlmacen = new CABuscarAlmacen();
            buscarAlmacen.WindowState = FormWindowState.Normal;
            buscarAlmacen.Show();
        }

        private void Movimiento_Click(object sender, EventArgs e)
        {

        }
    }
}
