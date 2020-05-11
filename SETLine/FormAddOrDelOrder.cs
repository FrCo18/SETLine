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
    public partial class FormAddOrDelOrder : Form
    {
        public FormAddOrDelOrder()
        {
            InitializeComponent();
            ShowWorker();
            ShowOrders();
            comboBoxType.SelectedIndex = 0;
            ShowComboBoxClient();
        }
        private void KeyPressFalse(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        void ShowOrders()
        {
            listViewOrders.Items.Clear();
            foreach (PlaceOrder order in Program.stlBD.PlaceOrder)
            {
                if (order.IdWorker == Convert.ToInt32(labelWorkerShow.Text.Split(':')[0]))
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
                    string[] item = { clients.Id + ": "+ clients.LastName + " " + clients.FirstName[0] + ". " + clients.MiddleName[0] + "." };
                    comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboBoxTovar()
        {
            comboBoxTovar.Items.Clear();
            foreach (Inventory inventory in Program.stlBD.Inventory)
            {
                string[] item = { inventory.Category };
                comboBoxType.Items.Add(string.Join(" ", item));
            }
        }
        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                PlaceOrder order = listViewOrders.SelectedItems[0].Tag as PlaceOrder;
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(order.IdClient.ToString());
                if (listViewOrders.SelectedItems[0].SubItems[2].Text == "Смартфоны")
                {
                    comboBoxType.SelectedIndex = 1;
                }
                else if (listViewOrders.SelectedItems[0].SubItems[2].Text == "Телефоны")
                {
                    comboBoxType.SelectedIndex = 0;
                }
                else 
                {
                    comboBoxType.SelectedIndex = 2;
                }
                comboBoxTovar.SelectedIndex = comboBoxTovar.FindString(order.IdInventory.ToString());
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                comboBoxTovar.Items.Clear();
                foreach (Inventory inventory in Program.stlBD.Inventory)
                {
                    if (inventory.Category == "Телефоны")
                    {
                        string[] item = { inventory.Id + ": " + inventory.NameTovar, "Цена: " + inventory.Price };
                        comboBoxTovar.Items.Add(string.Join(" ",item));
                    }
                }
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                comboBoxTovar.Items.Clear();
                foreach (Inventory inventory in Program.stlBD.Inventory)
                {
                    if (inventory.Category == "Смартфоны")
                    {
                        string[] item = { inventory.Id + ": " + inventory.NameTovar, "Цена: " + inventory.Price };
                        comboBoxTovar.Items.Add(string.Join(" ", item));
                    }
                }
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                comboBoxTovar.Items.Clear();
                
                foreach (Inventory inventory in Program.stlBD.Inventory)
                {
                    if (inventory.Category == "Периферия")
                    {
                        string[] item = { inventory.Id+": "+ inventory.NameTovar, "Цена: " + inventory.Price };
                        comboBoxTovar.Items.Add(string.Join(" ", item));
                    }
                }
            }
            comboBoxTovar.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxClient.SelectedItem != null && comboBoxType.SelectedItem != null && comboBoxTovar.SelectedItem != null)
            {
                PlaceOrder order = new PlaceOrder();
                Inventory inventory = Program.stlBD.Inventory.Find(Convert.ToInt32(comboBoxTovar.SelectedItem.ToString().Split(':')[0]));
                order.IdWorker = Convert.ToInt32(labelWorkerShow.Text.Split(':')[0]);
                order.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split(':')[0]);
                order.IdInventory = Convert.ToInt32(comboBoxTovar.SelectedItem.ToString().Split(':')[0]);
                if (inventory.Quantity != 0)
                {
                    Program.stlBD.PlaceOrder.Add(order);
                    inventory.Quantity -= 1;
                    Program.stlBD.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Товара нет в наличии!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ShowOrders();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                PlaceOrder order = listViewOrders.SelectedItems[0].Tag as PlaceOrder;
                Inventory inventory = Program.stlBD.Inventory.Find(order.IdInventory);
                inventory.Quantity += 1;
                Program.stlBD.PlaceOrder.Remove(order);
                Program.stlBD.SaveChanges();
                ShowOrders();
            }
        }
    }
}
