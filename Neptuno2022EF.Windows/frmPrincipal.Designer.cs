namespace Neptuno2022EF.Windows
{
    partial class frmPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCiudades = new System.Windows.Forms.Button();
            this.btnPaises = new System.Windows.Forms.Button();
            this.btnCtaCtes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Neptuno SRL";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Neptuno2022EF.Windows.Properties.Resources.shutdown_48px;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(656, 353);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 70);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Image = global::Neptuno2022EF.Windows.Properties.Resources.categorize_50px;
            this.btnCategorias.Location = new System.Drawing.Point(51, 242);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(147, 76);
            this.btnCategorias.TabIndex = 13;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Image = global::Neptuno2022EF.Windows.Properties.Resources.cash_register_50px;
            this.btnVentas.Location = new System.Drawing.Point(584, 242);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(147, 76);
            this.btnVentas.TabIndex = 14;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Image = global::Neptuno2022EF.Windows.Properties.Resources.used_product_50px;
            this.btnProductos.Location = new System.Drawing.Point(416, 242);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(147, 76);
            this.btnProductos.TabIndex = 15;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Image = global::Neptuno2022EF.Windows.Properties.Resources.customer_50px;
            this.btnProveedores.Location = new System.Drawing.Point(233, 242);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(147, 76);
            this.btnProveedores.TabIndex = 16;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::Neptuno2022EF.Windows.Properties.Resources.client_management_50px;
            this.btnClientes.Location = new System.Drawing.Point(416, 125);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(147, 76);
            this.btnClientes.TabIndex = 17;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCiudades
            // 
            this.btnCiudades.Image = global::Neptuno2022EF.Windows.Properties.Resources.city_50px;
            this.btnCiudades.Location = new System.Drawing.Point(233, 125);
            this.btnCiudades.Name = "btnCiudades";
            this.btnCiudades.Size = new System.Drawing.Size(147, 76);
            this.btnCiudades.TabIndex = 18;
            this.btnCiudades.Text = "Ciudades";
            this.btnCiudades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCiudades.UseVisualStyleBackColor = true;
            this.btnCiudades.Click += new System.EventHandler(this.btnCiudades_Click);
            // 
            // btnPaises
            // 
            this.btnPaises.Image = global::Neptuno2022EF.Windows.Properties.Resources.america_50px;
            this.btnPaises.Location = new System.Drawing.Point(51, 125);
            this.btnPaises.Name = "btnPaises";
            this.btnPaises.Size = new System.Drawing.Size(147, 76);
            this.btnPaises.TabIndex = 19;
            this.btnPaises.Text = "Países";
            this.btnPaises.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaises.UseVisualStyleBackColor = true;
            this.btnPaises.Click += new System.EventHandler(this.btnPaises_Click);
            // 
            // btnCtaCtes
            // 
            this.btnCtaCtes.Image = global::Neptuno2022EF.Windows.Properties.Resources.print_32px;
            this.btnCtaCtes.Location = new System.Drawing.Point(584, 125);
            this.btnCtaCtes.Name = "btnCtaCtes";
            this.btnCtaCtes.Size = new System.Drawing.Size(147, 76);
            this.btnCtaCtes.TabIndex = 21;
            this.btnCtaCtes.Text = "Cuentas Corrientes";
            this.btnCtaCtes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCtaCtes.UseVisualStyleBackColor = true;
            this.btnCtaCtes.Click += new System.EventHandler(this.btnCtaCtes_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCtaCtes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCiudades);
            this.Controls.Add(this.btnPaises);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCiudades;
        private System.Windows.Forms.Button btnPaises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCtaCtes;
    }
}

