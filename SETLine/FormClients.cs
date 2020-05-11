using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SETLine
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            ShowListClients();
            textBoxPhone.MaxLength = 11;
        }
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8 || sym == 127)
            {
                e.Handled = true;
            }
        }
        void ShowListClients()
        {
            listViewClients.Items.Clear();
            foreach (Clients clients in Program.stlBD.Clients)
            {
                ListViewItem item = new ListViewItem(new string[] {
                clients.LastName, clients.FirstName, clients.MiddleName, clients.Phone.ToString()
                });
                item.Tag = clients;
                listViewClients.Items.Add(item);
            }
            listViewClients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text != "" && textBoxFirstName.Text != "" && textBoxMiddleName.Text != "")
            {
                Clients clients = new Clients();
                clients.FirstName = textBoxFirstName.Text;
                clients.LastName = textBoxLastName.Text;
                clients.MiddleName = textBoxMiddleName.Text;
                if (textBoxPhone.Text != "") { clients.Phone = Convert.ToInt64(textBoxPhone.Text); }
                Program.stlBD.Clients.Add(clients);
                Program.stlBD.SaveChanges();
                ShowListClients();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 1)
            {
                if (textBoxLastName.Text != "" && textBoxFirstName.Text != "" && textBoxMiddleName.Text != "")
                {
                    Clients clients = listViewClients.SelectedItems[0].Tag as Clients;
                    clients.FirstName = textBoxFirstName.Text;
                    clients.LastName = textBoxLastName.Text;
                    clients.MiddleName = textBoxMiddleName.Text;
                    if (textBoxPhone.Text != "") { clients.Phone = Convert.ToInt64(textBoxPhone.Text); }
                    Program.stlBD.SaveChanges();
                    ShowListClients();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClients.SelectedItems.Count == 1)
                {
                        Clients clients = listViewClients.SelectedItems[0].Tag as Clients;
                        Program.stlBD.Clients.Remove(clients);
                        Program.stlBD.SaveChanges();
                        ShowListClients();
                }
            }
            catch
            {
                MessageBox.Show("Поле используется", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 1)
            {
                Clients clients = listViewClients.SelectedItems[0].Tag as Clients;
                textBoxLastName.Text = clients.LastName;
                textBoxFirstName.Text = clients.FirstName;
                textBoxMiddleName.Text = clients.MiddleName;
                textBoxPhone.Text = clients.Phone.ToString();
            }
        }
    }
}
