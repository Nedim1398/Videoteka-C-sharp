using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Prijava());
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data source=DEVELOPER01N\\SQLExpress;Initial catalog=Nedim; User=nedims ;Password=nedims");
        }

        public static class MyGlobals
        {
            public static string Logged;
        }
    }
    public static class MyGlobals
    {
        public static string Logged;
        public static string PopupGlobal;
    }
}
