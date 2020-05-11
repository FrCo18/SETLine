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
            //Menu menu = new Menu();
            //if (User.user.type != "HeadAdmin" && User.user.type != "Администратор")
            //{
            //    menu.Size = new Size(442, 509);
            //}
            //else
            //{
            //    menu.Size = new Size(792, 509);
            //}
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
        private void Menu_Load(object sender, EventArgs e)
        {
            //if (User.user.type != "Продавец услуг сотовой связи")
            //{
            //    buttonConnectClient.Enabled = false;
            //    buttonRates.Enabled = false;
            //    menu.Size = new Size(792, 509);
            //}
            //else
            //{
            //    menu.Size = new Size(442, 355);
            //    buttonConnectClient.Enabled = true;
            //    buttonRates.Enabled = true;
            //}
            if (User.user.type != "Продавец услуг сотовой связи")
            {
                buttonConnectClient.Location = new Point(407, buttonConnectClient.Location.Y);
                buttonRates.Location = new Point(407, buttonRates.Location.Y);
                buttonConnectClient.Visible = false;
                buttonRates.Visible = false;
            }
            else
            {
                buttonConnectClient.Location = new Point(33, buttonConnectClient.Location.Y);
                buttonRates.Location = new Point(33, buttonRates.Location.Y);
                buttonConnectClient.Visible = true;
                buttonRates.Visible = true;
                this.Height = 424;
            }
            if (User.user.type != "HeadAdmin" && User.user.type != "Администратор" && User.user.type != "Консультант-продавец товаров")
            {
                buttonInventory.Visible = false;
                buttonAddOrDelOrder.Visible = false;
                buttonInventory.Location = new Point(33, 254);
                buttonAddOrDelOrder.Location = new Point(33, 191);
            }
            else
            {
                buttonInventory.Visible = true;
                buttonAddOrDelOrder.Visible = true;
                buttonInventory.Location = new Point(33, 191);
                buttonAddOrDelOrder.Location = new Point(33, 254);
                this.Height = 416;
            }
            if (User.user.type != "HeadAdmin" && User.user.type != "Администратор")
            {
                buttonWorkers.Visible = false;
                buttonConnectedClients.Visible = false;
                buttonSales.Visible = false;
                this.Width = 442;
            }
            else
            {
                buttonInventory.Visible = true;
                buttonWorkers.Visible = true;
                buttonConnectedClients.Visible = true;
                buttonSales.Visible = true;
                buttonConnectClient.Visible = true;
                buttonRates.Visible = true;
                buttonRates.Location = new Point(407, buttonRates.Location.Y);
                buttonInventory.Location = new Point(33, 254);
                buttonAddOrDelOrder.Location = new Point(33, 317);
                this.Height = 516;
                this.Width = 792;
            }
        }
    }
}
