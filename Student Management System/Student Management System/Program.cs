using System;
using System.Windows.Forms;

namespace Student_Management_System
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Application starts with login page
            Application.Run(new main_menu());
        }
    }
}