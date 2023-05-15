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
using System.Data.SqlClient;
using System.Collections;

namespace WindowsFormsAppKursova.Forms
{
    public partial class Works : Form
    {
        public Works()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage Obj = new MainPage();
            Obj.Show();
            this.Hide();
        }

        private void woTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            woTableBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/dataWorks.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Works_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/dataWorks.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/dataWorks.dat"); 

        }

       

        private void woTableBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblN.Text = string.Format("Кількість справ: {0}", this.woTableBindingSource.List.Count);
        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 42 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true; 
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)

                woTableBindingSource.Filter = $"ПІБ like '*{textBox1.Text}*' or Телефон ='{textBox1.Text}' or Вид покарання like '*{textBox1.Text}*'";
        }
    }
}

