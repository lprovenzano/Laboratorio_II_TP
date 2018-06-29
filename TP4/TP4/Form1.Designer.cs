namespace MainCorreo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listEntregado = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listViaje = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listIngresado = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtID = new System.Windows.Forms.MaskedTextBox();
			this.btnMostrar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.richMostrarTodos = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listEntregado);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.listViaje);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.listIngresado);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(940, 266);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Estados Paquetes";
			// 
			// listEntregado
			// 
			this.listEntregado.ContextMenuStrip = this.contextMenuStrip;
			this.listEntregado.FormattingEnabled = true;
			this.listEntregado.Location = new System.Drawing.Point(646, 49);
			this.listEntregado.Name = "listEntregado";
			this.listEntregado.Size = new System.Drawing.Size(237, 186);
			this.listEntregado.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(643, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Entregado";
			// 
			// listViaje
			// 
			this.listViaje.FormattingEnabled = true;
			this.listViaje.Location = new System.Drawing.Point(341, 49);
			this.listViaje.Name = "listViaje";
			this.listViaje.Size = new System.Drawing.Size(237, 186);
			this.listViaje.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(338, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "En viaje";
			// 
			// listIngresado
			// 
			this.listIngresado.FormattingEnabled = true;
			this.listIngresado.Location = new System.Drawing.Point(43, 49);
			this.listIngresado.Name = "listIngresado";
			this.listIngresado.Size = new System.Drawing.Size(237, 186);
			this.listIngresado.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingresado";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtID);
			this.groupBox2.Controls.Add(this.btnMostrar);
			this.groupBox2.Controls.Add(this.btnAgregar);
			this.groupBox2.Controls.Add(this.txtDireccion);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(590, 297);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(362, 187);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Paquete";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(9, 57);
			this.txtID.Mask = "000-000-0000";
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(203, 20);
			this.txtID.TabIndex = 3;
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(218, 104);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(116, 35);
			this.btnMostrar.TabIndex = 1;
			this.btnMostrar.Text = "Mostrar todos";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(218, 42);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(116, 35);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(6, 112);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(206, 20);
			this.txtDireccion.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Dirección";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tracking ID";
			// 
			// richMostrarTodos
			// 
			this.richMostrarTodos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richMostrarTodos.Location = new System.Drawing.Point(13, 297);
			this.richMostrarTodos.Name = "richMostrarTodos";
			this.richMostrarTodos.ReadOnly = true;
			this.richMostrarTodos.Size = new System.Drawing.Size(571, 187);
			this.richMostrarTodos.TabIndex = 2;
			this.richMostrarTodos.Text = "";
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.Size = new System.Drawing.Size(116, 26);
			this.contextMenuStrip.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
			// 
			// mostrarToolStripMenuItem
			// 
			this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
			this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.mostrarToolStripMenuItem.Text = "Mostrar";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(964, 496);
			this.Controls.Add(this.richMostrarTodos);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(980, 535);
			this.MinimumSize = new System.Drawing.Size(980, 535);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Luca.Provenzano.2C";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listEntregado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listViaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listIngresado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richMostrarTodos;
        private System.Windows.Forms.MaskedTextBox txtID;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
	}
}

