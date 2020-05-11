using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETLine
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            User.user.login = "";
            User.user.password = "";
            User.user.type = "";
            User.user.id = 0;
            Menu menu = new Menu();
            foreach (Workers workers in Program.stlBD.Workers)
            {
                if (textBoxLogin.Text == workers.login && textBoxPassword.Text == workers.password)
                {
                    User.user.login = textBoxLogin.Text;
                    User.user.password = textBoxPassword.Text;
                    User.user.type = workers.Type;
                    User.user.id = workers.Id;
                    menu.Show();
                }
            }
            if (menu.Visible == false)
            {
                MessageBox.Show("Вы ввели не верно логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
