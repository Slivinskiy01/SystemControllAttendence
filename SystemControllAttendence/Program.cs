using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemControllAttendence
{
    static class Program
    {

        internal static AutorizateForm AutorizateForms;
        internal static ManagerEmployee ManagerEmp;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ManagerEmp = new ManagerEmployee();

             Application.Run(AutorizateForms = new AutorizateForm());

           // MessageBox.Show(""+ Environment.CurrentDirectory);
           // Application.Run(new RegisterEnterOutForm());

            //Application.Run(new AddEmployee());
        }
    }
}
