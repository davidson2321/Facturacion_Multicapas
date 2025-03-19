namespace Plantilla_Sistema_facturación
{
    partial class frmFacturas
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
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.ComboBox();
            this.txtEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstadoFactura = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDetallesFactura = new System.Windows.Forms.RichTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(143, 127);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(188, 22);
            this.txtNumeroFactura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.FormattingEnabled = true;
            this.txtCliente.Location = new System.Drawing.Point(143, 165);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(188, 24);
            this.txtCliente.TabIndex = 3;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.FormattingEnabled = true;
            this.txtEmpleado.Location = new System.Drawing.Point(143, 214);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(188, 24);
            this.txtEmpleado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Empleado";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Hint = "";
            this.txtDescuento.Location = new System.Drawing.Point(35, 265);
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(200, 28);
            this.txtDescuento.TabIndex = 6;
            this.txtDescuento.Text = "Descuento";
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // txtIva
            // 
            this.txtIva.Depth = 0;
            this.txtIva.Hint = "";
            this.txtIva.Location = new System.Drawing.Point(35, 299);
            this.txtIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIva.Name = "txtIva";
            this.txtIva.PasswordChar = '\0';
            this.txtIva.SelectedText = "";
            this.txtIva.SelectionLength = 0;
            this.txtIva.SelectionStart = 0;
            this.txtIva.Size = new System.Drawing.Size(200, 28);
            this.txtIva.TabIndex = 7;
            this.txtIva.Text = "Total IVA";
            this.txtIva.UseSystemPasswordChar = false;
            this.txtIva.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Hint = "";
            this.txtTotalFactura.Location = new System.Drawing.Point(35, 346);
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.Size = new System.Drawing.Size(200, 28);
            this.txtTotalFactura.TabIndex = 8;
            this.txtTotalFactura.Text = "Total Factura";
            this.txtTotalFactura.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Registro";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(572, 160);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(157, 22);
            this.txtFecha.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estado factura";
            // 
            // txtEstadoFactura
            // 
            this.txtEstadoFactura.FormattingEnabled = true;
            this.txtEstadoFactura.Location = new System.Drawing.Point(572, 235);
            this.txtEstadoFactura.Name = "txtEstadoFactura";
            this.txtEstadoFactura.Size = new System.Drawing.Size(188, 24);
            this.txtEstadoFactura.TabIndex = 12;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(824, 160);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(134, 32);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(824, 498);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(134, 32);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Detalle Factura";
            // 
            // txtDetallesFactura
            // 
            this.txtDetallesFactura.Location = new System.Drawing.Point(35, 434);
            this.txtDetallesFactura.Name = "txtDetallesFactura";
            this.txtDetallesFactura.Size = new System.Drawing.Size(751, 96);
            this.txtDetallesFactura.TabIndex = 21;
            this.txtDetallesFactura.Text = "";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(352, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(0, 24);
            this.materialLabel1.TabIndex = 22;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(40, 81);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(135, 75);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(100, 22);
            this.txtIdFactura.TabIndex = 24;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 591);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtDetallesFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtEstadoFactura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroFactura);
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtCliente;
        private System.Windows.Forms.ComboBox txtEmpleado;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIva;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtEstadoFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDetallesFactura;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtIdFactura;
    }
}