namespace Plantilla_Sistema_facturación
{
    partial class FrmProductos
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtDetalles = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(349, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(306, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(26, 154);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(533, 28);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.Text = "Buscar producto";
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Location = new System.Drawing.Point(576, 133);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(123, 49);
            this.BtnBuscar.TabIndex = 11;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Location = new System.Drawing.Point(766, 138);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(165, 44);
            this.BtnNuevo.TabIndex = 12;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Producto,
            this.txtProducto,
            this.TxtReferencia,
            this.txtPrecioCompra,
            this.txtPrecioVenta,
            this.txtStok,
            this.txtCategoria,
            this.txtImagen,
            this.txtDetalles,
            this.btnEditar,
            this.btnBorrar});
            this.dgProductos.Location = new System.Drawing.Point(26, 205);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 51;
            this.dgProductos.RowTemplate.Height = 24;
            this.dgProductos.Size = new System.Drawing.Size(946, 251);
            this.dgProductos.TabIndex = 13;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick);
            // 
            // id_Producto
            // 
            this.id_Producto.HeaderText = "ID";
            this.id_Producto.MinimumWidth = 6;
            this.id_Producto.Name = "id_Producto";
            this.id_Producto.Width = 25;
            // 
            // txtProducto
            // 
            this.txtProducto.HeaderText = "Nombre Producto";
            this.txtProducto.MinimumWidth = 6;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Width = 125;
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.HeaderText = "Código Referencia";
            this.TxtReferencia.MinimumWidth = 6;
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Width = 125;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.HeaderText = "Precio Compra";
            this.txtPrecioCompra.MinimumWidth = 6;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Width = 125;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.HeaderText = "Precio Venta";
            this.txtPrecioVenta.MinimumWidth = 6;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Width = 125;
            // 
            // txtStok
            // 
            this.txtStok.HeaderText = "Cantidad Stok";
            this.txtStok.MinimumWidth = 6;
            this.txtStok.Name = "txtStok";
            this.txtStok.Width = 80;
            // 
            // txtCategoria
            // 
            this.txtCategoria.HeaderText = "Categoría";
            this.txtCategoria.MinimumWidth = 6;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Width = 125;
            // 
            // txtImagen
            // 
            this.txtImagen.HeaderText = "Ruta Imagen";
            this.txtImagen.MinimumWidth = 6;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Width = 125;
            // 
            // txtDetalles
            // 
            this.txtDetalles.HeaderText = "Detalles Prodcuto";
            this.txtDetalles.MinimumWidth = 6;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Width = 125;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.MinimumWidth = 6;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "Borrar";
            this.btnBorrar.MinimumWidth = 6;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(770, 492);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(165, 49);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 591);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private System.Windows.Forms.DataGridView dgProductos;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoria;
        private System.Windows.Forms.DataGridViewImageColumn txtImagen;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtDetalles;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}