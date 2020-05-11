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
    public partial class FormConnectedClients : Form
    {
        public FormConnectedClients()
        {
            InitializeComponent();
            ShowComboBoxWorker();
            comboBoxWorker.SelectedIndex = 0;
            ShowConnects();
        }
        void ShowComboBoxWorker()
        {
            comboBoxWorker.Items.Clear();
            foreach (Workers workers in Program.stlBD.Workers)
            {
                if (workers.Type == "Продавец услуг сотовой связи")
                {
                    string[] item = { workers.Id + ": " + workers.LastName + " " + workers.FirstName[0] + ". " + workers.MiddleName[0] + "." };
                    comboBoxWorker.Items.Add(string.Join(" ", item));
                }
            }
        }
        void ShowConnects()
        {
            listViewConnects.Items.Clear();
            foreach (ConnectedClients connected in Program.stlBD.ConnectedClients)
            {
                if (connected.IdWorkers == Convert.ToInt32(comboBoxWorker.SelectedItem.ToString().Split(':')[0]))
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
        }

        private void comboBoxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowConnects();
        }
    }
}
