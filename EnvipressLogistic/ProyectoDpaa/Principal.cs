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

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
