namespace EnvipressLogistic
{
    partial class GestionPersonal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuGPersonal = new System.Windows.Forms.MenuStrip();
            this.AltaEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.BajaEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.Horarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Nóminas = new System.Windows.Forms.ToolStripMenuItem();
            this.Empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuGPersonal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuGPersonal
            // 
            this.MenuGPersonal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaEmpleado,
            this.BajaEmpleado,
            this.Horarios,
            this.Nóminas,
            this.Empleados,
            this.salirToolStripMenuItem});
            this.MenuGPersonal.Location = new System.Drawing.Point(0, 0);
            this.MenuGPersonal.Name = "MenuGPersonal";
            this.MenuGPersonal.Size = new System.Drawing.Size(423, 24);
            this.MenuGPersonal.TabIndex = 2;
            this.MenuGPersonal.Text = "menuStrip1";
            // 
            // AltaEmpleado
            // 
            this.AltaEmpleado.Name = "AltaEmpleado";
            this.AltaEmpleado.Size = new System.Drawing.Size(45, 20);
            this.AltaEmpleado.Text = "Altas";
            this.AltaEmpleado.Click += new System.EventHandler(this.AltaEmpleado_Click);
            // 
            // BajaEmpleado
            // 
            this.BajaEmpleado.Name = "BajaEmpleado";
            this.BajaEmpleado.Size = new System.Drawing.Size(46, 20);
            this.BajaEmpleado.Text = "Bajas";
            this.BajaEmpleado.Click += new System.EventHandler(this.BajaEmpleado_Click);
            // 
            // Horarios
            // 
            this.Horarios.Name = "Horarios";
            this.Horarios.Size = new System.Drawing.Size(64, 20);
            this.Horarios.Text = "Horarios";
            this.Horarios.Click += new System.EventHandler(this.Horarios_Click);
            // 
            // Nóminas
            // 
            this.Nóminas.Name = "Nóminas";
            this.Nóminas.Size = new System.Drawing.Size(67, 20);
            this.Nóminas.Text = "Nóminas";
            this.Nóminas.Click += new System.EventHandler(this.Nóminas_Click);
            // 
            // Empleados
            // 
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(77, 20);
            this.Empleados.Text = "Empleados";
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 62);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(301, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GestionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuGPersonal);
            this.IsMdiContainer = true;
            this.Name = "GestionPersonal";
            this.Text = "Gestión de Personal";
            //this.Load += new System.EventHandler(this.GestionPersoanal_Load);
            this.MenuGPersonal.ResumeLayout(false);
            this.MenuGPersonal.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuGPersonal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem AltaEmpleado;
        private System.Windows.Forms.ToolStripMenuItem BajaEmpleado;
        private System.Windows.Forms.ToolStripMenuItem Horarios;
        private System.Windows.Forms.ToolStripMenuItem Nóminas;
        private System.Windows.Forms.ToolStripMenuItem Empleados;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;

    }
}

