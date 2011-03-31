using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btPedido_Click(object sender, EventArgs e)
        {

        }

        private void btClientes_Click(object sender, EventArgs e)
        {

        }

        private void btPersonal_Click(object sender, EventArgs e)
        {
            foreach (Form personal in this.MdiChildren)
            {
                if (personal.Name == "Personal")
                {
                    personal.Activate();
                    return;
                }
            }

            Personal nuevoPersonal = new Personal();
            nuevoPersonal.MdiParent = this;
            nuevoPersonal.WindowState = FormWindowState.Maximized;
            nuevoPersonal.Show();
        }

        private void btAlmacen_Click(object sender, EventArgs e)
        {
            foreach (Form almacen in this.MdiChildren)
            {
                if (almacen.Name == "Almacen")
                {
                    almacen.Activate();
                    return;
                }
            }

            Almacen nuevoAlmacen = new Almacen();
            nuevoAlmacen.MdiParent = this;
            nuevoAlmacen.WindowState = FormWindowState.Maximized;
            nuevoAlmacen.Show();
        }

        private void btFlota_Click(object sender, EventArgs e)
        {
            foreach (Form flota in this.MdiChildren)
            {
                if (flota.Name == "Flota")
                {
                    flota.Activate();
                    return;
                }
            }
            Flota nflota = new Flota();
            nflota.MdiParent = this;
            nflota.WindowState = FormWindowState.Maximized;
            nflota.Show();
        }

        private void btIncidencia_Click(object sender, EventArgs e)
        {
            foreach (Form incidencia in this.MdiChildren)
            {
                if (incidencia.Name == "Incidencias")
                {
                    incidencia.Activate();
                    return;
                }
            }
            Incidencias nincidencia = new Incidencias();
            nincidencia.MdiParent = this;
            nincidencia.WindowState = FormWindowState.Maximized;
            nincidencia.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btContabilidad_Click(object sender, EventArgs e)
        {
            foreach (Form contabilidad in this.MdiChildren)
            {
                if (contabilidad.Name == "Almacen")
                {
                    contabilidad.Activate();
                    return;
                }
            }
            Contabilidad ncontabilidad = new Contabilidad();
            ncontabilidad.MdiParent = this;
            ncontabilidad.WindowState = FormWindowState.Maximized;
            ncontabilidad.Show();
        }
    }
}
