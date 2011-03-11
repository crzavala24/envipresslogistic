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
    public partial class GestionPersonal : Form
    {
        public GestionPersonal()
        {
            InitializeComponent();
        }

        private void GestionPersonal_Load(object sender, EventArgs e)
        {

        }

        private void ArchivoNuevoAlta_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "AltaEmpleado")
                {
                    f.Activate();
                    return;
                }
            }
            AltaEmpleado formHijo = new AltaEmpleado();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }

        private void Horizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void Vertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void Cascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void ArchivoSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ArchivoNuevoBaja_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "BajaEmpleado")
                {
                    f.Activate();
                    return;
                }
            }
            BajaEmpleado formHijo = new BajaEmpleado();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "DatosEmpleados")
                {
                    f.Activate();
                    return;
                }
            }
            BuscarEmpleados formHijo = new BuscarEmpleados();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }

        private void Horarios_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Horarios")
                {
                    f.Activate();
                    return;
                }
            }
            Horarios formHijo = new Horarios();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }

        private void Nominas_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Nominas")
                {
                    f.Activate();
                    return;
                }
            }
            Nominas formHijo = new Nominas();
            formHijo.MdiParent = this;
            formHijo.WindowState = FormWindowState.Maximized;
            formHijo.Show();
        }
    }
}
