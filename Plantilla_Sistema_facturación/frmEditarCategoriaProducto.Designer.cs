namespace Plantilla_Sistema_facturación
{
    partial class frmEditarCategoriaProducto
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
            this.txtIdCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Depth = 0;
            this.txtIdCategoria.Hint = "";
            this.txtIdCategoria.Location = new System.Drawing.Point(76, 131);
            this.txtIdCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.PasswordChar = '\0';
            this.txtIdCategoria.SelectedText = "";
            this.txtIdCategoria.SelectionLength = 0;
            this.txtIdCategoria.SelectionStart = 0;
            this.txtIdCategoria.Size = new System.Drawing.Size(75, 28);
            this.txtIdCategoria.TabIndex = 0;
            this.txtIdCategoria.UseSystemPasswordChar = false;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Depth = 0;
            this.txtCategoria.Hint = "";
            this.txtCategoria.Location = new System.Drawing.Point(76, 165);
            this.txtCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.SelectionLength = 0;
            this.txtCategoria.SelectionStart = 0;
            this.txtCategoria.Size = new System.Drawing.Size(259, 28);
            this.txtCategoria.TabIndex = 1;
            this.txtCategoria.Text = "Nombre Categoría";
            this.txtCategoria.UseSystemPasswordChar = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(459, 311);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(165, 49);
            this.BtnSalir.TabIndex = 15;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(177, 311);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(165, 49);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Actualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(262, 80);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(241, 24);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "CATEGORÍA DE PRODUCTO";
            // 
            // frmEditarCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtIdCategoria);
            this.Name = "frmEditarCategoriaProducto";
            this.Text = "Editar Categoría";
            this.Load += new System.EventHandler(this.frmEditarCategoriaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
    }
}