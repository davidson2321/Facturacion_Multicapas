namespace Plantilla_Sistema_facturación
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.Pnlcontenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.salirbtn = new System.Windows.Forms.Button();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablas = new System.Windows.Forms.TabPage();
            this.btncategorias = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.facturación = new System.Windows.Forms.TabPage();
            this.btninformes = new System.Windows.Forms.Button();
            this.btnfacturas = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.btnseguridad = new System.Windows.Forms.Button();
            this.btnroles = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ayuda = new System.Windows.Forms.TabPage();
            this.btnacerca = new System.Windows.Forms.Button();
            this.btnayuda = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.PnlPrincipal.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.TbpMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.facturación.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.Seguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.ayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.Pnlcontenedor);
            this.PnlPrincipal.Controls.Add(this.btnSalir);
            this.PnlPrincipal.Controls.Add(this.PnlMenu);
            this.PnlPrincipal.Location = new System.Drawing.Point(-2, 62);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1204, 591);
            this.PnlPrincipal.TabIndex = 0;
            this.PnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPrincipal_Paint);
            // 
            // Pnlcontenedor
            // 
            this.Pnlcontenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnlcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnlcontenedor.Location = new System.Drawing.Point(200, 0);
            this.Pnlcontenedor.Name = "Pnlcontenedor";
            this.Pnlcontenedor.Size = new System.Drawing.Size(1004, 591);
            this.Pnlcontenedor.TabIndex = 3;
            this.Pnlcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnlcontenedor_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSalir.Location = new System.Drawing.Point(742, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(194, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.TbpMenu);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(200, 591);
            this.PnlMenu.TabIndex = 0;
            // 
            // TbpMenu
            // 
            this.TbpMenu.Controls.Add(this.Principal);
            this.TbpMenu.Controls.Add(this.tablas);
            this.TbpMenu.Controls.Add(this.facturación);
            this.TbpMenu.Controls.Add(this.Seguridad);
            this.TbpMenu.Controls.Add(this.ayuda);
            this.TbpMenu.Depth = 0;
            this.TbpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbpMenu.Location = new System.Drawing.Point(0, 0);
            this.TbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbpMenu.Name = "TbpMenu";
            this.TbpMenu.SelectedIndex = 0;
            this.TbpMenu.Size = new System.Drawing.Size(200, 591);
            this.TbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.SystemColors.Highlight;
            this.Principal.Controls.Add(this.salirbtn);
            this.Principal.Controls.Add(this.materialFlatButton1);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 25);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 562);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            this.Principal.Click += new System.EventHandler(this.Principal_Click);
            // 
            // salirbtn
            // 
            this.salirbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.salirbtn.FlatAppearance.BorderSize = 0;
            this.salirbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.salirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salirbtn.Image = ((System.Drawing.Image)(resources.GetObject("salirbtn.Image")));
            this.salirbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirbtn.Location = new System.Drawing.Point(0, 153);
            this.salirbtn.Name = "salirbtn";
            this.salirbtn.Size = new System.Drawing.Size(196, 45);
            this.salirbtn.TabIndex = 2;
            this.salirbtn.Text = "Salir";
            this.salirbtn.UseVisualStyleBackColor = true;
            this.salirbtn.Click += new System.EventHandler(this.salirbtn_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(29, 170);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(8, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tablas
            // 
            this.tablas.BackColor = System.Drawing.Color.RoyalBlue;
            this.tablas.Controls.Add(this.btncategorias);
            this.tablas.Controls.Add(this.btnproductos);
            this.tablas.Controls.Add(this.btnclientes);
            this.tablas.Controls.Add(this.pictureBox5);
            this.tablas.Location = new System.Drawing.Point(4, 25);
            this.tablas.Name = "tablas";
            this.tablas.Padding = new System.Windows.Forms.Padding(3);
            this.tablas.Size = new System.Drawing.Size(192, 562);
            this.tablas.TabIndex = 1;
            this.tablas.Text = "Tablas";
            this.tablas.Click += new System.EventHandler(this.tablas_Click);
            // 
            // btncategorias
            // 
            this.btncategorias.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncategorias.FlatAppearance.BorderSize = 0;
            this.btncategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btncategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorias.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncategorias.Image = ((System.Drawing.Image)(resources.GetObject("btncategorias.Image")));
            this.btncategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorias.Location = new System.Drawing.Point(-3, 276);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Size = new System.Drawing.Size(196, 45);
            this.btncategorias.TabIndex = 5;
            this.btncategorias.Text = "Categorías";
            this.btncategorias.UseVisualStyleBackColor = true;
            this.btncategorias.Click += new System.EventHandler(this.btncategorias_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnproductos.Image = ((System.Drawing.Image)(resources.GetObject("btnproductos.Image")));
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(-3, 225);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(196, 45);
            this.btnproductos.TabIndex = 4;
            this.btnproductos.Text = "Productos";
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnclientes.FlatAppearance.BorderSize = 0;
            this.btnclientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Location = new System.Drawing.Point(-1, 174);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(196, 45);
            this.btnclientes.TabIndex = 3;
            this.btnclientes.Text = "Clientes";
            this.btnclientes.UseVisualStyleBackColor = true;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(146, 132);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // facturación
            // 
            this.facturación.BackColor = System.Drawing.SystemColors.Highlight;
            this.facturación.Controls.Add(this.btninformes);
            this.facturación.Controls.Add(this.btnfacturas);
            this.facturación.Controls.Add(this.pictureBox6);
            this.facturación.Location = new System.Drawing.Point(4, 25);
            this.facturación.Name = "facturación";
            this.facturación.Padding = new System.Windows.Forms.Padding(3);
            this.facturación.Size = new System.Drawing.Size(192, 562);
            this.facturación.TabIndex = 2;
            this.facturación.Text = "Facturación";
            // 
            // btninformes
            // 
            this.btninformes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btninformes.FlatAppearance.BorderSize = 0;
            this.btninformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btninformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btninformes.Image = ((System.Drawing.Image)(resources.GetObject("btninformes.Image")));
            this.btninformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninformes.Location = new System.Drawing.Point(-2, 259);
            this.btninformes.Name = "btninformes";
            this.btninformes.Size = new System.Drawing.Size(196, 45);
            this.btninformes.TabIndex = 5;
            this.btninformes.Text = "Informes";
            this.btninformes.UseVisualStyleBackColor = true;
            this.btninformes.Click += new System.EventHandler(this.btninformes_Click);
            // 
            // btnfacturas
            // 
            this.btnfacturas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnfacturas.FlatAppearance.BorderSize = 0;
            this.btnfacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnfacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfacturas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnfacturas.Image = ((System.Drawing.Image)(resources.GetObject("btnfacturas.Image")));
            this.btnfacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfacturas.Location = new System.Drawing.Point(3, 176);
            this.btnfacturas.Name = "btnfacturas";
            this.btnfacturas.Size = new System.Drawing.Size(196, 45);
            this.btnfacturas.TabIndex = 3;
            this.btnfacturas.Text = "Facturas";
            this.btnfacturas.UseVisualStyleBackColor = true;
            this.btnfacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(19, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(146, 132);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.SystemColors.Highlight;
            this.Seguridad.Controls.Add(this.btnseguridad);
            this.Seguridad.Controls.Add(this.btnroles);
            this.Seguridad.Controls.Add(this.btnempleados);
            this.Seguridad.Controls.Add(this.pictureBox7);
            this.Seguridad.Location = new System.Drawing.Point(4, 25);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Padding = new System.Windows.Forms.Padding(3);
            this.Seguridad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Seguridad.Size = new System.Drawing.Size(192, 562);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // btnseguridad
            // 
            this.btnseguridad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnseguridad.FlatAppearance.BorderSize = 0;
            this.btnseguridad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnseguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnseguridad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnseguridad.Image = ((System.Drawing.Image)(resources.GetObject("btnseguridad.Image")));
            this.btnseguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnseguridad.Location = new System.Drawing.Point(-3, 308);
            this.btnseguridad.Name = "btnseguridad";
            this.btnseguridad.Size = new System.Drawing.Size(196, 45);
            this.btnseguridad.TabIndex = 5;
            this.btnseguridad.Text = "Seguridad";
            this.btnseguridad.UseVisualStyleBackColor = true;
            this.btnseguridad.Click += new System.EventHandler(this.btnseguridad_Click);
            // 
            // btnroles
            // 
            this.btnroles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnroles.FlatAppearance.BorderSize = 0;
            this.btnroles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnroles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnroles.Image = ((System.Drawing.Image)(resources.GetObject("btnroles.Image")));
            this.btnroles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnroles.Location = new System.Drawing.Point(-4, 246);
            this.btnroles.Name = "btnroles";
            this.btnroles.Size = new System.Drawing.Size(196, 45);
            this.btnroles.TabIndex = 4;
            this.btnroles.Text = "Roles";
            this.btnroles.UseVisualStyleBackColor = true;
            this.btnroles.Click += new System.EventHandler(this.btnRolEmpleados_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnempleados.Image = ((System.Drawing.Image)(resources.GetObject("btnempleados.Image")));
            this.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnempleados.Location = new System.Drawing.Point(-1, 174);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(196, 45);
            this.btnempleados.TabIndex = 3;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.UseVisualStyleBackColor = true;
            this.btnempleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(24, 17);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(146, 132);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // ayuda
            // 
            this.ayuda.BackColor = System.Drawing.SystemColors.Highlight;
            this.ayuda.Controls.Add(this.btnacerca);
            this.ayuda.Controls.Add(this.btnayuda);
            this.ayuda.Controls.Add(this.pictureBox2);
            this.ayuda.Location = new System.Drawing.Point(4, 25);
            this.ayuda.Name = "ayuda";
            this.ayuda.Padding = new System.Windows.Forms.Padding(3);
            this.ayuda.Size = new System.Drawing.Size(192, 562);
            this.ayuda.TabIndex = 4;
            this.ayuda.Text = "Ayuda";
            // 
            // btnacerca
            // 
            this.btnacerca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnacerca.FlatAppearance.BorderSize = 0;
            this.btnacerca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnacerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacerca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnacerca.Image = ((System.Drawing.Image)(resources.GetObject("btnacerca.Image")));
            this.btnacerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnacerca.Location = new System.Drawing.Point(-2, 259);
            this.btnacerca.Name = "btnacerca";
            this.btnacerca.Size = new System.Drawing.Size(196, 45);
            this.btnacerca.TabIndex = 5;
            this.btnacerca.Text = "Acerca de ";
            this.btnacerca.UseVisualStyleBackColor = true;
            // 
            // btnayuda
            // 
            this.btnayuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnayuda.FlatAppearance.BorderSize = 0;
            this.btnayuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayuda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnayuda.Image = ((System.Drawing.Image)(resources.GetObject("btnayuda.Image")));
            this.btnayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnayuda.Location = new System.Drawing.Point(-1, 175);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(196, 45);
            this.btnayuda.TabIndex = 4;
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.UseVisualStyleBackColor = true;
            this.btnayuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tabOpcionesMenu
            // 
            this.tabOpcionesMenu.BaseTabControl = this.TbpMenu;
            this.tabOpcionesMenu.Depth = 0;
            this.tabOpcionesMenu.Location = new System.Drawing.Point(291, 33);
            this.tabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOpcionesMenu.Name = "tabOpcionesMenu";
            this.tabOpcionesMenu.Size = new System.Drawing.Size(911, 23);
            this.tabOpcionesMenu.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabOpcionesMenu);
            this.Controls.Add(this.PnlPrincipal);
            this.Name = "FrmPrincipal";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACIÓN";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.TbpMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tablas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.facturación.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.Seguridad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ayuda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Panel PnlMenu;
        private MaterialSkin.Controls.MaterialTabControl TbpMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage tablas;
        private System.Windows.Forms.TabPage facturación;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage ayuda;
        private MaterialSkin.Controls.MaterialTabSelector tabOpcionesMenu;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel Pnlcontenedor;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button salirbtn;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnfacturas;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btncategorias;
        private System.Windows.Forms.Button btninformes;
        private System.Windows.Forms.Button btnseguridad;
        private System.Windows.Forms.Button btnroles;
        private System.Windows.Forms.Button btnacerca;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}