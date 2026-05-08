namespace EDUMAP
{
    partial class MENU_TEST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU_TEST));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.panelTarjeta = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnComenzar);
            this.panel1.Controls.Add(this.panelTarjeta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1431, 670);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComenzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(118)))), ((int)(((byte)(157)))));
            this.btnComenzar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.ForeColor = System.Drawing.Color.White;
            this.btnComenzar.Location = new System.Drawing.Point(622, 469);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(192, 45);
            this.btnComenzar.TabIndex = 6;
            this.btnComenzar.Text = "Comenzar TEST";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // panelTarjeta
            // 
            this.panelTarjeta.Image = ((System.Drawing.Image)(resources.GetObject("panelTarjeta.Image")));
            this.panelTarjeta.Location = new System.Drawing.Point(296, 98);
            this.panelTarjeta.Name = "panelTarjeta";
            this.panelTarjeta.Size = new System.Drawing.Size(851, 426);
            this.panelTarjeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.panelTarjeta.TabIndex = 8;
            this.panelTarjeta.TabStop = false;
            // 
            // MENU_TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1431, 670);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MENU_TEST";
            this.Text = "MENU_TEST";
            this.Resize += new System.EventHandler(this.MENU_TEST_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTarjeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.PictureBox panelTarjeta;
    }
}