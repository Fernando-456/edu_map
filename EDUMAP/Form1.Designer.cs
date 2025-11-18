namespace EDUMAP
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btninicio = new System.Windows.Forms.Button();
            this.btnregistro = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1165, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(441, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btninicio
            // 
            this.btninicio.AutoEllipsis = true;
            this.btninicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.ForeColor = System.Drawing.Color.White;
            this.btninicio.Location = new System.Drawing.Point(398, 77);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(385, 44);
            this.btninicio.TabIndex = 15;
            this.btninicio.Text = "INICIAR SESION";
            this.btninicio.UseVisualStyleBackColor = false;
            this.btninicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnregistro
            // 
            this.btnregistro.AutoSize = true;
            this.btnregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(126)))), ((int)(((byte)(204)))));
            this.btnregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistro.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.ForeColor = System.Drawing.Color.White;
            this.btnregistro.Location = new System.Drawing.Point(398, 27);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(385, 44);
            this.btnregistro.TabIndex = 16;
            this.btnregistro.Text = "REGISTRO";
            this.btnregistro.UseVisualStyleBackColor = false;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click_1);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 368);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1165, 161);
            this.flowLayoutPanel2.TabIndex = 18;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnregistro);
            this.panel1.Controls.Add(this.btninicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 146);
            this.panel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1165, 529);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
    }
}

