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
    public partial class FormWorkers : Form
    {
        public FormWorkers()
        {
            InitializeComponent();
            ShowListWorkers();
            textBoxPhone.MaxLength = 11;
        }
        void ShowListWorkers()
        {
            listViewWorkers.Items.Clear();
            foreach (Workers workers in Program.stlBD.Workers)
            {
                ListViewItem item = new ListViewItem(new string[] { 
                workers.Type, workers.LastName, workers.FirstName, workers.MiddleName, workers.Salary.ToString(), workers.PercentOfSalary.ToString(), workers.Phone.ToString(),
                workers.login, workers.password
                });
                item.Tag = workers;
                listViewWorkers.Items.Add(item);
            }
            listViewWorkers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text != "" && textBoxFirstName.Text != "" && textBoxSalary.Text != "" && comboBoxType.SelectedItem.ToString() != "" && textBoxSalary.Text != "" && textBoxLogin.Text!=""&&textBoxPassword.Text!="")
            {
                Workers workers = new Workers();
                workers.Type = comboBoxType.SelectedItem.ToString();
                workers.FirstName = textBoxFirstName.Text;
                workers.LastName = textBoxLastName.Text;
                workers.MiddleName = textBoxMiddleName.Text;
                workers.Salary = Convert.ToInt32(textBoxSalary.Text);
                workers.PercentOfSalary = Convert.ToInt32(numericUpDownPercent.Value);
                workers.login = textBoxLogin.Text;
                workers.password = textBoxPassword.Text;
                if (textBoxPhone.Text != "") workers.Phone = Convert.ToInt64(textBoxPhone.Text);
                Program.stlBD.Workers.Add(workers);
                Program.stlBD.SaveChanges();
                ShowListWorkers();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewWorkers.SelectedItems.Count == 1)
            {
                if (textBoxLastName.Text != "" && textBoxFirstName.Text != "" && textBoxSalary.Text != "" && comboBoxType.SelectedItem.ToString() != "" && textBoxSalary.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "")
                {
                    Workers workers = listViewWorkers.SelectedItems[0].Tag as Workers;
                    workers.Type = comboBoxType.SelectedItem.ToString();
                    workers.FirstName = textBoxFirstName.Text;
                    workers.LastName = textBoxLastName.Text;
                    workers.MiddleName = textBoxMiddleName.Text;
                    workers.Salary = Convert.ToInt32(textBoxSalary.Text);
                    workers.PercentOfSalary = Convert.ToInt32(numericUpDownPercent.Value);
                    workers.login = textBoxLogin.Text;
                    workers.password = textBoxPassword.Text;
                    if (textBoxPhone.Text != "") { workers.Phone = Convert.ToInt64(textBoxPhone.Text); }
                    Program.stlBD.SaveChanges();
                    ShowListWorkers();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8 ||sym == 127)
            {
                e.Handled = true;
            }
        }

        private void KeyPressFalse(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void listViewWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewWorkers.SelectedItems.Count == 1)
            {
                Workers workers = listViewWorkers.SelectedItems[0].Tag as Workers;
                comboBoxType.SelectedItem = workers.Type.ToString();
                textBoxLastName.Text = workers.LastName;
                textBoxFirstName.Text = workers.FirstName;
                textBoxMiddleName.Text = workers.MiddleName;
                textBoxSalary.Text = workers.Salary.ToString();
                numericUpDownPercent.Value = workers.PercentOfSalary;
                textBoxLogin.Text = workers.login;
                textBoxPassword.Text = workers.password;
                textBoxPhone.Text = workers.Phone.ToString();
                if (User.user.type != "HeadAdmin")
                {
                    if (listViewWorkers.SelectedItems[0].SubItems[0].Text != "HeadAdmin")
                    {
                        buttonEdit.Enabled = true;
                        buttonDel.Enabled = true;
                    }
                    else
                    {
                        buttonEdit.Enabled = false;
                        buttonDel.Enabled = false;
                        comboBoxType.SelectedItem = null;
                    }
                }
                else
                {
                    if (listViewWorkers.SelectedItems[0].SubItems[0].Text != "HeadAdmin")
                    {
                        buttonEdit.Enabled = true;
                        buttonDel.Enabled = true;
                    }
                    else
                    {
                        buttonEdit.Enabled = true;
                        buttonDel.Enabled = false;
                        comboBoxType.SelectedItem = null;
                    }
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewWorkers.SelectedItems.Count == 1)
                {
                    if (textBoxLastName.Text != "" && textBoxFirstName.Text != "" && textBoxSalary.Text != "" && comboBoxType.SelectedItem.ToString() != "" && textBoxSalary.Text != "")
                    {
                        Workers workers = listViewWorkers.SelectedItems[0].Tag as Workers;
                        Program.stlBD.Workers.Remove(workers);
                        Program.stlBD.SaveChanges();
                        ShowListWorkers();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Поле используется", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
    }
}
