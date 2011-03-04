namespace EnvipressLogistic
{
    partial class FormPadre
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoBaja = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.Ver = new System.Windows.Forms.ToolStripMenuItem();
            this.VerFEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.Ventana = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.VentanaVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Ver,
            this.Ventana,
            this.Ayuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoAlta,
            this.ArchivoBaja,
            this.toolStripSeparator1,
            this.ArchivoSalir});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(55, 20);
            this.Archivo.Text = "Archivo";
            // 
            // ArchivoAlta
            // 
            this.ArchivoAlta.Name = "ArchivoAlta";
            this.ArchivoAlta.Size = new System.Drawing.Size(147, 22);
            this.ArchivoAlta.Text = "Realizar Alta";
            // 
            // ArchivoBaja
            // 
            this.ArchivoBaja.Name = "ArchivoBaja";
            this.ArchivoBaja.Size = new System.Drawing.Size(147, 22);
            this.ArchivoBaja.Text = "Realizar Baja";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // ArchivoSalir
            // 
            this.ArchivoSalir.Name = "ArchivoSalir";
            this.ArchivoSalir.Size = new System.Drawing.Size(147, 22);
            this.ArchivoSalir.Text = "Salir";
            // 
            // Ver
            // 
            this.Ver.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VerFEmpleado});
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(35, 20);
            this.Ver.Text = "Ver";
            // 
            // VerFEmpleado
            // 
            this.VerFEmpleado.Name = "VerFEmpleado";
            this.VerFEmpleado.Size = new System.Drawing.Size(174, 22);
            this.VerFEmpleado.Text = "Ficha de Empleado";
            // 
            // Ventana
            // 
            this.Ventana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VentanaCascada,
            this.VentanaHorizontal,
            this.VentanaVertical});
            this.Ventana.Name = "Ventana";
            this.Ventana.Size = new System.Drawing.Size(59, 20);
            this.Ventana.Text = "Ventana";
            // 
            // VentanaCascada
            // 
            this.VentanaCascada.Name = "VentanaCascada";
            this.VentanaCascada.Size = new System.Drawing.Size(133, 22);
            this.VentanaCascada.Text = "Cascada";
            // 
            // VentanaHorizontal
            // 
            this.VentanaHorizontal.Name = "VentanaHorizontal";
            this.VentanaHorizontal.Size = new System.Drawing.Size(133, 22);
            this.VentanaHorizontal.Text = "Horizontal";
            // 
            // VentanaVertical
            // 
            this.VentanaVertical.Name = "VentanaVertical";
            this.VentanaVertical.Size = new System.Drawing.Size(133, 22);
            this.VentanaVertical.Text = "Vertical";
            // 
            // Ayuda
            // 
            this.Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AyudaAcercade});
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(50, 20);
            this.Ayuda.Text = "Ayuda";
            // 
            // AyudaAcercade
            // 
            this.AyudaAcercade.Name = "AyudaAcercade";
            this.AyudaAcercade.Size = new System.Drawing.Size(145, 22);
            this.AyudaAcercade.Text = "Acerca de...";
            // 
            // FormPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPadre";
            this.Text = "Gestión de Personal";
            this.Load += new System.EventHandler(this.FormPadre_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem ArchivoAlta;
        private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem Ver;
        private System.Windows.Forms.ToolStripMenuItem Ventana;
        private System.Windows.Forms.ToolStripMenuItem Ayuda;
        private System.Windows.Forms.ToolStripMenuItem VerFEmpleado;
        private System.Windows.Forms.ToolStripMenuItem VentanaCascada;
        private System.Windows.Forms.ToolStripMenuItem VentanaHorizontal;
        private System.Windows.Forms.ToolStripMenuItem VentanaVertical;
        private System.Windows.Forms.ToolStripMenuItem ArchivoBaja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem AyudaAcercade;
    }
}

