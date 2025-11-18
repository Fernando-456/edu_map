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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
        }
        
        private void FormResize()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Ajustar el tamaño y la posición de los controles para pantalla maximizada
            }
            else
            {
                // Ajustar el tamaño y la posición de los controles para pantalla normal
            }
        }
       
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            FormResize();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void btnregistro_Click_1(object sender, EventArgs e)
        {
            registro reg = new registro();
            reg.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
