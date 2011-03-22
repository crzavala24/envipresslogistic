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
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "InsertarReserva")
                {
                    f.Activate();
                    return;
                }
            }

            InsertarReserva nuevaReserva = new InsertarReserva();
            nuevaReserva.MdiParent = this;
            nuevaReserva.WindowState = FormWindowState.Maximized;
            nuevaReserva.Show();
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void MovimientoSalir_Click(object sender, EventArgs e)
        {
            //Mostramos mensaje de alerta al cerrar el formulario con la pestaña salir.
            if (MessageBox.Show("Desea Salir", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void MovimientoModificarReserva_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "ModificarReserva")
                {
                    f.Activate();
                    return;
                }
            }

            CAModificar_Reserva modReserva = new CAModificar_Reserva();
            modReserva.MdiParent = this;
            modReserva.WindowState = FormWindowState.Maximized;
            modReserva.Show();
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void MovimientoBorrarReserva_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "BorrarReserva")
                {
                    f.Activate();
                    return;
                }
            }

            CABorrar_Reserva borrarReserva = new CABorrar_Reserva();
            borrarReserva.MdiParent = this;
            borrarReserva.WindowState = FormWindowState.Maximized;
            borrarReserva.Show();
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void ControlReservas_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "InsertarReserva")
                {
                    f.Activate();
                    return;
                }
            }

            CAVerReservas verReserva = new CAVerReservas();
            verReserva.MdiParent = this;
            verReserva.WindowState = FormWindowState.Maximized;
            verReserva.Show();
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void ControlAlmacenes_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "CAVerAlmacen")
                {
                    f.Activate();
                    return;
                }
            }

            CAVerAlmacen verAlmacen = new CAVerAlmacen();
            verAlmacen.MdiParent = this;
            verAlmacen.WindowState = FormWindowState.Maximized;
            verAlmacen.Show();
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void BuscarReserva_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "CABuscarReserva")
                {
                    f.Activate();
                    return;
                }
            }

            CABuscarReserva buscarReserva = new CABuscarReserva();
            buscarReserva.MdiParent = this;
            buscarReserva.WindowState = FormWindowState.Maximized;
            buscarReserva.Show();
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void BuscarAlmacen_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "CABuscarAlmacen")
                {
                    f.Activate();
                    return;
                }
            }

            CABuscarAlmacen buscarAlmacen = new CABuscarAlmacen();
            buscarAlmacen.MdiParent = this;
            buscarAlmacen.WindowState = FormWindowState.Maximized;
            buscarAlmacen.Show();
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void Movimiento_Click(object sender, EventArgs e)
        {

        }

        private void ControlAlmacen_Load(object sender, EventArgs e)
        {

        }
    }
}
