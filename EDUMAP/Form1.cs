using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EDUMAP
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            OcultarVisualStudio();
        }
        void OcultarVisualStudio()
        {
            // Clases típicas de ventana del IDE
            string[] classNames = {
            "VisualStudioMainWindow",   // VS 2022 / 2019
            "Qt5QWindowIcon",           // VS preview or special skins
            null                        // fallback: buscar por título
        };

            // Intento 1: buscar por clase
            foreach (var className in classNames)
            {
                IntPtr hWnd = FindWindow(className, null);
                if (hWnd != IntPtr.Zero)
                {
                    ShowWindow(hWnd, SW_HIDE);
                    return;
                }
            }

            // Intento 2: búsqueda por título parcial
            Process[] procesos = Process.GetProcesses();
            foreach (var p in procesos)
            {
                try
                {
                    if (p.MainWindowTitle.Contains("Visual Studio"))
                    {
                        ShowWindow(p.MainWindowHandle, SW_HIDE);
                        return;
                    }
                }
                catch { }
            }
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

