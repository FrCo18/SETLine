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
    public partial class FormRates : Form
    {
        public FormRates()
        {
            InitializeComponent();
            ShowRates();
            textBoxGB.MaxLength = 10;
            textBoxPrice.MaxLength = 10;
            textBoxMinutes.MaxLength = 10;
        }
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8 || sym == 127)
            {
                e.Handled = true;
            }
        }
        void ShowRates()
        {
            listViewRates.Items.Clear();
            foreach (Rates rates in Program.stlBD.Rates)
            {
                ListViewItem item = new ListViewItem(new string[] {
                rates.Rate, rates.GB.ToString(), rates.MIN.ToString(), rates.Price.ToString()
                });
                item.Tag = rates;
                listViewRates.Items.Add(item);
                listViewRates.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textRate.Text != "" && textBoxGB.Text != "" && textBoxMinutes.Text != "")
            {
                Rates rates = new Rates();
                rates.Rate = textRate.Text;
                rates.GB = Convert.ToInt32(textBoxGB.Text);
                rates.MIN = Convert.ToInt32(textBoxMinutes.Text);
                rates.Price = Convert.ToInt32(textBoxPrice.Text);
                Program.stlBD.Rates.Add(rates);
                Program.stlBD.SaveChanges();
                ShowRates();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewRates.SelectedItems.Count == 1)
            {
                if (textRate.Text != "" && textBoxGB.Text != "" && textBoxMinutes.Text != "")
                {
                    Rates rates = listViewRates.SelectedItems[0].Tag as Rates;
                    rates.Rate = textRate.Text;
                    rates.GB = Convert.ToInt32(textBoxGB.Text);
                    rates.MIN = Convert.ToInt32(textBoxMinutes.Text);
                    rates.Price = Convert.ToInt32(textBoxPrice.Text);
                    Program.stlBD.SaveChanges();
                    ShowRates();
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void listViewRates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRates.SelectedItems.Count == 1)
            {
                Rates rates = listViewRates.SelectedItems[0].Tag as Rates;
                textRate.Text = rates.Rate;
                textBoxGB.Text = rates.GB.ToString();
                textBoxMinutes.Text = rates.MIN.ToString();
                textBoxPrice.Text = rates.Price.ToString();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewRates.SelectedItems.Count == 1)
                {
                    Rates rates = listViewRates.SelectedItems[0].Tag as Rates;
                    Program.stlBD.Rates.Remove(rates);
                    Program.stlBD.SaveChanges();
                    ShowRates();
                }
            }
            catch
            {
                MessageBox.Show("Поле используется!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
