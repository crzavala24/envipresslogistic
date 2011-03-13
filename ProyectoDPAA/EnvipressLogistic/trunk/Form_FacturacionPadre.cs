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
    public partial class Form_FacturacionPadre : Form
    {
        public Form_FacturacionPadre()
        {
            InitializeComponent();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_FacturaNueva frmhijo = new Form_FacturaNueva();
            frmhijo.MdiParent = this;
            frmhijo.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Facturacion frmhijo = new Form_Facturacion();
            frmhijo.MdiParent = this;
            frmhijo.Show();
        }
        
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BuscarFactura frmhijo = new Form_BuscarFactura();
            frmhijo.MdiParent = this;
            frmhijo.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
