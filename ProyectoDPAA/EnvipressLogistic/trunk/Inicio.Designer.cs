namespace EnvipressLogistic
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.gestiónDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.controlAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPersonal = new System.Windows.Forms.ToolStripMenuItem();
            this.controlFlota = new System.Windows.Forms.ToolStripMenuItem();
            this.incidencias = new System.Windows.Forms.ToolStripMenuItem();
            this.salir = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pboxPrincipal = new System.Windows.Forms.PictureBox();
            this.btAceptarPrincipal = new System.Windows.Forms.Button();
            this.btCancelarPrincipal = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.imgPrincipal = new System.Windows.Forms.PictureBox();
            this.nuevaFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDePedidosToolStripMenuItem,
            this.facturacionPagos,
            this.gestionClientes,
            this.controlAlmacen,
            this.gestionPersonal,
            this.controlFlota,
            this.incidencias,
            this.salir});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(989, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // gestiónDePedidosToolStripMenuItem
            // 
            this.gestiónDePedidosToolStripMenuItem.Name = "gestiónDePedidosToolStripMenuItem";
            this.gestiónDePedidosToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.gestiónDePedidosToolStripMenuItem.Text = "Gestión de Pedidos";
            // 
            // facturacionPagos
            // 
            this.facturacionPagos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaFacturaToolStripMenuItem,
            this.verFacturasToolStripMenuItem});
            this.facturacionPagos.Name = "facturacionPagos";
            this.facturacionPagos.Size = new System.Drawing.Size(116, 20);
            this.facturacionPagos.Text = "Facturación y Pagos";
            // 
            // gestionClientes
            // 
            this.gestionClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarCliente,
            this.listarClientes});
            this.gestionClientes.Name = "gestionClientes";
            this.gestionClientes.Size = new System.Drawing.Size(111, 20);
            this.gestionClientes.Text = "Gestión de Clientes";
            // 
            // buscarCliente
            // 
            this.buscarCliente.Name = "buscarCliente";
            this.buscarCliente.Size = new System.Drawing.Size(153, 22);
            this.buscarCliente.Text = "Buscar Cliente";
            this.buscarCliente.Click += new System.EventHandler(this.buscarCliente_Click);
            // 
            // listarClientes
            // 
            this.listarClientes.Name = "listarClientes";
            this.listarClientes.Size = new System.Drawing.Size(153, 22);
            this.listarClientes.Text = "Listar Clientes";
            // 
            // controlAlmacen
            // 
            this.controlAlmacen.Name = "controlAlmacen";
            this.controlAlmacen.Size = new System.Drawing.Size(112, 20);
            this.controlAlmacen.Text = "Control de Almacén";
            this.controlAlmacen.Click += new System.EventHandler(this.controlAlmacen_Click);
            // 
            // gestionPersonal
            // 
            this.gestionPersonal.Name = "gestionPersonal";
            this.gestionPersonal.Size = new System.Drawing.Size(114, 20);
            this.gestionPersonal.Text = "Gestión de personal";
            this.gestionPersonal.Click += new System.EventHandler(this.gestionPersonal_Click);
            // 
            // controlFlota
            // 
            this.controlFlota.Name = "controlFlota";
            this.controlFlota.Size = new System.Drawing.Size(96, 20);
            this.controlFlota.Text = "Control de Flota";
            // 
            // incidencias
            // 
            this.incidencias.Name = "incidencias";
            this.incidencias.Size = new System.Drawing.Size(72, 20);
            this.incidencias.Text = "Incidencias";
            // 
            // salir
            // 
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(39, 20);
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pboxPrincipal);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 382);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(989, 79);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pboxPrincipal
            // 
            this.pboxPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pboxPrincipal.Image")));
            this.pboxPrincipal.Location = new System.Drawing.Point(784, 14);
            this.pboxPrincipal.Name = "pboxPrincipal";
            this.pboxPrincipal.Size = new System.Drawing.Size(157, 53);
            this.pboxPrincipal.TabIndex = 0;
            this.pboxPrincipal.TabStop = false;
            // 
            // btAceptarPrincipal
            // 
            this.btAceptarPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAceptarPrincipal.Location = new System.Drawing.Point(415, 339);
            this.btAceptarPrincipal.Name = "btAceptarPrincipal";
            this.btAceptarPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btAceptarPrincipal.TabIndex = 2;
            this.btAceptarPrincipal.Text = "Iniciar";
            this.btAceptarPrincipal.UseVisualStyleBackColor = true;
            this.btAceptarPrincipal.Click += new System.EventHandler(this.btAceptarPrincipal_Click);
            // 
            // btCancelarPrincipal
            // 
            this.btCancelarPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancelarPrincipal.Location = new System.Drawing.Point(506, 339);
            this.btCancelarPrincipal.Name = "btCancelarPrincipal";
            this.btCancelarPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btCancelarPrincipal.TabIndex = 3;
            this.btCancelarPrincipal.Text = "Salir";
            this.btCancelarPrincipal.UseVisualStyleBackColor = true;
            this.btCancelarPrincipal.Click += new System.EventHandler(this.btCancelarPrincipal_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lbUsuario.Location = new System.Drawing.Point(412, 267);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Location = new System.Drawing.Point(412, 296);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(481, 264);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(481, 293);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // imgPrincipal
            // 
            this.imgPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("imgPrincipal.Image")));
            this.imgPrincipal.Location = new System.Drawing.Point(171, 27);
            this.imgPrincipal.Name = "imgPrincipal";
            this.imgPrincipal.Size = new System.Drawing.Size(647, 195);
            this.imgPrincipal.TabIndex = 8;
            this.imgPrincipal.TabStop = false;
            // 
            // nuevaFacturaToolStripMenuItem
            // 
            this.nuevaFacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem,
            this.busquedaToolStripMenuItem});
            this.nuevaFacturaToolStripMenuItem.Name = "nuevaFacturaToolStripMenuItem";
            this.nuevaFacturaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevaFacturaToolStripMenuItem.Text = "Nuevo";
            // 
            // verFacturasToolStripMenuItem
            // 
            this.verFacturasToolStripMenuItem.Name = "verFacturasToolStripMenuItem";
            this.verFacturasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verFacturasToolStripMenuItem.Text = "Ver facturas";
            this.verFacturasToolStripMenuItem.Click += new System.EventHandler(this.verFacturasToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.busquedaToolStripMenuItem.Text = "Busqueda";
            this.busquedaToolStripMenuItem.Click += new System.EventHandler(this.busquedaToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(989, 461);
            this.Controls.Add(this.imgPrincipal);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btCancelarPrincipal);
            this.Controls.Add(this.btAceptarPrincipal);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.PictureBox pboxPrincipal;
        private System.Windows.Forms.Button btAceptarPrincipal;
        private System.Windows.Forms.Button btCancelarPrincipal;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox imgPrincipal;
        private System.Windows.Forms.ToolStripMenuItem gestiónDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionPagos;
        private System.Windows.Forms.ToolStripMenuItem gestionClientes;
        private System.Windows.Forms.ToolStripMenuItem controlAlmacen;
        private System.Windows.Forms.ToolStripMenuItem gestionPersonal;
        private System.Windows.Forms.ToolStripMenuItem controlFlota;
        private System.Windows.Forms.ToolStripMenuItem incidencias;
        private System.Windows.Forms.ToolStripMenuItem salir;
        private System.Windows.Forms.ToolStripMenuItem buscarCliente;
        private System.Windows.Forms.ToolStripMenuItem listarClientes;
        private System.Windows.Forms.ToolStripMenuItem nuevaFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturasToolStripMenuItem;
    }
}