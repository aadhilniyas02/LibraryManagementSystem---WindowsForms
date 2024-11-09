using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Project_forms
{
    public class CurrentUser
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }

    internal static class Program
    {
        public static CurrentUser currentUser = new CurrentUser();

        [STAThread]
        static void Main()
        {
            currentUser = null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formWelcome());
        }
    }
}
