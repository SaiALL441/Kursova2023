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
    public partial class Court : Form
    {
        public Court()
        {
            InitializeComponent();
        }

        private void courtTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            courtTableBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/dataCourt.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Court_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/dataCourt.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/dataCourt.dat");

        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 42 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void txtCourt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)

                courtTableBindingSource.Filter = $"ПІБ like '*{txtCourt.Text}*' or Телефон ='{txtCourt.Text}' or Канцелярія like '*{txtCourt.Text}*' or ПІБ судді like '*{txtCourt.Text}*'";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage Obj = new MainPage();
            Obj.Show();
            this.Hide();
        }
    }
}
