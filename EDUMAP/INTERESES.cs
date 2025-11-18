using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class INTERESES : Form
    {
        public INTERESES()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = E;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = C;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = S;
        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = D;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = L;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = F;
        }

        private void label70_Click(object sender, EventArgs e)
        {

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
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();


        }
        private void button6_Click(object sender, EventArgs e)
        {
            panel36.Visible = false;
            abrirForm(new HABILIDADES());
        }
        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_E += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_E += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_E += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_E += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_E += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_A += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_A += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_A += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_A += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_A += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_C += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }

            }
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_C += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }

            }
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_C += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }

            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_C += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_C += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_S += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_S += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_S += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_S += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_S += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_D += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_D += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_D += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_D += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_D += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton60_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_F += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton58_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_F += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton56_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_F += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton54_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_F += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_F += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton70_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_L += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton68_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_L += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton66_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_L += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton64_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_L += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void radioButton62_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                // Verifica si ya estaba contado antes
                if (!rb.Tag?.ToString().Equals("contado") ?? true)
                {
                    // Aquí sumas al conteo
                    // Ejemplo: conteo++;
                    Global.SI_L += 1;
                    rb.Tag = "contado"; // Marca que ya fue contado
                }
            }
        }

        private void INTERESES_Load(object sender, EventArgs e)
        {

        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
