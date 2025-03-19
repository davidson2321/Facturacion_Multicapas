namespace Plantilla_Sistema_facturación
{
    partial class frmListFacturas
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
            this.dgFacturas = new System.Windows.Forms.DataGridView();
            this.id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDetallesFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(247, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(291, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "ADMINISTRACIÓN DE FACTURAS";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(12, 140);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(533, 28);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.Text = "Buscar facturas";
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Location = new System.Drawing.Point(595, 119);
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
            this.BtnNuevo.Location = new System.Drawing.Point(792, 119);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(165, 44);
            this.BtnNuevo.TabIndex = 12;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // dgFacturas
            // 
            this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Cliente,
            this.txtNumeroFactura,
            this.TxtCliente,
            this.txtEmpleado,
            this.txtDescuento,
            this.txtIva,
            this.txtTotalFactura,
            this.txtFecha,
            this.txtFactura,
            this.txtDetallesFactura,
            this.btnEditar,
            this.btnBorrar});
            this.dgFacturas.Location = new System.Drawing.Point(12, 189);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.RowHeadersWidth = 51;
            this.dgFacturas.RowTemplate.Height = 24;
            this.dgFacturas.Size = new System.Drawing.Size(909, 251);
            this.dgFacturas.TabIndex = 13;
            this.dgFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturas_CellContentClick);
            // 
            // id_Cliente
            // 
            this.id_Cliente.HeaderText = "ID";
            this.id_Cliente.MinimumWidth = 6;
            this.id_Cliente.Name = "id_Cliente";
            this.id_Cliente.Width = 25;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.HeaderText = "Nro Factura";
            this.txtNumeroFactura.MinimumWidth = 6;
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Width = 125;
            // 
            // TxtCliente
            // 
            this.TxtCliente.HeaderText = "Cliente";
            this.TxtCliente.MinimumWidth = 6;
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Width = 125;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.HeaderText = "Empleado";
            this.txtEmpleado.MinimumWidth = 6;
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Width = 125;
            // 
            // txtDescuento
            // 
            this.txtDescuento.HeaderText = "Descuento";
            this.txtDescuento.MinimumWidth = 6;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Width = 125;
            // 
            // txtIva
            // 
            this.txtIva.HeaderText = "Total Iva";
            this.txtIva.MinimumWidth = 6;
            this.txtIva.Name = "txtIva";
            this.txtIva.Width = 125;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.HeaderText = "Total Factura";
            this.txtTotalFactura.MinimumWidth = 6;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Width = 125;
            // 
            // txtFecha
            // 
            this.txtFecha.HeaderText = "Fecha Registro";
            this.txtFecha.MinimumWidth = 6;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Width = 125;
            // 
            // txtFactura
            // 
            this.txtFactura.HeaderText = "Estado Factura";
            this.txtFactura.MinimumWidth = 6;
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Width = 125;
            // 
            // txtDetallesFactura
            // 
            this.txtDetallesFactura.HeaderText = "Detalle Factura";
            this.txtDetallesFactura.MinimumWidth = 6;
            this.txtDetallesFactura.Name = "txtDetallesFactura";
            this.txtDetallesFactura.Width = 125;
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
            this.BtnSalir.Location = new System.Drawing.Point(806, 466);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(165, 49);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // frmListFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 591);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.dgFacturas);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmListFacturas";
            this.Text = "frmListFacturas";
            this.Load += new System.EventHandler(this.frmListFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private System.Windows.Forms.DataGridView dgFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotalFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDetallesFactura;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}