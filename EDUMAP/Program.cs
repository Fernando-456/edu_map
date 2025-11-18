using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDUMAP
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
    
    public static class Global
    {
        public static int SI_A;
        public static int SI_E;
        public static int SI_C;
        public static int SI_S;
        public static int SI_D;
        public static int SI_F;
        public static int SI_L;
        public static string usuario;
        public static Boolean BD;
    }
}
