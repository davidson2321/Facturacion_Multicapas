namespace Plantilla_Sistema_facturación
{
    partial class frmListEmpleados
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
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDatosAdicionales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Cliente,
            this.txtNombre,
            this.TxtDocumento,
            this.txtDireccion,
            this.txtTelefono,
            this.txtEmail,
            this.txtRol,
            this.txtFechaIngreso,
            this.txtFechaRetiro,
            this.txtDatosAdicionales,
            this.btnEditar,
            this.btnBorrar});
            this.dgEmpleados.Location = new System.Drawing.Point(32, 201);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.RowTemplate.Height = 24;
            this.dgEmpleados.Size = new System.Drawing.Size(909, 251);
            this.dgEmpleados.TabIndex = 18;
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellContentClick);
            // 
            // id_Cliente
            // 
            this.id_Cliente.HeaderText = "ID";
            this.id_Cliente.MinimumWidth = 6;
            this.id_Cliente.Name = "id_Cliente";
            this.id_Cliente.Width = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.HeaderText = "Nombre Empleado";
            this.txtNombre.MinimumWidth = 6;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Width = 125;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.HeaderText = "Documento";
            this.TxtDocumento.MinimumWidth = 6;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Width = 125;
            // 
            // txtDireccion
            // 
            this.txtDireccion.HeaderText = "Dirección";
            this.txtDireccion.MinimumWidth = 6;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Width = 125;
            // 
            // txtTelefono
            // 
            this.txtTelefono.HeaderText = "Teléfono";
            this.txtTelefono.MinimumWidth = 6;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Width = 125;
            // 
            // txtEmail
            // 
            this.txtEmail.HeaderText = "Email";
            this.txtEmail.MinimumWidth = 6;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Width = 125;
            // 
            // txtRol
            // 
            this.txtRol.HeaderText = "Rol Empleado";
            this.txtRol.MinimumWidth = 6;
            this.txtRol.Name = "txtRol";
            this.txtRol.Width = 125;
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.HeaderText = "Fecha de ingreso";
            this.txtFechaIngreso.MinimumWidth = 6;
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Width = 125;
            // 
            // txtFechaRetiro
            // 
            this.txtFechaRetiro.HeaderText = "Fecha Retiro";
            this.txtFechaRetiro.MinimumWidth = 6;
            this.txtFechaRetiro.Name = "txtFechaRetiro";
            this.txtFechaRetiro.Width = 125;
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.HeaderText = "Datos Adicionales";
            this.txtDatosAdicionales.MinimumWidth = 6;
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Width = 125;
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
            this.BtnSalir.Location = new System.Drawing.Point(788, 492);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(165, 49);
            this.BtnSalir.TabIndex = 17;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Location = new System.Drawing.Point(584, 124);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(123, 49);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Location = new System.Drawing.Point(805, 126);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(165, 44);
            this.BtnNuevo.TabIndex = 15;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(32, 145);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(533, 28);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.Text = "Buscar Empleado";
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(380, 70);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(307, 24);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // frmListEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 591);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmListEmpleados";
            this.Text = "frmListEmpleados";
            this.Load += new System.EventHandler(this.frmListEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmpleados;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDatosAdicionales;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}