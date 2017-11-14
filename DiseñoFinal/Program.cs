using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace DiseñoFinal
{
    static class Program
    {
        public static string Loginn = "Eber04";
        public static string Departamento = "Contabilidad";
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread] 
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-MX");
            //Application.Run(new Login());
            Application.Run(new MenuContabilidad());
        }
    }
}
