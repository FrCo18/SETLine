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
    public partial class FormSales : Form
    {
        public FormSales()
        {
            InitializeComponent();
            ShowComboBoxWorker();
            comboBoxWorker.SelectedIndex = 0;
            ShowOrders();
        }
        void ShowComboBoxWorker()
        {
            comboBoxWorker.Items.Clear();
            foreach (Workers workers in Program.stlBD.Workers)
            {
                if (workers.Type == "Консультант-продавец товаров"|| workers.Type == "Администратор" || workers.Type == "HeadAdmin")
                {
                    string[] item = { workers.Id + ": " + workers.LastName + " " + workers.FirstName[0] + ". " + workers.MiddleName[0] + "." };
                    comboBoxWorker.Items.Add(string.Join(" ", item));
                }
            }
        }
        void ShowOrders()
        {
            listViewOrders.Items.Clear();
            foreach (PlaceOrder order in Program.stlBD.PlaceOrder)
            {
                if (order.IdWorker == Convert.ToInt32(comboBoxWorker.SelectedItem.ToString().Split(':')[0]))
                {
                    ListViewItem item = new ListViewItem(new string[] {
                order.IdWorker.ToString()+ ": "+ order.Workers.LastName+" "+ order.Workers.FirstName[0]+". "+order.Workers.MiddleName[0]+".",
                order.Clients.LastName+" "+order.Clients.FirstName[0]+". "+order.Clients.MiddleName[0]+".",
                order.Inventory.Category, order.Inventory.NameTovar, order.Inventory.Price.ToString()
                });
                    item.Tag = order;
                    listViewOrders.Items.Add(item);
                    listViewOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private void comboBoxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowOrders();
        }
    }
}
