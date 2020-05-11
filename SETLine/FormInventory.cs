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
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
            comboBoxCategory.SelectedIndex = 0;
            ShowListTovars();
            textBoxQuantity.MaxLength = 10;
            textBoxPrice.MaxLength = 10;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem.ToString() == "Телефоны")
            {
                listViewPhones.Visible = true;
                listViewSmartPhones.Visible = false;
                listViewPeriphery.Visible = false;
                ShowListTovars();
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Смартфоны")
            {
                listViewPhones.Visible = false;
                listViewSmartPhones.Visible = true;
                listViewPeriphery.Visible = false;
                ShowListTovars();
            }
            else
            {
                listViewPhones.Visible = false;
                listViewSmartPhones.Visible = false;
                listViewPeriphery.Visible = true;
                ShowListTovars();
            }
        }
        void ShowListTovars()
        {
            if (comboBoxCategory.SelectedItem.ToString() == "Телефоны")
            {
                listViewPhones.Items.Clear();
                foreach (Inventory inventory in Program.stlBD.Inventory)
                {
                    if (inventory.Category == "Телефоны")
                    {
                        ListViewItem item = new ListViewItem(new string[] {
                    inventory.NameTovar, inventory.Category, inventory.Quantity.ToString(), inventory.Price.ToString()
                    });
                        item.Tag = inventory;
                        listViewPhones.Items.Add(item);
                        listViewPhones.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
            }
            else if (comboBoxCategory.SelectedItem.ToString() == "Смартфоны")
            {
                listViewSmartPhones.Items.Clear();
                foreach (Inventory inventory in Program.stlBD.Inventory)
                {
                    if (inventory.Category == "Смартфоны")
                    {
                        ListViewItem item = new ListViewItem(new string[] {
                    inventory.NameTovar, inventory.Category,inventory.Quantity.ToString(), inventory.Price.ToString()
                    });
                        item.Tag = inventory;
                        listViewSmartPhones.Items.Add(item);
                        listViewSmartPhones.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
            }
            else
            {
                listViewPeriphery.Items.Clear();
                foreach (Inventory inventory in Program.stlBD.Inventory)
                {
                    if (inventory.Category == "Периферия")
                    {
                        ListViewItem item = new ListViewItem(new string[] {
                    inventory.NameTovar, inventory.Category,inventory.Quantity.ToString(), inventory.Price.ToString()
                    });
                        item.Tag = inventory;
                        listViewPeriphery.Items.Add(item);
                        listViewPeriphery.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
            }
        }
        private void KeyPressFalse(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8 || sym == 127)
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            if (textBoxName.Text != "" && textBoxPrice.Text != "" && textBoxQuantity.Text != "")
            {
                inventory.NameTovar = textBoxName.Text;
                inventory.Category = comboBoxCategory.SelectedItem.ToString();
                inventory.Price = Convert.ToInt32(textBoxPrice.Text);
                inventory.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                Program.stlBD.Inventory.Add(inventory);
                Program.stlBD.SaveChanges();
                ShowListTovars();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem.ToString() == "Телефоны")
            {
                if (listViewPhones.SelectedItems.Count == 1)
                {
                    Inventory inventory = listViewPhones.SelectedItems[0].Tag as Inventory;
                    if (textBoxName.Text != "" && textBoxPrice.Text != "" && textBoxQuantity.Text != "")
                    {
                        inventory.NameTovar = textBoxName.Text;
                        inventory.Category = comboBoxCategory.SelectedItem.ToString();
                        inventory.Price = Convert.ToInt32(textBoxPrice.Text);
                        inventory.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                        Program.stlBD.SaveChanges();
                        ShowListTovars();
                    }
                }
            }
            if (comboBoxCategory.SelectedItem.ToString() == "Смартфоны")
            {
                if (listViewSmartPhones.SelectedItems.Count == 1)
                {
                    Inventory inventory = listViewSmartPhones.SelectedItems[0].Tag as Inventory;
                    if (textBoxName.Text != "" && textBoxPrice.Text != "" && textBoxQuantity.Text != "")
                    {
                        inventory.NameTovar = textBoxName.Text;
                        inventory.Category = comboBoxCategory.SelectedItem.ToString();
                        inventory.Price = Convert.ToInt32(textBoxPrice.Text);
                        inventory.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                        Program.stlBD.SaveChanges();
                        ShowListTovars();
                    }
                }
            }
            else
            {
                if (listViewPeriphery.SelectedItems.Count == 1)
                {
                    Inventory inventory = listViewPeriphery.SelectedItems[0].Tag as Inventory;
                    if (textBoxName.Text != "" && textBoxPrice.Text != "" && textBoxQuantity.Text != "")
                    {
                        inventory.NameTovar = textBoxName.Text;
                        inventory.Category = comboBoxCategory.SelectedItem.ToString();
                        inventory.Price = Convert.ToInt32(textBoxPrice.Text);
                        inventory.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                        Program.stlBD.SaveChanges();
                        ShowListTovars();
                    }
                }
            }
        }

        private void listViewPeriphery_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPeriphery.SelectedItems.Count == 1)
            {
                Inventory inventory = listViewPeriphery.SelectedItems[0].Tag as Inventory;
                textBoxName.Text = inventory.NameTovar;
                comboBoxCategory.SelectedItem = inventory.Category;
                textBoxQuantity.Text = inventory.Quantity.ToString();
                textBoxPrice.Text = inventory.Price.ToString();
            }
        }

        private void listViewSmartPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSmartPhones.SelectedItems.Count == 1)
            {
                Inventory inventory = listViewSmartPhones.SelectedItems[0].Tag as Inventory;
                textBoxName.Text = inventory.NameTovar;
                comboBoxCategory.SelectedItem = inventory.Category;
                textBoxQuantity.Text = inventory.Quantity.ToString();
                textBoxPrice.Text = inventory.Price.ToString();
            }
        }

        private void listViewPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPhones.SelectedItems.Count == 1)
            {
                Inventory inventory = listViewPhones.SelectedItems[0].Tag as Inventory;
                textBoxName.Text = inventory.NameTovar;
                comboBoxCategory.SelectedItem = inventory.Category;
                textBoxQuantity.Text = inventory.Quantity.ToString();
                textBoxPrice.Text = inventory.Price.ToString();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedItem.ToString() == "Телефоны")
            {
                Inventory inventory = listViewPhones.SelectedItems[0].Tag as Inventory;
                Program.stlBD.Inventory.Remove(inventory);
                Program.stlBD.SaveChanges();
                ShowListTovars();
            }
            if (comboBoxCategory.SelectedItem.ToString() == "Смартфоны")
            {
                Inventory inventory = listViewSmartPhones.SelectedItems[0].Tag as Inventory;
                Program.stlBD.Inventory.Remove(inventory);
                Program.stlBD.SaveChanges();
                ShowListTovars();
            }
            else
            {
                if (listViewPeriphery.SelectedItems.Count == 1)
                {
                    Inventory inventory =listViewPeriphery.SelectedItems[0].Tag as Inventory;
                    Program.stlBD.Inventory.Remove(inventory);
                    Program.stlBD.SaveChanges();
                    ShowListTovars();
                }
            }
        }
    }
}
