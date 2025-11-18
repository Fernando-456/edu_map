namespace EDUMAP
{
    partial class Tercera_opcion
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbltercera = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1131, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 52);
            this.button2.TabIndex = 51;
            this.button2.Text = "Mostrar resultados";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(52, 156);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1314, 254);
            this.dataGridView2.TabIndex = 50;
            // 
            // lbltercera
            // 
            this.lbltercera.AutoSize = true;
            this.lbltercera.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltercera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.lbltercera.Location = new System.Drawing.Point(429, 55);
            this.lbltercera.Name = "lbltercera";
            this.lbltercera.Size = new System.Drawing.Size(57, 57);
            this.lbltercera.TabIndex = 48;
            this.lbltercera.Text = "A";
            this.lbltercera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltercera.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(52, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 57);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tercera opción:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.panel2.Location = new System.Drawing.Point(416, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 10);
            this.panel2.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbltercera);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 537);
            this.panel1.TabIndex = 53;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 481);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1396, 56);
            this.flowLayoutPanel1.TabIndex = 53;
            // 
            // Tercera_opcion
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1396, 537);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tercera_opcion";
            this.Text = "Tercera_opcion";
            this.Load += new System.EventHandler(this.Tercera_opcion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbltercera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}