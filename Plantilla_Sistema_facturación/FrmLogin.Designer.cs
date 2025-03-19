namespace Plantilla_Sistema_facturación
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtPasword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnValidar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-15, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 454);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.Depth = 0;
            this.Titulo.Hint = "Usuario";
            this.Titulo.Location = new System.Drawing.Point(475, 74);
            this.Titulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.Titulo.Name = "Titulo";
            this.Titulo.PasswordChar = '\0';
            this.Titulo.SelectedText = "";
            this.Titulo.SelectionLength = 0;
            this.Titulo.SelectionStart = 0;
            this.Titulo.Size = new System.Drawing.Size(192, 28);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "VALIDAR USUARIO";
            this.Titulo.UseSystemPasswordChar = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(528, 24);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 24);
            this.lblTitulo.TabIndex = 3;
            // 
            // TxtPasword
            // 
            this.TxtPasword.Depth = 0;
            this.TxtPasword.Hint = "Password";
            this.TxtPasword.Location = new System.Drawing.Point(437, 204);
            this.TxtPasword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPasword.Name = "TxtPasword";
            this.TxtPasword.PasswordChar = '\0';
            this.TxtPasword.SelectedText = "";
            this.TxtPasword.SelectionLength = 0;
            this.TxtPasword.SelectionStart = 0;
            this.TxtPasword.Size = new System.Drawing.Size(315, 28);
            this.TxtPasword.TabIndex = 4;
            this.TxtPasword.UseSystemPasswordChar = false;
            // 
            // btnValidar
            // 
            this.btnValidar.Depth = 0;
            this.btnValidar.Location = new System.Drawing.Point(441, 270);
            this.btnValidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Primary = true;
            this.btnValidar.Size = new System.Drawing.Size(107, 51);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(571, 270);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(118, 51);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Hint = "Usuario";
            this.TxtUsuario.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtUsuario.Location = new System.Drawing.Point(437, 137);
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.Size = new System.Drawing.Size(315, 28);
            this.TxtUsuario.TabIndex = 7;
            this.TxtUsuario.UseSystemPasswordChar = false;
            this.TxtUsuario.Click += new System.EventHandler(this.TxtUsuario_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.TxtPasword);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "Validar Usuario";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Titulo;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPasword;
        private MaterialSkin.Controls.MaterialRaisedButton btnValidar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsuario;
    }
}

