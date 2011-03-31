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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void ListarPedidos_Load(object sender, EventArgs e)
        {
            gb_Recogida.Visible = false;
            gb_Entrega.Visible = false;
            gbNuevo.Visible = false;
            gb_Buscar.Visible = false;
            resBusqueda.Visible = false;
            bt_modificar.Enabled = false;
            btVerDetalle.Visible = false;
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            gb_Recogida.Visible = true;
            gb_Entrega.Visible = true;
            gbNuevo.Visible = true;
        }

        private void bt_listado_Click(object sender, EventArgs e)
        {
            resBusqueda.Visible = true;
            btVerDetalle.Visible = true;
        }

        private void btVerDetalle_Click(object sender, EventArgs e)
        {
            gbNuevo.Visible = false;
            gb_Recogida.Visible = true;
            gb_Entrega.Visible = true;
            gb_Recogida.Enabled = false;
            gb_Entrega.Enabled = false;
            bt_modificar.Enabled = true;
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            gbNuevo.Visible = false;
            gb_Entrega.Enabled = true;
            gb_Recogida.Enabled = true;
            gbNuevo.Visible = true;
            gbNuevo.Text = "Modificar";
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            gb_Buscar.Visible = true;
        }

        private void btBuscarAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btBuscarCancelar_Click(object sender, EventArgs e)
        {
            txtBuscarNumero.Text = "";
        }

        private void btNuevoCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDni.Text = "";
            

        }
    }
}
