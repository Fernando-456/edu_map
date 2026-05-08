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
    public partial class MENU_TEST : Form
    {
        public MENU_TEST()
        {
            InitializeComponent();
        }

        private void MENU_TEST_Resize(object sender, EventArgs e)
        {
            panelTarjeta.Left = (this.ClientSize.Width - panelTarjeta.Width) / 2;
            panelTarjeta.Top = (this.ClientSize.Height - panelTarjeta.Height) / 2;

            btnComenzar.Left = (panelTarjeta.Width - btnComenzar.Width) / 2 + 50;
            btnComenzar.Top = panelTarjeta.Height - btnComenzar.Height - 10;

            btnComenzar.FlatStyle = FlatStyle.Flat;
            btnComenzar.FlatAppearance.BorderSize = 0;
            btnComenzar.BackColor = Color.FromArgb(70, 130, 180);
            btnComenzar.ForeColor = Color.White;
            btnComenzar.Cursor = Cursors.Hand;
            btnComenzar.Parent = panelTarjeta;

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
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            abrirForm(new TEST());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTarjeta_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
