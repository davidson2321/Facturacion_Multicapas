namespace Plantilla_Sistema_facturación
{
    partial class frmEditarProducto
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.txtImagen = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDetalles = new System.Windows.Forms.RichTextBox();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.txtImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(97, 91);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(100, 126);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 22);
            this.txtIdProducto.TabIndex = 2;
            // 
            // txtProducto
            // 
            this.txtProducto.Depth = 0;
            this.txtProducto.Hint = "Nombre Producto";
            this.txtProducto.Location = new System.Drawing.Point(100, 173);
            this.txtProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.PasswordChar = '\0';
            this.txtProducto.SelectedText = "";
            this.txtProducto.SelectionLength = 0;
            this.txtProducto.SelectionStart = 0;
            this.txtProducto.Size = new System.Drawing.Size(525, 28);
            this.txtProducto.TabIndex = 3;
            this.txtProducto.UseSystemPasswordChar = false;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Depth = 0;
            this.txtReferencia.Hint = "Código Referencia";
            this.txtReferencia.Location = new System.Drawing.Point(100, 207);
            this.txtReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.PasswordChar = '\0';
            this.txtReferencia.SelectedText = "";
            this.txtReferencia.SelectionLength = 0;
            this.txtReferencia.SelectionStart = 0;
            this.txtReferencia.Size = new System.Drawing.Size(525, 28);
            this.txtReferencia.TabIndex = 4;
            this.txtReferencia.UseSystemPasswordChar = false;
            this.txtReferencia.Click += new System.EventHandler(this.txtReferencia_Click);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "Precio Compra";
            this.txtPrecioCompra.Location = new System.Drawing.Point(100, 241);
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(525, 28);
            this.txtPrecioCompra.TabIndex = 5;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Precio Compra";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(100, 275);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(525, 28);
            this.materialSingleLineTextField1.TabIndex = 6;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Hint = "Precio venta";
            this.txtPrecioVenta.Location = new System.Drawing.Point(100, 309);
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(525, 28);
            this.txtPrecioVenta.TabIndex = 7;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtStock
            // 
            this.txtStock.Depth = 0;
            this.txtStock.Hint = "Cantidad Stock";
            this.txtStock.Location = new System.Drawing.Point(100, 343);
            this.txtStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.Size = new System.Drawing.Size(525, 28);
            this.txtStock.TabIndex = 8;
            this.txtStock.UseSystemPasswordChar = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(239, 406);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(134, 32);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(442, 406);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(134, 32);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Location = new System.Drawing.Point(804, 173);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(121, 24);
            this.txtCategoria.TabIndex = 11;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(825, 219);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 50);
            this.txtImagen.TabIndex = 16;
            this.txtImagen.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(698, 241);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 24);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Ruta Imagen ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(698, 171);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(91, 24);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "Categoría";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(702, 322);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(223, 96);
            this.txtDetalles.TabIndex = 20;
            this.txtDetalles.Text = "";
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(702, 288);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(164, 28);
            this.materialSingleLineTextField2.TabIndex = 21;
            this.materialSingleLineTextField2.Text = "Detalles producto";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // frmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmEditarProducto";
            this.Text = "frmEditarProducto";
            this.Load += new System.EventHandler(this.frmEditarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtIdProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStock;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private System.Windows.Forms.ComboBox txtCategoria;
        private System.Windows.Forms.PictureBox txtImagen;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.RichTextBox txtDetalles;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
    }
}