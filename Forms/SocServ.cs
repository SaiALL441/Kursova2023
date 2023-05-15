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
    public partial class SocServ : Form
    {
        public SocServ()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            tableBindingSource.EndEdit();
            sample1DataSet.WriteXml($"{Application.StartupPath}/dataSocServ.dat");
            MessageBox.Show("Дані збережено.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SocServ_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{Application.StartupPath}/dataSocServ.dat"))
                sample1DataSet.ReadXml($"{Application.StartupPath}/dataSocServ.dat");
        }

        private void телефонTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 42 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainPage Obj = new MainPage();
            Obj.Show();
            this.Hide();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)

                tableBindingSource.Filter = $"ПІБ like '*{txtSearch.Text}*' or Телефон ='{txtSearch.Text}'"; 
        }
    }
}
