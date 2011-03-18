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
    public partial class Form_BuscarFactura : Form
    {
        public Form_BuscarFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_BuscarFacturaResultados resultados = new Form_BuscarFacturaResultados();
            resultados.Show();
        }

        private void Form_BuscarFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
