namespace EDUMAP
{
    partial class Primera_opcion
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblprimera = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 57);
            this.label1.TabIndex = 20;
            this.label1.Text = "Primera opción:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.panel2.Location = new System.Drawing.Point(426, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 10);
            this.panel2.TabIndex = 21;
            // 
            // lblprimera
            // 
            this.lblprimera.AutoSize = true;
            this.lblprimera.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprimera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.lblprimera.Location = new System.Drawing.Point(428, 47);
            this.lblprimera.Name = "lblprimera";
            this.lblprimera.Size = new System.Drawing.Size(57, 57);
            this.lblprimera.TabIndex = 31;
            this.lblprimera.Text = "A";
            this.lblprimera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblprimera.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1043, 3);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(262, 52);
            this.button1.TabIndex = 38;
            this.button1.Text = "Mostrar más opciones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(55, 132);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1194, 262);
            this.dataGridView2.TabIndex = 40;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(775, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 52);
            this.button2.TabIndex = 41;
            this.button2.Text = "Mostrar resultados";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblprimera);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 493);
            this.panel1.TabIndex = 42;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 436);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1308, 57);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // Primera_opcion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1308, 493);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Primera_opcion";
            this.Text = "Primera_opcion";
            this.Load += new System.EventHandler(this.Primera_opcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblprimera;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}