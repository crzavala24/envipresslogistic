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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPersonal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoNuevoAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoNuevoBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ArchivoCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ArchivoGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoGuardarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.Horarios = new System.Windows.Forms.ToolStripMenuItem();
            this.Empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.Nominas = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventana = new System.Windows.Forms.ToolStripMenuItem();
            this.Horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.Vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.Cascada = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Consultar,
            this.Ventana,
            this.Ayuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.Ventana;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoNuevo,
            this.toolStripSeparator3,
            this.ArchivoCerrar,
            this.toolStripSeparator2,
            this.ArchivoGuardar,
            this.ArchivoGuardarTodo,
            this.toolStripSeparator1,
            this.ArchivoSalir});
            this.Archivo.MergeIndex = 0;
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(60, 20);
            this.Archivo.Text = "Archivo";
            // 
            // ArchivoNuevo
            // 
            this.ArchivoNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoNuevoAlta,
            this.ArchivoNuevoBaja});
            this.ArchivoNuevo.MergeIndex = 0;
            this.ArchivoNuevo.Name = "ArchivoNuevo";
            this.ArchivoNuevo.Size = new System.Drawing.Size(152, 22);
            this.ArchivoNuevo.Text = "Nuevo";
            // 
            // ArchivoNuevoAlta
            // 
            this.ArchivoNuevoAlta.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ArchivoNuevoAlta.MergeIndex = 0;
            this.ArchivoNuevoAlta.Name = "ArchivoNuevoAlta";
            this.ArchivoNuevoAlta.Size = new System.Drawing.Size(152, 22);
            this.ArchivoNuevoAlta.Text = "Alta";
            this.ArchivoNuevoAlta.Click += new System.EventHandler(this.ArchivoNuevoAlta_Click);
            // 
            // ArchivoNuevoBaja
            // 
            this.ArchivoNuevoBaja.Name = "ArchivoNuevoBaja";
            this.ArchivoNuevoBaja.Size = new System.Drawing.Size(152, 22);
            this.ArchivoNuevoBaja.Text = "Baja";
            this.ArchivoNuevoBaja.Click += new System.EventHandler(this.ArchivoNuevoBaja_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // ArchivoCerrar
            // 
            this.ArchivoCerrar.MergeIndex = 2;
            this.ArchivoCerrar.Name = "ArchivoCerrar";
            this.ArchivoCerrar.Size = new System.Drawing.Size(152, 22);
            this.ArchivoCerrar.Text = "Cerrar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // ArchivoGuardar
            // 
            this.ArchivoGuardar.MergeIndex = 3;
            this.ArchivoGuardar.Name = "ArchivoGuardar";
            this.ArchivoGuardar.Size = new System.Drawing.Size(152, 22);
            this.ArchivoGuardar.Text = "Guardar";
            // 
            // ArchivoGuardarTodo
            // 
            this.ArchivoGuardarTodo.MergeIndex = 4;
            this.ArchivoGuardarTodo.Name = "ArchivoGuardarTodo";
            this.ArchivoGuardarTodo.Size = new System.Drawing.Size(152, 22);
            this.ArchivoGuardarTodo.Text = "Guardar todo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ArchivoSalir
            // 
            this.ArchivoSalir.MergeIndex = 5;
            this.ArchivoSalir.Name = "ArchivoSalir";
            this.ArchivoSalir.Size = new System.Drawing.Size(152, 22);
            this.ArchivoSalir.Text = "Sallir";
            this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
            // 
            // Consultar
            // 
            this.Consultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Horarios,
            this.Empleados,
            this.Nominas});
            this.Consultar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.Consultar.MergeIndex = 2;
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(70, 20);
            this.Consultar.Text = "Consultar";
            // 
            // Horarios
            // 
            this.Horarios.Name = "Horarios";
            this.Horarios.Size = new System.Drawing.Size(152, 22);
            this.Horarios.Text = "Horarios";
            this.Horarios.Click += new System.EventHandler(this.Horarios_Click);
            // 
            // Empleados
            // 
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(152, 22);
            this.Empleados.Text = "Empleados";
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // Nominas
            // 
            this.Nominas.Name = "Nominas";
            this.Nominas.Size = new System.Drawing.Size(152, 22);
            this.Nominas.Text = "Nominas";
            this.Nominas.Click += new System.EventHandler(this.Nominas_Click);
            // 
            // Ventana
            // 
            this.Ventana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Horizontal,
            this.Vertical,
            this.Cascada});
            this.Ventana.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.Ventana.MergeIndex = 3;
            this.Ventana.Name = "Ventana";
            this.Ventana.Size = new System.Drawing.Size(62, 20);
            this.Ventana.Text = "Ventana";
            // 
            // Horizontal
            // 
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(152, 22);
            this.Horizontal.Text = "Horizontal";
            this.Horizontal.Click += new System.EventHandler(this.Horizontal_Click);
            // 
            // Vertical
            // 
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(152, 22);
            this.Vertical.Text = "Vertical";
            this.Vertical.Click += new System.EventHandler(this.Vertical_Click);
            // 
            // Cascada
            // 
            this.Cascada.Name = "Cascada";
            this.Cascada.Size = new System.Drawing.Size(152, 22);
            this.Cascada.Text = "Cascada";
            this.Cascada.Click += new System.EventHandler(this.Cascada_Click);
            // 
            // Ayuda
            // 
            this.Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.Ayuda.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.Ayuda.MergeIndex = 4;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(53, 20);
            this.Ayuda.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // GestionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(423, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionPersonal";
            this.Text = "Gestión de Personal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Consultar;
        private System.Windows.Forms.ToolStripMenuItem Horarios;
        private System.Windows.Forms.ToolStripMenuItem Empleados;
        private System.Windows.Forms.ToolStripMenuItem Nominas;
        private System.Windows.Forms.ToolStripMenuItem Ventana;
        private System.Windows.Forms.ToolStripMenuItem Horizontal;
        private System.Windows.Forms.ToolStripMenuItem Vertical;
        private System.Windows.Forms.ToolStripMenuItem Cascada;
        private System.Windows.Forms.ToolStripMenuItem Ayuda;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArchivoCerrar;
        private System.Windows.Forms.ToolStripMenuItem ArchivoNuevo;
        private System.Windows.Forms.ToolStripMenuItem ArchivoNuevoAlta;
        private System.Windows.Forms.ToolStripMenuItem ArchivoNuevoBaja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ArchivoGuardar;
        private System.Windows.Forms.ToolStripMenuItem ArchivoGuardarTodo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;

    }
}

