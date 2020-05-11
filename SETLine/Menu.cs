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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            FormWorkers formWorkers = new FormWorkers();
            formWorkers.Show();
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            FormClients formClients = new FormClients();
            formClients.Show();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            FormInventory formInventory = new FormInventory();
            formInventory.Show();
        }

        private void buttonRates_Click(object sender, EventArgs e)
        {
            FormRates formRates = new FormRates();
            formRates.Show();
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            FormAddOrDelOrder formAddOrDelOrder = new FormAddOrDelOrder();
            formAddOrDelOrder.Show();
        }

        private void buttonConnectClient_Click(object sender, EventArgs e)
        {
            FormConnectClient formConnect = new FormConnectClient();
            formConnect.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (User.user.type != "HeadAdmin" && User.user.type != "Администратор")
            {
                buttonInventory.Enabled = false;
                buttonWorkers.Enabled = false;
                buttonConnectedClients.Enabled = false;
                buttonSales.Enabled = false;
            }
            else
            {
                buttonInventory.Enabled = true;
                buttonWorkers.Enabled = true;
                buttonConnectedClients.Enabled = true;
                buttonSales.Enabled = true;
            }
            if (User.user.type != "HeadAdmin" && User.user.type != "Администратор" && User.user.type != "Продавец услуг сотовой связи")
            {
                buttonConnectClient.Enabled = false;
                buttonRates.Enabled = false;
            }
            else
            {
                buttonConnectClient.Enabled = true;
                buttonRates.Enabled = true;
            }
            if (User.user.type != "HeadAdmin" && User.user.type != "Администратор" && User.user.type != "Консультант-продавец товаров")
            {
                buttonInventory.Enabled = false;
                buttonAddOrDelOrder.Enabled = false;
            }
            else
            {
                buttonInventory.Enabled = true;
                buttonAddOrDelOrder.Enabled = true;
            }
        }

        private void buttonConnectClients_Click(object sender, EventArgs e)
        {
            FormConnectedClients formConnected = new FormConnectedClients();
            formConnected.Show();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            FormSales formSales = new FormSales();
            formSales.Show();
        }
    }
}
