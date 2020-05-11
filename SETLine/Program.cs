using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETLine
{
    static class Program
    {
        public static SETLineBDEntities stlBD = new SETLineBDEntities();
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAuthorization());
        }
    }
    public class User
    {
        public string login;
        public string password;
        public string type;
        public int id;
        public User()
        {
        }
        public static User user = new User();
    }
}
