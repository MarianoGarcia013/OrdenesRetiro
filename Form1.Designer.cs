namespace Ordenes2023
{
    partial class Ordenes
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.lblMateriales = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.cboMateriales = new System.Windows.Forms.ComboBox();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Responsable";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(124, 46);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 2;
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(166, 105);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(310, 26);
            this.txtResponsable.TabIndex = 3;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(307, 151);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(169, 26);
            this.nudCantidad.TabIndex = 50;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(520, 151);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 35);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalle,
            this.Material,
            this.Stock,
            this.Cantidad,
            this.Quitar});
            this.dgvDetalles.Location = new System.Drawing.Point(54, 209);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(1106, 215);
            this.dgvDetalles.TabIndex = 53;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick_1);
            // 
            // lblMateriales
            // 
            this.lblMateriales.AutoSize = true;
            this.lblMateriales.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriales.Location = new System.Drawing.Point(341, 443);
            this.lblMateriales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateriales.Name = "lblMateriales";
            this.lblMateriales.Size = new System.Drawing.Size(223, 29);
            this.lblMateriales.TabIndex = 54;
            this.lblMateriales.Text = "Total de materiales:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(124, 503);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(171, 35);
            this.btnAceptar.TabIndex = 55;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(317, 503);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 35);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboMaterial
            // 
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Items.AddRange(new object[] {
            "1-Comida china",
            "2 Gourmet",
            "3-Empanadas",
            "4-Sandwiches",
            "5-Pizzas"});
            this.cboMaterial.Location = new System.Drawing.Point(54, 149);
            this.cboMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(232, 28);
            this.cboMaterial.TabIndex = 48;
            // 
            // cboMateriales
            // 
            this.cboMateriales.FormattingEnabled = true;
            this.cboMateriales.Location = new System.Drawing.Point(73, 149);
            this.cboMateriales.Name = "cboMateriales";
            this.cboMateriales.Size = new System.Drawing.Size(212, 28);
            this.cboMateriales.TabIndex = 57;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Column1";
            this.detalle.MinimumWidth = 6;
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Visible = false;
            this.detalle.Width = 125;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.MinimumWidth = 6;
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.Width = 125;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 8;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Quitar
            // 
            this.Quitar.HeaderText = "Acciones";
            this.Quitar.MinimumWidth = 8;
            this.Quitar.Name = "Quitar";
            this.Quitar.ReadOnly = true;
            this.Quitar.Text = "Quitar";
            this.Quitar.UseColumnTextForButtonValue = true;
            this.Quitar.Width = 150;
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 617);
            this.Controls.Add(this.cboMateriales);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMateriales);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ordenes";
            this.Text = "Ordenes de Pedidos";
            this.Load += new System.EventHandler(this.Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Label lblMateriales;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.ComboBox cboMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn Quitar;
    }
}

