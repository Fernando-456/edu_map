using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace EDUMAP
{
    internal class Inicio : Form
    {
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowTITULO;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowTITULO = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowTITULO.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.flowTITULO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 628);
            this.panel1.TabIndex = 34;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1071, 530);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 268);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(529, 259);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(538, 268);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(530, 259);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(538, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(530, 259);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(529, 259);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // flowTITULO
            // 
            this.flowTITULO.Controls.Add(this.flowLayoutPanel1);
            this.flowTITULO.Controls.Add(this.label1);
            this.flowTITULO.Controls.Add(this.label2);
            this.flowTITULO.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowTITULO.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTITULO.Location = new System.Drawing.Point(0, 0);
            this.flowTITULO.Name = "flowTITULO";
            this.flowTITULO.Size = new System.Drawing.Size(1071, 98);
            this.flowTITULO.TabIndex = 30;
            this.flowTITULO.Paint += new System.Windows.Forms.PaintEventHandler(this.flowTITULO_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 95);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(387, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 63);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenido a EduMap";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(387, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tu camino a la universidad comienza aquí.";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // Inicio
            // 
            this.ClientSize = new System.Drawing.Size(1071, 628);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowTITULO.ResumeLayout(false);
            this.flowTITULO.PerformLayout();
            this.ResumeLayout(false);

        }
        public Inicio()
        {
            InitializeComponent();
        }
        private void flowTITULO_Paint(object sender, PaintEventArgs e)
        {

        }
        private void abrirForm(Form form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();

        }
        private void pictureBox2_Click(object sender, System.EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new INTERESES());
        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {
            string conexionString = "Server=89.116.159.185;Database=EduMap;Uid=Fernando_BD;Pwd=1209;";

            using (MySqlConnection conexion = new MySqlConnection(conexionString))
            {
                try
                {
                    conexion.Open();

                    // Trae todos los campos de la tabla
                    string query = @"SELECT Usuario, campo_A, campo_E, campo_C, campo_S, campo_D, campo_F, campo_L FROM resultados WHERE Usuario = @Usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Usuario", Global.usuario);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Verificar si todos están vacíos
                            bool todosVacios = true;
                            for (int i = 0; i < 7; i++)
                            {
                                if (!reader.IsDBNull(i) && !string.IsNullOrWhiteSpace(reader.GetString(i)))
                                {
                                    todosVacios = false;
                                    break;
                                }
                            }

                            if (todosVacios)
                            {
                                MessageBox.Show("Necesitas hacer el test.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            // Obtener los valores de cada campo



                            string campoA = reader.IsDBNull(1) ? "" : reader.GetValue(1).ToString();
                            string campoE = reader.IsDBNull(2) ? "" : reader.GetValue(2).ToString();
                            string campoC = reader.IsDBNull(3) ? "" : reader.GetValue(3).ToString();
                            string campoS = reader.IsDBNull(4) ? "" : reader.GetValue(4).ToString();
                            string campoD = reader.IsDBNull(5) ? "" : reader.GetValue(5).ToString();
                            string campoF = reader.IsDBNull(6) ? "" : reader.GetValue(6).ToString();
                            string campoL = reader.IsDBNull(7) ? "" : reader.GetValue(7).ToString();

                            Global.SI_A = int.TryParse(campoA, out int valA) ? valA : 0;
                            Global.SI_E = int.TryParse(campoE, out int valE) ? valE : 0;
                            Global.SI_C = int.TryParse(campoC, out int valC) ? valC : 0;
                            Global.SI_S = int.TryParse(campoS, out int valS) ? valS : 0;
                            Global.SI_D = int.TryParse(campoD, out int valD) ? valD : 0;
                            Global.SI_F = int.TryParse(campoF, out int valF) ? valF : 0;
                            Global.SI_L = int.TryParse(campoL, out int valL) ? valL : 0;

                            // Enviar los valores al Form2
                            flowTITULO.Visible = false;
                            abrirForm(new Resultados());
                        }
                        else
                        {
                            MessageBox.Show("Necesitas realizar el TEST", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new MAPA());
        }
    }
}