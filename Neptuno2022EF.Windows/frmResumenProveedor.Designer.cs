namespace Neptuno2022EF.Windows
{
    partial class frmResumenProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DetallePanel = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalesPanel = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.EncabezadoPanel = new System.Windows.Forms.Panel();
            this.DetallePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.TotalesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetallePanel
            // 
            this.DetallePanel.Controls.Add(this.dgvDatos);
            this.DetallePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetallePanel.Location = new System.Drawing.Point(0, 25);
            this.DetallePanel.Name = "DetallePanel";
            this.DetallePanel.Size = new System.Drawing.Size(800, 350);
            this.DetallePanel.TabIndex = 11;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colCantProductos});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(800, 350);
            this.dgvDatos.TabIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Razon Social";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colCantProductos
            // 
            this.colCantProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCantProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCantProductos.HeaderText = "Cant. Productos";
            this.colCantProductos.Name = "colCantProductos";
            this.colCantProductos.ReadOnly = true;
            this.colCantProductos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TotalesPanel
            // 
            this.TotalesPanel.Controls.Add(this.btnCerrar);
            this.TotalesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalesPanel.Location = new System.Drawing.Point(0, 375);
            this.TotalesPanel.Name = "TotalesPanel";
            this.TotalesPanel.Size = new System.Drawing.Size(800, 75);
            this.TotalesPanel.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Neptuno2022EF.Windows.Properties.Resources.cancel_24px;
            this.btnCerrar.Location = new System.Drawing.Point(694, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 51);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // EncabezadoPanel
            // 
            this.EncabezadoPanel.BackColor = System.Drawing.Color.LightGray;
            this.EncabezadoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EncabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.EncabezadoPanel.Name = "EncabezadoPanel";
            this.EncabezadoPanel.Size = new System.Drawing.Size(800, 25);
            this.EncabezadoPanel.TabIndex = 9;
            // 
            // frmResumenProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetallePanel);
            this.Controls.Add(this.TotalesPanel);
            this.Controls.Add(this.EncabezadoPanel);
            this.Name = "frmResumenProveedor";
            this.Text = "frmResumenProveedor";
            this.Load += new System.EventHandler(this.frmResumenProveedor_Load);
            this.DetallePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.TotalesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DetallePanel;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel TotalesPanel;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel EncabezadoPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantProductos;
    }
}