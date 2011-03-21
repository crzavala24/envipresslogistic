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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            linkLabel1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PerfilCliente nForm = new PerfilCliente();
            nForm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linkLabel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
