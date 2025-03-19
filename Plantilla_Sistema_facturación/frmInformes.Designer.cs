namespace Plantilla_Sistema_facturación
{
    partial class frmInformes
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSelectInforme = new System.Windows.Forms.ComboBox();
            this.txtOrdernar = new System.Windows.Forms.ComboBox();
            this.txtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDetallesInforme = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(323, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(395, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "GENRADOR DE INFORMES DE FACTURACIÓN";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(64, 148);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(173, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Seleccione Informe";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtSelectInforme
            // 
            this.txtSelectInforme.FormattingEnabled = true;
            this.txtSelectInforme.Location = new System.Drawing.Point(276, 148);
            this.txtSelectInforme.Name = "txtSelectInforme";
            this.txtSelectInforme.Size = new System.Drawing.Size(188, 24);
            this.txtSelectInforme.TabIndex = 4;
            // 
            // txtOrdernar
            // 
            this.txtOrdernar.FormattingEnabled = true;
            this.txtOrdernar.Location = new System.Drawing.Point(696, 148);
            this.txtOrdernar.Name = "txtOrdernar";
            this.txtOrdernar.Size = new System.Drawing.Size(188, 24);
            this.txtOrdernar.TabIndex = 5;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(276, 207);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(157, 22);
            this.txtFechaInicio.TabIndex = 11;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(64, 207);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(112, 24);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Fecha inicio";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(557, 207);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(112, 24);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Fecha inicio";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(717, 207);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(157, 22);
            this.txtFechaFin.TabIndex = 14;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(557, 146);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(120, 24);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Ordernar por ";
            // 
            // txtPantalla
            // 
            this.txtPantalla.AutoSize = true;
            this.txtPantalla.Depth = 0;
            this.txtPantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtPantalla.Location = new System.Drawing.Point(276, 288);
            this.txtPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.txtPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.txtPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Ripple = true;
            this.txtPantalla.Size = new System.Drawing.Size(115, 30);
            this.txtPantalla.TabIndex = 16;
            this.txtPantalla.TabStop = true;
            this.txtPantalla.Text = "En pantalla";
            this.txtPantalla.UseVisualStyleBackColor = true;
            // 
            // txtPdf
            // 
            this.txtPdf.AutoSize = true;
            this.txtPdf.Depth = 0;
            this.txtPdf.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtPdf.Location = new System.Drawing.Point(487, 288);
            this.txtPdf.Margin = new System.Windows.Forms.Padding(0);
            this.txtPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.txtPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPdf.Name = "txtPdf";
            this.txtPdf.Ripple = true;
            this.txtPdf.Size = new System.Drawing.Size(57, 30);
            this.txtPdf.TabIndex = 17;
            this.txtPdf.TabStop = true;
            this.txtPdf.Text = "Pdf";
            this.txtPdf.UseVisualStyleBackColor = true;
            // 
            // txtExcel
            // 
            this.txtExcel.AutoSize = true;
            this.txtExcel.Depth = 0;
            this.txtExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtExcel.Location = new System.Drawing.Point(668, 288);
            this.txtExcel.Margin = new System.Windows.Forms.Padding(0);
            this.txtExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.txtExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtExcel.Name = "txtExcel";
            this.txtExcel.Ripple = true;
            this.txtExcel.Size = new System.Drawing.Size(71, 30);
            this.txtExcel.TabIndex = 18;
            this.txtExcel.TabStop = true;
            this.txtExcel.Text = "Excel";
            this.txtExcel.UseVisualStyleBackColor = true;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Depth = 0;
            this.btnGenerarInforme.Location = new System.Drawing.Point(257, 380);
            this.btnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Primary = true;
            this.btnGenerarInforme.Size = new System.Drawing.Size(214, 32);
            this.btnGenerarInforme.TabIndex = 19;
            this.btnGenerarInforme.Text = "Generar Informe";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Location = new System.Drawing.Point(543, 380);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(134, 32);
            this.BtnSalir.TabIndex = 20;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtDetallesInforme
            // 
            this.txtDetallesInforme.Location = new System.Drawing.Point(133, 452);
            this.txtDetallesInforme.Name = "txtDetallesInforme";
            this.txtDetallesInforme.Size = new System.Drawing.Size(751, 96);
            this.txtDetallesInforme.TabIndex = 22;
            this.txtDetallesInforme.Text = "";
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 591);
            this.Controls.Add(this.txtDetallesInforme);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.txtExcel);
            this.Controls.Add(this.txtPdf);
            this.Controls.Add(this.txtPantalla);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtFechaFin);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtFechaInicio);
            this.Controls.Add(this.txtOrdernar);
            this.Controls.Add(this.txtSelectInforme);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.Load += new System.EventHandler(this.frmInformes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox txtSelectInforme;
        private System.Windows.Forms.ComboBox txtOrdernar;
        private System.Windows.Forms.DateTimePicker txtFechaInicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker txtFechaFin;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRadioButton txtPantalla;
        private MaterialSkin.Controls.MaterialRadioButton txtPdf;
        private MaterialSkin.Controls.MaterialRadioButton txtExcel;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private System.Windows.Forms.RichTextBox txtDetallesInforme;
    }
}