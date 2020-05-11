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
    public partial class FormConnectClient : Form
    {
        public FormConnectClient()
        {
            InitializeComponent();
            ShowComboBoxClient();
            ShowComboBoxRates();
            ShowWorker();
            ShowConnects();
        }
        void ShowWorker()
        {
            Workers workers = Program.stlBD.Workers.Find(User.user.id);
            labelWorkerShow.Text = workers.Id + ": " + workers.LastName + " " + workers.FirstName[0] + ". " + workers.MiddleName[0] + ".";
        }
        void ShowComboBoxClient()
        {
            comboBoxClient.Items.Clear();
            foreach (Clients clients in Program.stlBD.Clients)
            {
                if (clients.Phone != null)
                {
                    string[] item = { clients.Id + ": " + clients.LastName + " " + clients.FirstName[0] + ". " + clients.MiddleName[0] + "." };
                    comboBoxClient.Items.Add(string.Join(" ", item));
                }
            }
        }
        void ShowComboBoxRates()
        {
            comboBoxRates.Items.Clear();
            foreach (Rates rates in Program.stlBD.Rates)
            {
                string[] item = { rates.Id + ": "+ rates.Rate+" "+rates.GB.ToString()+" "+rates.MIN.ToString()+" "+rates.Price.ToString() };
                comboBoxRates.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewConnects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewConnects.SelectedItems.Count == 1)
            {
                ConnectedClients connected = listViewConnects.SelectedItems[0].Tag as ConnectedClients;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(connected.IdClients.ToString());
                comboBoxRates.SelectedIndex = comboBoxRates.FindString(connected.IdRates.ToString());
            }
        }
        void ShowConnects()
        {
            listViewConnects.Items.Clear();
            foreach (ConnectedClients connected in Program.stlBD.ConnectedClients)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    connected.IdWorkers.ToString()+ ": "+ connected.Workers.LastName+" "+connected.Workers.FirstName[0]+". "+connected.Workers.MiddleName[0]+".",
                connected.Clients.LastName+" "+connected.Clients.FirstName[0]+". "+connected.Clients.MiddleName[0]+".",
                connected.Rates.Rate+ " "+connected.Rates.GB+"Гб "+connected.Rates.MIN+"Мин",
                connected.Rates.Price.ToString(), connected.Clients.Phone.ToString()
                });
                item.Tag = connected;
                listViewConnects.Items.Add(item);
                listViewConnects.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && comboBoxRates.SelectedItem != null)
            {
                ConnectedClients connected = new ConnectedClients();
                connected.IdWorkers = Convert.ToInt32(labelWorkerShow.Text.Split(':')[0]);
                connected.IdClients = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split(':')[0]);
                connected.IdRates = Convert.ToInt32(comboBoxRates.SelectedItem.ToString().Split(':')[0]);
                Program.stlBD.ConnectedClients.Add(connected);
                Program.stlBD.SaveChanges();
                ShowConnects();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void KeyPressFalse(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewConnects.SelectedItems.Count == 1)
            {
                if (comboBoxClient.SelectedItem != null && comboBoxRates.SelectedItem != null)
                {
                    ConnectedClients connected = listViewConnects.SelectedItems[0].Tag as ConnectedClients;
                    connected.IdWorkers = Convert.ToInt32(labelWorkerShow.Text.Split(':')[0]);
                    connected.IdClients = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split(':')[0]);
                    connected.IdRates = Convert.ToInt32(comboBoxRates.SelectedItem.ToString().Split(':')[0]);
                    Program.stlBD.SaveChanges();
                    ShowConnects();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewConnects.SelectedItems.Count == 1)
                {
                    ConnectedClients connected = listViewConnects.SelectedItems[0].Tag as ConnectedClients;
                    Program.stlBD.ConnectedClients.Remove(connected);
                    Program.stlBD.SaveChanges();
                    ShowConnects();
                }
            }
            catch
            {
                MessageBox.Show("Поле используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
