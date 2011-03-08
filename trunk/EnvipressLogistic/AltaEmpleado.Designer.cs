namespace EnvipressLogistic
{
    partial class AltaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaEmpleado));
            this.menuAltaEmpleado = new System.Windows.Forms.MenuStrip();
            this.ArchivoEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CortarAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.CopiarAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.PegarAlta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAltaEmpleado = new System.Windows.Forms.Label();
            this.gbAltaEmpleado = new System.Windows.Forms.GroupBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbApellido2 = new System.Windows.Forms.Label();
            this.lbApellido1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbDni = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbSegSocial = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuAltaEmpleado.SuspendLayout();
            this.gbAltaEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAltaEmpleado
            // 
            this.menuAltaEmpleado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuAltaEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoEmpleado,
            this.ediciónToolStripMenuItem});
            this.menuAltaEmpleado.Location = new System.Drawing.Point(0, 0);
            this.menuAltaEmpleado.Name = "menuAltaEmpleado";
            this.menuAltaEmpleado.Size = new System.Drawing.Size(686, 24);
            this.menuAltaEmpleado.TabIndex = 0;
            this.menuAltaEmpleado.Text = "menuStrip1";
            this.menuAltaEmpleado.Visible = false;
            // 
            // ArchivoEmpleado
            // 
            this.ArchivoEmpleado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarDatosToolStripMenuItem});
            this.ArchivoEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.ArchivoEmpleado.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ArchivoEmpleado.Name = "ArchivoEmpleado";
            this.ArchivoEmpleado.Size = new System.Drawing.Size(60, 20);
            this.ArchivoEmpleado.Text = "Archivo";
            // 
            // limpiarDatosToolStripMenuItem
            // 
            this.limpiarDatosToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.limpiarDatosToolStripMenuItem.MergeIndex = 1;
            this.limpiarDatosToolStripMenuItem.Name = "limpiarDatosToolStripMenuItem";
            this.limpiarDatosToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.limpiarDatosToolStripMenuItem.Text = "Limpiar datos";
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CortarAlta,
            this.CopiarAlta,
            this.PegarAlta,
            this.toolStripSeparator1,
            this.deshacerToolStripMenuItem,
            this.rehacerToolStripMenuItem});
            this.ediciónToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.ediciónToolStripMenuItem.MergeIndex = 1;
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // CortarAlta
            // 
            this.CortarAlta.Name = "CortarAlta";
            this.CortarAlta.Size = new System.Drawing.Size(122, 22);
            this.CortarAlta.Text = "Cortar";
            this.CortarAlta.Click += new System.EventHandler(this.CortarAlta_Click);
            // 
            // CopiarAlta
            // 
            this.CopiarAlta.Name = "CopiarAlta";
            this.CopiarAlta.Size = new System.Drawing.Size(122, 22);
            this.CopiarAlta.Text = "Copiar";
            this.CopiarAlta.Click += new System.EventHandler(this.CopiarAlta_Click);
            // 
            // PegarAlta
            // 
            this.PegarAlta.Name = "PegarAlta";
            this.PegarAlta.Size = new System.Drawing.Size(122, 22);
            this.PegarAlta.Text = "Pegar";
            this.PegarAlta.Click += new System.EventHandler(this.PegarAlta_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.deshacerToolStripMenuItem.Text = "Deshacer";
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.rehacerToolStripMenuItem.Text = "Rehacer";
            // 
            // lbAltaEmpleado
            // 
            this.lbAltaEmpleado.AutoSize = true;
            this.lbAltaEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lbAltaEmpleado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltaEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbAltaEmpleado.Location = new System.Drawing.Point(13, 13);
            this.lbAltaEmpleado.Name = "lbAltaEmpleado";
            this.lbAltaEmpleado.Size = new System.Drawing.Size(292, 33);
            this.lbAltaEmpleado.TabIndex = 1;
            this.lbAltaEmpleado.Text = "NUEVO EMPLEADO";
            // 
            // gbAltaEmpleado
            // 
            this.gbAltaEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAltaEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.gbAltaEmpleado.Controls.Add(this.comboBox1);
            this.gbAltaEmpleado.Controls.Add(this.lbEstadoCivil);
            this.gbAltaEmpleado.Controls.Add(this.textBox2);
            this.gbAltaEmpleado.Controls.Add(this.lbSegSocial);
            this.gbAltaEmpleado.Controls.Add(this.textBox1);
            this.gbAltaEmpleado.Controls.Add(this.lbDni);
            this.gbAltaEmpleado.Controls.Add(this.txtApellido2);
            this.gbAltaEmpleado.Controls.Add(this.txtApellido1);
            this.gbAltaEmpleado.Controls.Add(this.txtNombre);
            this.gbAltaEmpleado.Controls.Add(this.lbApellido2);
            this.gbAltaEmpleado.Controls.Add(this.lbApellido1);
            this.gbAltaEmpleado.Controls.Add(this.lbNombre);
            this.gbAltaEmpleado.Location = new System.Drawing.Point(12, 49);
            this.gbAltaEmpleado.Name = "gbAltaEmpleado";
            this.gbAltaEmpleado.Size = new System.Drawing.Size(1003, 342);
            this.gbAltaEmpleado.TabIndex = 2;
            this.gbAltaEmpleado.TabStop = false;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(171, 102);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(181, 20);
            this.txtApellido2.TabIndex = 5;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(171, 68);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(181, 20);
            this.txtApellido1.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(171, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lbApellido2
            // 
            this.lbApellido2.AutoSize = true;
            this.lbApellido2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido2.Location = new System.Drawing.Point(39, 102);
            this.lbApellido2.Name = "lbApellido2";
            this.lbApellido2.Size = new System.Drawing.Size(92, 15);
            this.lbApellido2.TabIndex = 2;
            this.lbApellido2.Text = "APELLIDO 2 :";
            // 
            // lbApellido1
            // 
            this.lbApellido1.AutoSize = true;
            this.lbApellido1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido1.Location = new System.Drawing.Point(39, 68);
            this.lbApellido1.Name = "lbApellido1";
            this.lbApellido1.Size = new System.Drawing.Size(92, 15);
            this.lbApellido1.TabIndex = 1;
            this.lbApellido1.Text = "APELLIDO 1 :";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(39, 34);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(72, 15);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "NOMBRE :";
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAceptar.Location = new System.Drawing.Point(859, 397);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(940, 397);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(42, 137);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(38, 15);
            this.lbDni.TabIndex = 6;
            this.lbDni.Text = "DNI :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 7;
            // 
            // lbSegSocial
            // 
            this.lbSegSocial.AutoSize = true;
            this.lbSegSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegSocial.Location = new System.Drawing.Point(42, 174);
            this.lbSegSocial.Name = "lbSegSocial";
            this.lbSegSocial.Size = new System.Drawing.Size(117, 15);
            this.lbSegSocial.TabIndex = 8;
            this.lbSegSocial.Text = "Nº SEG. SOCIAL :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 9;
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoCivil.Location = new System.Drawing.Point(42, 209);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(107, 15);
            this.lbEstadoCivil.TabIndex = 10;
            this.lbEstadoCivil.Text = "ESTADO CIVIL :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // AltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1027, 428);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.gbAltaEmpleado);
            this.Controls.Add(this.lbAltaEmpleado);
            this.Controls.Add(this.menuAltaEmpleado);
            this.MainMenuStrip = this.menuAltaEmpleado;
            this.Name = "AltaEmpleado";
            this.Text = "AltaEmpleado";
            this.menuAltaEmpleado.ResumeLayout(false);
            this.menuAltaEmpleado.PerformLayout();
            this.gbAltaEmpleado.ResumeLayout(false);
            this.gbAltaEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAltaEmpleado;
        private System.Windows.Forms.ToolStripMenuItem ArchivoEmpleado;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CortarAlta;
        private System.Windows.Forms.ToolStripMenuItem CopiarAlta;
        private System.Windows.Forms.ToolStripMenuItem PegarAlta;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lbAltaEmpleado;
        private System.Windows.Forms.GroupBox gbAltaEmpleado;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbApellido2;
        private System.Windows.Forms.Label lbApellido1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbSegSocial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDni;
    }
}