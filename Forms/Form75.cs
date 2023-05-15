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
    public partial class Form75 : Form
    {
        public Form75()
        {
            InitializeComponent();
        }

        private void _75TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            _75TableBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/data75.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form75_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/data75.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/data75.dat");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage Obj = new MainPage();
            Obj.Show();
            this.Hide();
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this._75TableBindingSource.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this._75TableBindingSource.Sort = this.advancedDataGridView1.SortString;
        }

        private void _75TableBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotal.Text = string.Format("Кількість справ: {0}", this._75TableBindingSource.List.Count);
        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 42 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

       
    }
}
