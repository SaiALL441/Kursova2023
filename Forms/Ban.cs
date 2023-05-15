using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppKursova.Forms
{
    public partial class Ban : Form
    {
        public Ban()
        {
            InitializeComponent();
        }

        private void banTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            banTableBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/dataBan.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Ban_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/dataBan.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/dataBan.dat");

        }

        private void banTableBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblBanN.Text = string.Format("Кількість справ: {0}", this.banTableBindingSource.List.Count);
        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 42 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.banTableBindingSource.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.banTableBindingSource.Sort = this.advancedDataGridView1.SortString;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage Obj = new MainPage();
            Obj.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)

                banTableBindingSource.Filter = $"ПІБ like '*{textBox1.Text}*' or Телефон ='{textBox1.Text}'";
        }
    }
}
