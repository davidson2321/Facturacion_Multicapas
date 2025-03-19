namespace Plantilla_Sistema_facturación
{
    partial class frmRolEmpleado
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
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcionRol = new System.Windows.Forms.RichTextBox();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdRolEmpleado = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(54, 220);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(220, 24);
            this.materialLabel4.TabIndex = 42;
            this.materialLabel4.Text = "Descripción detallada rol";
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Location = new System.Drawing.Point(58, 247);
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(326, 96);
            this.txtDescripcionRol.TabIndex = 41;
            this.txtDescripcionRol.Text = "";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(462, 404);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(134, 32);
            this.BtnSalir.TabIndex = 34;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(191, 404);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(134, 32);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Hint = "Nombre Rol ";
            this.txtNombreRol.Location = new System.Drawing.Point(58, 170);
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(306, 28);
            this.txtNombreRol.TabIndex = 28;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // txtIdRolEmpleado
            // 
            this.txtIdRolEmpleado.Location = new System.Drawing.Point(58, 114);
            this.txtIdRolEmpleado.Name = "txtIdRolEmpleado";
            this.txtIdRolEmpleado.Size = new System.Drawing.Size(100, 22);
            this.txtIdRolEmpleado.TabIndex = 27;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(383, 79);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(40, 16);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "Titulo";
            // 
            // frmRolEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtDescripcionRol);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.txtIdRolEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmRolEmpleado";
            this.Text = "frmRolEmpleado";
            this.Load += new System.EventHandler(this.frmRolEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.RichTextBox txtDescripcionRol;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private System.Windows.Forms.TextBox txtIdRolEmpleado;
        private System.Windows.Forms.Label lblTitulo;
    }
}