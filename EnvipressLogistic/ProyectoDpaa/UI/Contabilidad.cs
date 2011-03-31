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
    public partial class Contabilidad : Form
    {
        public Contabilidad()
        {
            InitializeComponent();          
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            gbFacturas.Show();
            gbNuevo.Show();
        }

        private void btNuevoConfirmar_Click(object sender, EventArgs e)
        {
            gbFacturas.Visible = false;
            gbNuevo.Visible = false;
        }

        private void btNuevoCancelar_Click(object sender, EventArgs e)
        {
            gbFacturas.Visible = false;
            gbNuevo.Visible = false;
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            gbBuscar.Show();
        }

        private void bt_BusquedaAceptar_Click(object sender, EventArgs e)
        {
            gbBuscar.Visible = false;
            if (elTabBusqueda.SelectedTabPage.Equals(elTabBusqueda_Facturas)) //facturas
            {
                gbFacturas.Show();
                tab_factura1.Focus();
                tab_factura1.Show();
                txt_NIF1.Visible = true;
                CheckBox_pagado1.Visible = true;
                bt_ModificarAceptar1.Visible = true;
                bt_ModificarCancelar1.Visible = true;
                elDataGrid_Facturas.Visible = true;                
            }

            if (elTabBusqueda.SelectedTabPage.Equals(elTabBusqueda_Reservas)) //reservas
            {
                gbFacturas.Show();
                tab_factura2.Focus();
                tab_factura2.Show();
                txt_NIF2.Visible = true;
                CheckBox_pagado2.Visible = true;
                bt_ModificarAceptar2.Visible = true;
                bt_ModificarCancelar2.Visible = true;
                elDataGrid_Reservas.Visible = true;
            }
        }

        private void bt_BusquedaCancelar_Click(object sender, EventArgs e)
        {
            gbBuscar.Visible = false;
        }

        private void bt_ModificarAceptar1_Click(object sender, EventArgs e)
        {
            txt_NIF1.Visible = false;
            CheckBox_pagado1.Visible = false;
            bt_ModificarAceptar1.Visible = false;
            bt_ModificarCancelar1.Visible = false;
            elDataGrid_Facturas.Visible = false;
            gbFacturas.Visible = false;
        }

        private void bt_ModificarCancelar1_Click(object sender, EventArgs e)
        {
            txt_NIF1.Visible = false;
            CheckBox_pagado2.Visible = false;
            bt_ModificarAceptar1.Visible = false;
            bt_ModificarCancelar1.Visible = false;
            elDataGrid_Facturas.Visible = false;
            gbFacturas.Visible = false;
        }

        private void bt_ModificarAceptar2_Click(object sender, EventArgs e)
        {
            txt_NIF2.Visible = false;
            bt_ModificarAceptar2.Visible = false;
            bt_ModificarCancelar2.Visible = false;
            elDataGrid_Reservas.Visible = false;
            gbFacturas.Visible = false;
        }

        private void bt_ModificarCancelar2_Click(object sender, EventArgs e)
        {
            txt_NIF2.Visible = false;
            bt_ModificarAceptar2.Visible = false;
            bt_ModificarCancelar2.Visible = false;
            elDataGrid_Reservas.Visible = false;
            gbFacturas.Visible = false;
        }
    }
}
