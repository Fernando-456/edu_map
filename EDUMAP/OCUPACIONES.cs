using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class OCUPACIONES : Form
    {
        public OCUPACIONES()
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
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();


        }
        private void L_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = E;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = C;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = S;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = D;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = F;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = L;
        }

        private void radioButton10_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton20_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton18_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton16_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton14_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton12_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton30_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton28_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton26_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton24_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton22_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton40_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton38_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton36_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton34_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton32_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton50_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton48_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton46_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton44_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton42_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton60_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton58_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton56_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton54_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton52_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton70_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton68_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton66_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton64_CheckedChanged_1(object sender, EventArgs e)
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

        private void radioButton62_CheckedChanged_1(object sender, EventArgs e)
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

        private void button6_Click_1(object sender, EventArgs e)
        {
            panel45.Visible = false;
            abrirForm(new Resultados());
        }

        private void panel45_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
