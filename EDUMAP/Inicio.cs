using Npgsql;
using System;
using System.Linq;
using System.Windows.Forms;
using static EDUMAP.Global;

namespace EDUMAP
{
    internal class Inicio : Form
    {
        private Panel panelControl;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Button button2;
        private Panel panel1;
        private TableLayoutPanel flowTITULO;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panelFONDO;
        

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panelFONDO = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowTITULO = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFONDO.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowTITULO.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFONDO
            // 
            this.panelFONDO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.panelFONDO.Controls.Add(this.panel1);
            this.panelFONDO.Controls.Add(this.panelControl);
            this.panelFONDO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFONDO.Location = new System.Drawing.Point(0, 0);
            this.panelFONDO.Name = "panelFONDO";
            this.panelFONDO.Size = new System.Drawing.Size(1771, 757);
            this.panelFONDO.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.flowTITULO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(322, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 757);
            this.panel1.TabIndex = 37;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1449, 649);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 327);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(718, 319);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(727, 327);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(719, 319);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(727, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(719, 318);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(718, 318);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // flowTITULO
            // 
            this.flowTITULO.ColumnCount = 1;
            this.flowTITULO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flowTITULO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.flowTITULO.Controls.Add(this.label2, 0, 1);
            this.flowTITULO.Controls.Add(this.label1, 0, 0);
            this.flowTITULO.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowTITULO.Location = new System.Drawing.Point(0, 0);
            this.flowTITULO.Name = "flowTITULO";
            this.flowTITULO.RowCount = 2;
            this.flowTITULO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowTITULO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.flowTITULO.Size = new System.Drawing.Size(1449, 108);
            this.flowTITULO.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1443, 54);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tu camino a la universidad comienza aquí.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1443, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bienvenido a EduMap";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.White;
            this.panelControl.Controls.Add(this.iconButton1);
            this.panelControl.Controls.Add(this.iconButton4);
            this.panelControl.Controls.Add(this.button2);
            this.panelControl.Controls.Add(this.pictureBox1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(322, 757);
            this.panelControl.TabIndex = 34;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(118)))), ((int)(((byte)(157)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 282);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(315, 71);
            this.iconButton1.TabIndex = 31;
            this.iconButton1.Text = "Inicio";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(118)))), ((int)(((byte)(157)))));
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(3, 359);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(315, 71);
            this.iconButton4.TabIndex = 32;
            this.iconButton4.Text = "Valoranos";
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(29)))), ((int)(((byte)(75)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 71);
            this.button2.TabIndex = 33;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.ClientSize = new System.Drawing.Size(1771, 757);
            this.Controls.Add(this.panelFONDO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelFONDO.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowTITULO.ResumeLayout(false);
            this.flowTITULO.PerformLayout();
            this.panelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public Inicio()
        {
            InitializeComponent();
            
        }
        
        private Form FormActual = null;

        private void abrirForm(Form form)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }

            FormActual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();

        }
        private void abrirFormMenu(Form form)
        {
            if (FormActual != null)
            {
                FormActual.Close();
            }

            FormActual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelFONDO.Controls.Clear();
            panelFONDO.Controls.Add(form);
            panelFONDO.Tag = form;
            form.BringToFront();
            form.Show();

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.panel1.Controls)
            {
                if (ctrl is Valoranos valoranosForm)
                {
                    valoranosForm.Close();
                    break;
                }
            }

            flowTITULO.Visible = false;
            panelControl.Visible= false;
            abrirFormMenu(new Menu());
        }

        

        private void iconButton4_Click(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new Valoranos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new MENU_TEST());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            panelControl.Visible = false;
            abrirForm(new MAPA());
        }
        private bool CargarResultadosFase1(string usuario)
        {
            using (NpgsqlConnection conexion = Conexion.ConexionDB())
            {
                conexion.Open();

                string query = @"
                SELECT campo_a, campo_c, campo_d, campo_e, campo_f, campo_l, campo_s
                FROM resultados
                WHERE usuario = @usuario";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        Global.PuntajesFase1[0] = reader.IsDBNull(0) ? 0 : Convert.ToInt32(reader[0]); // A
                        Global.PuntajesFase1[1] = reader.IsDBNull(1) ? 0 : Convert.ToInt32(reader[1]); // C
                        Global.PuntajesFase1[2] = reader.IsDBNull(2) ? 0 : Convert.ToInt32(reader[2]); // D
                        Global.PuntajesFase1[3] = reader.IsDBNull(3) ? 0 : Convert.ToInt32(reader[3]); // E
                        Global.PuntajesFase1[4] = reader.IsDBNull(4) ? 0 : Convert.ToInt32(reader[4]); // F
                        Global.PuntajesFase1[5] = reader.IsDBNull(5) ? 0 : Convert.ToInt32(reader[5]); // L
                        Global.PuntajesFase1[6] = reader.IsDBNull(6) ? 0 : Convert.ToInt32(reader[6]); // S

                        return true;
                    }
                }
            }
        }
        private bool CargarResultadosFase2(string usuario)
        {
            using (NpgsqlConnection conexion = Conexion.ConexionDB())
            {
                conexion.Open();

                string query = @"
            SELECT 
                r1,r2,r3,r4,r5,r6,r7,r8,
                r9,r10,r11,r12,r13,r14,r15,r16,
                r17,r18,r19,r20,r21,r22,r23,r24,
                r25,r26,r27,r28,r29,r30,r31,r32
            FROM resultados_fase2
            WHERE usuario = @usuario";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        Global.RespuestasUsuario = new int[32];

                        for (int i = 0; i < 32; i++)
                        {
                            Global.RespuestasUsuario[i] = reader.IsDBNull(i)
                                ? 0
                                : Convert.ToInt32(reader.GetValue(i));
                        }

                        return true;
                    }
                }
            }
        }
        private bool TieneResultadosFase1(string usuario)
        {
            using (NpgsqlConnection conexion = Conexion.ConexionDB())
            {
                conexion.Open();

                string query = "SELECT COUNT(*) FROM resultados WHERE usuario = @usuario";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }
        private bool ResultadosFase1Vacios()
        {
            for (int i = 0; i < Global.PuntajesFase1.Length; i++)
            {
                if (Global.PuntajesFase1[i] != 0)
                    return false;
            }

            return true;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Global.usuario))
                {
                    MessageBox.Show("No hay un usuario activo.");
                    return;
                }

                Global.ReiniciarFase1();

                if (!TieneResultadosFase1(Global.usuario))
                {
                    MessageBox.Show("Primero debes realizar el test.");
                    return;
                }

                if (!CargarResultadosFase1(Global.usuario))
                {
                    MessageBox.Show("No se pudieron cargar los resultados de Fase 1.");
                    return;
                }

                if (ResultadosFase1Vacios())
                {
                    MessageBox.Show("Necesitas hacer el test.");
                    return;
                }

                // ESTA PARTE ES LA QUE FALTABA
                if (!CargarResultadosFase2(Global.usuario))
                {
                    MessageBox.Show("Falta completar la Fase 2 para poder calcular carreras.");
                    return;
                }

                flowTITULO.Visible = false;

                abrirForm(new FASE3());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar resultados: " + ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            flowTITULO.Visible = false;
            abrirForm(new Carreras());
        }
    }
}