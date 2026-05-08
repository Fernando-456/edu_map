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
            Application.Run(new ANIMACION());
            
        }
    }

    public static class Global
    {
        
        public static int CM_A_T;
        public static int CM_E_T;
        public static int CM_C_T;
        public static int CM_S_T;
        public static int CM_D_T;
        public static int CM_F_T;
        public static int CM_L_T;

        public static string usuario;
        public static string contraseña;
        public static string email;
        public static int id;
        public static int id_estado;
        public static int id_municipio;
        
        // FASE 1
        // 0 = A
        // 1 = C
        // 2 = D
        // 3 = E
        // 4 = F
        // 5 = L
        // 6 = S
        public static int[] PuntajesFase1 = new int[7];

        // =========================
        // FASE 2
        // =========================
        public static int[] Puntajes_Bloque1 = new int[4];
        public static int[] Puntajes_Bloque2 = new int[7];
        public static int[] Puntajes_Bloque3 = new int[7];
        public static int[] Puntajes_Bloque4 = new int[7];
        public static int[] Puntajes_Bloque5 = new int[7];

        // Resultado agregado final de Fase 2
        public static int[] RespuestasUsuario = new int[32];

        public static readonly string[] CodigosCampos = { "A", "C", "D", "E", "F", "L", "S" };

        

        public static void ReiniciarFase1()
        {
            PuntajesFase1 = new int[7];
        }

        public static void ReiniciarFase2()
        {
            Puntajes_Bloque1 = new int[4];
            Puntajes_Bloque2 = new int[7];
            Puntajes_Bloque3 = new int[7];
            Puntajes_Bloque4 = new int[7];
            Puntajes_Bloque5 = new int[7];
            RespuestasUsuario = new int[32];
        }
        public static Dictionary<string, int> ObtenerMapaCamposFase1()
        {
            return new Dictionary<string, int>
        {
            { "A", PuntajesFase1[0] },
            { "C", PuntajesFase1[1] },
            { "D", PuntajesFase1[2] },
            { "E", PuntajesFase1[3] },
            { "F", PuntajesFase1[4] },
            { "L", PuntajesFase1[5] },
            { "S", PuntajesFase1[6] }
        };
        }

        public static int TotalFase1()
        {
            return PuntajesFase1.Sum();
        }



        public static (string campo1, string campo2) ObtenerTop2CamposFase1()
        {
            string[] codigos = { "A", "C", "D", "E", "F", "L", "S" };

            var top2 = PuntajesFase1
                .Select((valor, indice) => new { Valor = valor, Codigo = codigos[indice] })
                .OrderByDescending(x => x.Valor)
                .Take(2)
                .ToList();

            if (top2.Count < 2)
                return ("GENERAL", "GENERAL");

            return (top2[0].Codigo, top2[1].Codigo);
        }
    }
}
