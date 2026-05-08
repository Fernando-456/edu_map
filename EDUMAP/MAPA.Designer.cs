namespace EDUMAP
{
    partial class MAPA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.webViewMapa = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelUniversidades = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrivado = new FontAwesome.Sharp.IconButton();
            this.btnPublico = new FontAwesome.Sharp.IconButton();
            this.cmbEntidad = new System.Windows.Forms.ComboBox();
            this.cmbInstitucion = new System.Windows.Forms.ComboBox();
            this.cmbAreaInteres = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewMapa)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webViewMapa);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1438, 536);
            this.panel1.TabIndex = 0;
            // 
            // webViewMapa
            // 
            this.webViewMapa.AllowExternalDrop = true;
            this.webViewMapa.CreationProperties = null;
            this.webViewMapa.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewMapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewMapa.Location = new System.Drawing.Point(550, 0);
            this.webViewMapa.Name = "webViewMapa";
            this.webViewMapa.Size = new System.Drawing.Size(434, 536);
            this.webViewMapa.TabIndex = 2;
            this.webViewMapa.ZoomFactor = 1D;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelUniversidades, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(984, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 536);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "Opciones de Universidades:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelUniversidades
            // 
            this.panelUniversidades.AutoScroll = true;
            this.panelUniversidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUniversidades.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelUniversidades.Location = new System.Drawing.Point(3, 44);
            this.panelUniversidades.Name = "panelUniversidades";
            this.panelUniversidades.Size = new System.Drawing.Size(448, 489);
            this.panelUniversidades.TabIndex = 6;
            this.panelUniversidades.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.cmbEntidad, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbInstitucion, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbAreaInteres, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.53053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.53053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.53053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.53053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.53053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.53053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.53053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.489714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.266065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.53053F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 536);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btnAplicarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicarFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAplicarFiltros.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnAplicarFiltros.Location = new System.Drawing.Point(275, 3);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(266, 49);
            this.btnAplicarFiltros.TabIndex = 24;
            this.btnAplicarFiltros.Text = "Aplicar";
            this.btnAplicarFiltros.UseVisualStyleBackColor = false;
            this.btnAplicarFiltros.Click += new System.EventHandler(this.btnAplicarFiltros_Click_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnPrivado, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnPublico, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 440);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(544, 32);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnPrivado
            // 
            this.btnPrivado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrivado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrivado.IconColor = System.Drawing.Color.Black;
            this.btnPrivado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrivado.Location = new System.Drawing.Point(275, 3);
            this.btnPrivado.Name = "btnPrivado";
            this.btnPrivado.Size = new System.Drawing.Size(266, 26);
            this.btnPrivado.TabIndex = 1;
            this.btnPrivado.Text = "Privada";
            this.btnPrivado.UseVisualStyleBackColor = true;
            this.btnPrivado.Click += new System.EventHandler(this.btnPrivado_Click);
            // 
            // btnPublico
            // 
            this.btnPublico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPublico.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPublico.IconColor = System.Drawing.Color.Black;
            this.btnPublico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPublico.Location = new System.Drawing.Point(3, 3);
            this.btnPublico.Name = "btnPublico";
            this.btnPublico.Size = new System.Drawing.Size(266, 26);
            this.btnPublico.TabIndex = 0;
            this.btnPublico.Text = "Pública";
            this.btnPublico.UseVisualStyleBackColor = true;
            this.btnPublico.Click += new System.EventHandler(this.btnPublico_Click);
            // 
            // cmbEntidad
            // 
            this.cmbEntidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEntidad.BackColor = System.Drawing.Color.White;
            this.cmbEntidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEntidad.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntidad.FormattingEnabled = true;
            this.cmbEntidad.Items.AddRange(new object[] {
            "Aguascalientes",
            "Coahuila"});
            this.cmbEntidad.Location = new System.Drawing.Point(3, 339);
            this.cmbEntidad.Name = "cmbEntidad";
            this.cmbEntidad.Size = new System.Drawing.Size(544, 51);
            this.cmbEntidad.TabIndex = 23;
            this.cmbEntidad.SelectedIndexChanged += new System.EventHandler(this.cmbEntidad_SelectedIndexChanged);
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbInstitucion.BackColor = System.Drawing.Color.White;
            this.cmbInstitucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbInstitucion.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInstitucion.FormattingEnabled = true;
            this.cmbInstitucion.Items.AddRange(new object[] {
            "Aguascalientes",
            "Coahuila"});
            this.cmbInstitucion.Location = new System.Drawing.Point(3, 227);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Size = new System.Drawing.Size(544, 51);
            this.cmbInstitucion.TabIndex = 22;
            this.cmbInstitucion.SelectedIndexChanged += new System.EventHandler(this.cmbInstitucion_SelectedIndexChanged);
            // 
            // cmbAreaInteres
            // 
            this.cmbAreaInteres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAreaInteres.BackColor = System.Drawing.Color.White;
            this.cmbAreaInteres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAreaInteres.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAreaInteres.FormattingEnabled = true;
            this.cmbAreaInteres.Items.AddRange(new object[] {
            "Aguascalientes",
            "Coahuila"});
            this.cmbAreaInteres.Location = new System.Drawing.Point(3, 115);
            this.cmbAreaInteres.Name = "cmbAreaInteres";
            this.cmbAreaInteres.Size = new System.Drawing.Size(544, 51);
            this.cmbAreaInteres.TabIndex = 21;
            this.cmbAreaInteres.SelectedIndexChanged += new System.EventHandler(this.cmbAreaInteres_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(544, 45);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sostenimiento:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(544, 56);
            this.label5.TabIndex = 9;
            this.label5.Text = "Entidad:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(544, 56);
            this.label3.TabIndex = 7;
            this.label3.Text = "Institución:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "Área de Interés:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(544, 56);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "FILTROS";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAplicarFiltros, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 478);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(544, 55);
            this.tableLayoutPanel4.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MAPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1438, 536);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MAPA";
            this.Text = "MAPA";
            this.Load += new System.EventHandler(this.MAPA_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webViewMapa)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMapa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbEntidad;
        private System.Windows.Forms.ComboBox cmbInstitucion;
        private System.Windows.Forms.ComboBox cmbAreaInteres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panelUniversidades;
        private System.Windows.Forms.Button btnAplicarFiltros;
        private FontAwesome.Sharp.IconButton btnPrivado;
        private FontAwesome.Sharp.IconButton btnPublico;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button1;
    }
}