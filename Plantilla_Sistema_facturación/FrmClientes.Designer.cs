namespace Plantilla_Sistema_facturación
{
    partial class FrmClientes
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
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(260, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(283, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ADMINISTRACIÓN DE CLIENTES";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "";
            this.txtBuscar.Location = new System.Drawing.Point(44, 152);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(533, 28);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.Text = "Buscar cliente";
            this.txtBuscar.UseSystemPasswordChar = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Location = new System.Drawing.Point(788, 136);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(165, 44);
            this.BtnNuevo.TabIndex = 7;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Location = new System.Drawing.Point(597, 131);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(123, 49);
            this.BtnBuscar.TabIndex = 10;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(788, 474);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(165, 49);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Cliente,
            this.txtNombre,
            this.TxtDocumento,
            this.txtTelefono,
            this.txtDireccion,
            this.txtEmail,
            this.btnEditar,
            this.btnBorrar});
            this.dgClientes.Location = new System.Drawing.Point(44, 204);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(909, 251);
            this.dgClientes.TabIndex = 12;
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
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
            this.txtNombre.HeaderText = "Nombre Cliente";
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
            // txtTelefono
            // 
            this.txtTelefono.HeaderText = "Teléfono";
            this.txtTelefono.MinimumWidth = 6;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Width = 125;
            // 
            // txtDireccion
            // 
            this.txtDireccion.HeaderText = "Dirección";
            this.txtDireccion.MinimumWidth = 6;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Width = 125;
            // 
            // txtEmail
            // 
            this.txtEmail.HeaderText = "Email";
            this.txtEmail.MinimumWidth = 6;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Width = 125;
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
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 591);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.Click += new System.EventHandler(this.BtnNuevo_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxtDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}