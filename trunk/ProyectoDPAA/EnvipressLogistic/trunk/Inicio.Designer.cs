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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pboxPrincipal = new System.Windows.Forms.PictureBox();
            this.btAceptarPrincipal = new System.Windows.Forms.Button();
            this.btCancelarPrincipal = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.imgPrincipal = new System.Windows.Forms.PictureBox();
            this.gestiónDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeAlmacénToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeFlotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.facturaciónToolStripMenuItem,
            this.gestiónDeClientesToolStripMenuItem,
            this.controlDeAlmacénToolStripMenuItem,
            this.gestiónDePersonalToolStripMenuItem,
            this.controlDeFlotaToolStripMenuItem,
            this.incidenciasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(989, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
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
            // gestiónDePersonalToolStripMenuItem
            // 
            this.gestiónDePersonalToolStripMenuItem.Name = "gestiónDePersonalToolStripMenuItem";
            this.gestiónDePersonalToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.gestiónDePersonalToolStripMenuItem.Text = "Gestión de personal";
            this.gestiónDePersonalToolStripMenuItem.Click += new System.EventHandler(this.gestiónDePersonalToolStripMenuItem_Click);
            // 
            // controlDeAlmacénToolStripMenuItem
            // 
            this.controlDeAlmacénToolStripMenuItem.Name = "controlDeAlmacénToolStripMenuItem";
            this.controlDeAlmacénToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.controlDeAlmacénToolStripMenuItem.Text = "Control de Almacén";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación y Pagos";
            // 
            // gestiónDeClientesToolStripMenuItem
            // 
            this.gestiónDeClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarClienteToolStripMenuItem,
            this.listarClientesToolStripMenuItem});
            this.gestiónDeClientesToolStripMenuItem.Name = "gestiónDeClientesToolStripMenuItem";
            this.gestiónDeClientesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestiónDeClientesToolStripMenuItem.Text = "Gestión de Clientes";
            // 
            // incidenciasToolStripMenuItem
            // 
            this.incidenciasToolStripMenuItem.Name = "incidenciasToolStripMenuItem";
            this.incidenciasToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.incidenciasToolStripMenuItem.Text = "Incidencias";
            // 
            // gestiónDePedidosToolStripMenuItem
            // 
            this.gestiónDePedidosToolStripMenuItem.Name = "gestiónDePedidosToolStripMenuItem";
            this.gestiónDePedidosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestiónDePedidosToolStripMenuItem.Text = "Gestión de Pedidos";
            // 
            // controlDeFlotaToolStripMenuItem
            // 
            this.controlDeFlotaToolStripMenuItem.Name = "controlDeFlotaToolStripMenuItem";
            this.controlDeFlotaToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.controlDeFlotaToolStripMenuItem.Text = "Control de Flota";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes";
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeAlmacénToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDePersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeFlotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
    }
}